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
                            HttpContext.Session.SetInt32("id", account.id_acc);
                            HttpContext.Session.SetString("uname", account.Uname);
                            HttpContext.Session.SetString("name", account.name);
                            HttpContext.Session.SetString("lvl", account.access);
                            if (account.access == "Admin")
                            {
                                return Json(new { status = true, msg = "Login Successfully !", acc = "admin" });
                            }
                            else
                            {
                                return Json(new { status = true, msg = "Login Successfully !", acc = "user" });
                            }
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
                    return RedirectToAction("Login", "Auth");
                }
            }
            else if (accountVM.name != null)
            {
                var json = JsonConvert.SerializeObject(accountVM);
                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = client.PostAsync("auths", byteContent).Result;
                if (result.IsSuccessStatusCode)
                {
                    return Json(new { status = true, code = result, msg = "Register Success! " });
                }
                else
                {
                    return Json(new { status = false, msg = "Something Wrong!" });
                }
            }
            return RedirectToAction("Notfound", "Auth");
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
