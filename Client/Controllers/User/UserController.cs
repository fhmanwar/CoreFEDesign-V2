using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers.User
{
    public class UserController : Controller
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
                return RedirectToAction("Index", "Home");
            }
            else if (level == "User")
            {
                return View("~/Views/User/UserDasbor.cshtml");
            }
            else
            {
                return Redirect("/validate");
            }
        }

        public JsonResult LoadData()
        {
            var userID = HttpContext.Session.GetInt32("id");
            IEnumerable<ReserveVM> reserveVM = null;
            var resTask = client.GetAsync("users/" + userID);
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

        public JsonResult GetById()
        {
            var id = HttpContext.Session.GetInt32("id");
            ReserveVM reserveVM = null;
            var resTask = client.GetAsync("users/" + id);
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

    }
}
