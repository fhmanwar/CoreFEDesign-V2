using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repository;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthsController : ControllerBase
    {
        AuthRepo _authRepo;
        public AuthsController(AuthRepo authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpGet("{uname}")]
        public AccountVM Login(string uname)
        {
            return _authRepo.Login(uname);
        }

        [HttpPost]
        public IActionResult Register(AccountVM accountVM)
        {
            var create = _authRepo.Register(accountVM);
            if (create > 0)
            {
                return Ok(create);
            }
            return BadRequest("Not Successfully");
        }
    }
}
