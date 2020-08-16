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
    public class AccountsController : Controller
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
        public JsonResult LoadAccount()
        {
            IEnumerable<AccountVM> accounts = null;
            var resTask = client.GetAsync("accounts");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<AccountVM>>();
                readTask.Wait();
                accounts = readTask.Result;
            }
            else
            {
                accounts = Enumerable.Empty<AccountVM>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(accounts);

        }

        public JsonResult GetById(int Id)
        {
            AccountVM accounts = null;
            var resTask = client.GetAsync("accounts/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                accounts = JsonConvert.DeserializeObject<AccountVM>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(accounts);
        }

        public JsonResult InsertOrUpdate(AccountVM accounts, int id_acc)
        {
            try
            {
                var json = JsonConvert.SerializeObject(accounts);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (accounts.id_acc == 0)
                {
                    var result = client.PostAsync("accounts", byteContent).Result;
                    return Json(result);
                }
                else if (accounts.id_acc == id_acc)
                {
                    var result = client.PutAsync("accounts/" + id_acc, byteContent).Result;
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
            var result = client.DeleteAsync("accounts/" + id).Result;
            return Json(result);
        }
    }
}
