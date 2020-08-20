using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace Client.Controllers
{
    public class ReservesController : Controller
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
        public JsonResult LoadReserve()
        {
            IEnumerable<ReserveVM> reserveVM = null;
            var resTask = client.GetAsync("reserves");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<ReserveVM>>();
                readTask.Wait();
                reserveVM = readTask.Result;
            }
            else
            {
                reserveVM = Enumerable.Empty<ReserveVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(reserveVM);

        }

        public JsonResult GetById(int Id)
        {
            ReserveVM reserveVM = null;
            var resTask = client.GetAsync("reserves/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                reserveVM = JsonConvert.DeserializeObject<ReserveVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(reserveVM);
        }

        public JsonResult InsertOrUpdate(ReserveVM reserveVM, int id_reserve)
        {
            try
            {
                var json = JsonConvert.SerializeObject(reserveVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (reserveVM.id_reserve == 0)
                {
                    var result = client.PostAsync("reserves", byteContent).Result;
                    return Json(result);
                }
                else if (reserveVM.id_reserve == id_reserve)
                {
                    var result = client.PutAsync("reserves/" + id_reserve, byteContent).Result;
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
            var result = client.DeleteAsync("reserves/" + id).Result;
            return Json(result);
        }
        public IActionResult Excel()
        {

            IEnumerable<ReserveVM> reserve = null;
            var responseTask = client.GetAsync("Reserves");
            responseTask.Wait();
            var rst = responseTask.Result;
            if (rst.IsSuccessStatusCode)
            {
                var readTask = rst.Content.ReadAsAsync<IList<ReserveVM>>();
                readTask.Wait();
                reserve = readTask.Result;

            }

            var comlumHeadrs = new string[]
            {
                "id_reserve",
                "start_date",
                "end_date",
                "status",
                "total",
                "tgl_bayar",
                "carID",
                "carName",
                "carTransmition",
                "carYear",
                "carMerk",
                "accountID",
                "accountName",
                "accountAlamat",
                "accountPhone"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("Current Reserve"); //Worksheet name
                using (var cells = worksheet.Cells[1, 1, 1, 15]) //(1,1) (1,5)
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
                foreach (var data in reserve)
                {
                    worksheet.Cells["A" + j].Value = data.id_reserve;
                    worksheet.Cells["B" + j].Value = data.start_date;
                    worksheet.Cells["C" + j].Value = data.end_date;
                    worksheet.Cells["D" + j].Value = data.status;
                    worksheet.Cells["E" + j].Value = data.total;
                    worksheet.Cells["F" + j].Value = data.tgl_bayar;
                    worksheet.Cells["G" + j].Value = data.carID;
                    worksheet.Cells["H" + j].Value = data.carName;
                    worksheet.Cells["I" + j].Value = data.carTransmition;
                    worksheet.Cells["J" + j].Value = data.carYear;
                    worksheet.Cells["K" + j].Value = data.carMerk;
                    worksheet.Cells["L" + j].Value = data.accountID;
                    worksheet.Cells["M" + j].Value = data.accountName;
                    worksheet.Cells["N" + j].Value = data.accountAddr;
                    worksheet.Cells["O" + j].Value = data.accountPhone;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"Reserve.xlsx");
        }
    }
}
