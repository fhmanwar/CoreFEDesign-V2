using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Client.Controllers
{
    public class AccountsController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            //BaseAddress = new Uri("https://localhost:44339/api/")
            BaseAddress = new Uri("https://localhost:5000/api/")
        };
        public IActionResult Index()
        {
            return View("~/Views/Auth/Index.cshtml");
        }
        public JsonResult LoadKonsumen()
        {
            IEnumerable<Account> accounts = null;
            var resTask = client.GetAsync("accounts");
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<List<Account>>();
                readTask.Wait();
                accounts = readTask.Result;
            }
            else
            {
                accounts = Enumerable.Empty<Account>();
                ModelState.AddModelError(string.Empty, "Server Error try after sometimes.");
            }
            return Json(accounts);

        }

        public JsonResult GetById(int Id)
        {
            Account accounts = null;
            var resTask = client.GetAsync("accounts/" + Id);
            resTask.Wait();

            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                accounts = JsonConvert.DeserializeObject<Account>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Server Error.");
            }
            return Json(accounts);
        }

        public JsonResult InsertOrUpdate(Account accounts, int id_account)
        {
            try
            {
                var json = JsonConvert.SerializeObject(accounts);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                if (accounts.id_account == 0)
                {
                    var result = client.PostAsync("accounts", byteContent).Result;
                    return Json(result);
                }
                else if (accounts.id_account == id_account)
                {
                    var result = client.PutAsync("accounts/" + id_account, byteContent).Result;
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
