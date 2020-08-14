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
using BC = BCrypt.Net.BCrypt;

namespace Client.Controllers
{
    public class AuthController : Controller
    {
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44339/api/")
        };

        [Route("login")]
        public IActionResult Login()
        {
            return View("~/Views/Accounts/Login.cshtml");
        }

        [Route("register")]
        public IActionResult Register()
        {
            return View("~/Views/Accounts/Register.cshtml");
        }

        [Route("validate")]
        public IActionResult Validate(AccountVM accountVM)
        {
            if (accountVM.name == null)
            {
                var resTask = client.GetAsync("auths/" + accountVM.Uname);
                resTask.Wait();
                var result = resTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsStringAsync().Result;
                    if (data != "")
                    {
                        var json = JsonConvert.DeserializeObject(data).ToString();
                        var account = JsonConvert.DeserializeObject<AccountVM>(json);
                        if (BC.Verify(accountVM.pass, account.pass) && (account.access == "Admin" || account.access == "User"))
                        {
                            HttpContext.Session.SetString("uname", account.Uname);
                            HttpContext.Session.SetString("name", account.name);
                            HttpContext.Session.SetString("lvl", account.access);
                            return Json(new { status = true, msg = "Login Successfully !" });
                        }
                        else
                        {
                            return Json(new { status = false, msg = "Invalid Username or Password!" });
                        }
                    }
                    else
                    {
                        return Json(new { status = false, msg = "Username Not Found!" });
                    }                    
                }
                else
                {
                    return RedirectToAction("Notfound", "Auth");
                }
            }
            else
            {
                var json = JsonConvert.SerializeObject(accountVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            }
            return RedirectToAction("Login", "Auth");
        }

        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Auth");
        }

        [Route("notfound")]
        public IActionResult Notfound()
        {
            return View("~/Views/Accounts/NotFound.cshtml");
        }
    }
}
