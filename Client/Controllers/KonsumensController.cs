using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace Client.Controllers
{
    public class KonsumensController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44339/api/")
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Excel()
        {

            IEnumerable<Konsumen> konsumen = null;
            var responseTask = client.GetAsync("Konsumens");
            responseTask.Wait();
            var rst = responseTask.Result;
            if (rst.IsSuccessStatusCode)
            {
                var readTask = rst.Content.ReadAsAsync<IList<Konsumen>>();
                readTask.Wait();
                konsumen = readTask.Result;

            }

            var comlumHeadrs = new string[]
            {
                "id_konsumen",
                "nama",
                "alamat",
                "tlp"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("Current Konsumen"); //Worksheet name
                using (var cells = worksheet.Cells[1, 1, 1, 7]) //(1,1) (1,5)
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
                foreach (var data in konsumen)
                {
                    worksheet.Cells["A" + j].Value = data.id_konsumen;
                    worksheet.Cells["B" + j].Value = data.nama;
                    worksheet.Cells["C" + j].Value = data.alamat;
                    worksheet.Cells["D" + j].Value = data.tlp;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"Konsumen.xlsx");
        }

        public JsonResult LoadKonsumen()
        {
            IEnumerable<Konsumen> konsumens = null;
            var resTask = client.GetAsync("konsumens");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Konsumen>>();
                readTask.Wait();
                konsumens = readTask.Result;
            }
            else
            {
                konsumens = Enumerable.Empty<Konsumen>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(konsumens);

        }

        public JsonResult GetById(int Id)
        {
            Konsumen konsumens = null;
            var resTask = client.GetAsync("konsumens/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                konsumens = JsonConvert.DeserializeObject<Konsumen>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(konsumens);
        }

        public JsonResult InsertOrUpdate(Konsumen konsumens, int id_konsumen)
        {
            try
            {
                var json = JsonConvert.SerializeObject(konsumens);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (konsumens.id_konsumen == 0)
                {
                    var result = client.PostAsync("konsumens", byteContent).Result;
                    return Json(result);
                }
                else if (konsumens.id_konsumen == id_konsumen)
                {
                    var result = client.PutAsync("konsumens/" + id_konsumen, byteContent).Result;
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
            var result = client.DeleteAsync("konsumens/" + id).Result;
            return Json(result);
        }
    }
}
