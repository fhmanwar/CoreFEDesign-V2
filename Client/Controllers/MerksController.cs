using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace Client.Controllers
{
    public class MerksController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44339/api/")
        };
        public IActionResult Index()
        {
            var level = HttpContext.Session.GetString("lvl");
            if (level == "Admin")
            {
                return View();
            }
            else if (level == "User")
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("NotFound", "Auth");
            }
        }

        public JsonResult LoadMerk()
        {
            IEnumerable<Merk> merks = null;
            var resTask = client.GetAsync("merks");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Merk>>();
                readTask.Wait();
                merks = readTask.Result;
            }
            else
            {
                merks = Enumerable.Empty<Merk>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(merks);

        }

        public JsonResult GetById(int Id)
        {
            Merk merks = null;
            var resTask = client.GetAsync("merks/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                merks = JsonConvert.DeserializeObject<Merk>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(merks);
        }

        public JsonResult InsertOrUpdate(Merk merks, int id_merk)
        {
            try
            {
                var json = JsonConvert.SerializeObject(merks);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (merks.id_merk == 0)
                {
                    var result = client.PostAsync("merks", byteContent).Result;
                    return Json(result);
                }
                else if (merks.id_merk == id_merk)
                {
                    var result = client.PutAsync("merks/" + id_merk, byteContent).Result;
                    return Json(result);
                }

                return Json(404);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public JsonResult Delete(int id)
        {
            var result = client.DeleteAsync("merks/" + id).Result;
            return Json(result);
        }
        public IActionResult Excel()
        {

            IEnumerable<Merk> merk = null;
            var responseTask = client.GetAsync("Merks");
            responseTask.Wait();
            var rst = responseTask.Result;
            if (rst.IsSuccessStatusCode)
            {
                var readTask = rst.Content.ReadAsAsync<IList<Merk>>();
                readTask.Wait();
                merk = readTask.Result;

            }

            var comlumHeadrs = new string[]
            {
                "id_merk",
                "merk"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("Current Merk"); //Worksheet name
                using (var cells = worksheet.Cells[1, 1, 1, 2]) //(1,1) (1,5)
                {
                    cells.Style.Font.Bold = true;
                }

                //First add the headers
                for (var i = 0; i < comlumHeadrs.Count(); i++)
                {
                    worksheet.Cells[1, i + 1].Value = comlumHeadrs[i];
                }

                //Add values
                var j = 2;
                foreach (var data in merk)
                {
                    worksheet.Cells["A" + j].Value = data.id_merk;
                    worksheet.Cells["B" + j].Value = data.merk;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"Merk.xlsx");
        }
    }
}
