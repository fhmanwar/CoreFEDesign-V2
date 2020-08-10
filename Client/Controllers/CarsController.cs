using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace Client.Controllers
{
    public class CarsController : Controller
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

            IEnumerable<CarVM> car = null;
            var responseTask = client.GetAsync("Cars");
            responseTask.Wait();
            var rst = responseTask.Result;
            if (rst.IsSuccessStatusCode)
            {
                var readTask = rst.Content.ReadAsAsync<IList<CarVM>>();
                readTask.Wait();
                car = readTask.Result;

            }

            var comlumHeadrs = new string[]
            {
                "id_car",
                "nm_car",
                "transmition",
                "year",
                "price",
                "merkid",
                "merkname"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("Current Car"); //Worksheet name
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
                foreach (var data in car)
                {
                    worksheet.Cells["A" + j].Value = data.id_car;
                    worksheet.Cells["B" + j].Value = data.nm_car;
                    worksheet.Cells["C" + j].Value = data.transmition;
                    worksheet.Cells["D" + j].Value = data.year;
                    worksheet.Cells["E" + j].Value = data.price;
                    worksheet.Cells["F" + j].Value = data.merkID;
                    worksheet.Cells["G" + j].Value = data.merkName;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"Car.xlsx");
        }

        public JsonResult LoadCar()
        {
            IEnumerable<CarVM> carVM = null;
            var resTask = client.GetAsync("cars");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<CarVM>>();
                readTask.Wait();
                carVM = readTask.Result;
            }
            else
            {
                carVM = Enumerable.Empty<CarVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(carVM);

        }

        public JsonResult GetById(int Id)
        {
            CarVM carVM = null;
            var resTask = client.GetAsync("cars/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                carVM = JsonConvert.DeserializeObject<CarVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(carVM);
        }

        public JsonResult InsertOrUpdate(CarVM carVM, int id_car)
        {
            try
            {
                var json = JsonConvert.SerializeObject(carVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (carVM.id_car == 0)
                {
                    var result = client.PostAsync("cars", byteContent).Result;
                    return Json(result);
                }
                else if (carVM.id_car == id_car)
                {
                    var result = client.PutAsync("cars/" + id_car, byteContent).Result;
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
            var result = client.DeleteAsync("cars/" + id).Result;
            return Json(result);
        }
    }
}
