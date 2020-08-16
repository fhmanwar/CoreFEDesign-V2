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
