using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repository.Interface;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        IAccount _iAccount;
        public AccountsController(IAccount account)
        {
            _iAccount = account;
        }

        [HttpGet]
        public async Task<IEnumerable<AccountVM>> GetAllAccount()
        {
            return await _iAccount.getAll();
        }

        [HttpGet("{id}")]
        public AccountVM GetIdAccount(int id)
        {
            return _iAccount.getID(id);
        }

        [HttpPost]
        public IActionResult CreateAccount(AccountVM accountVM)
        {
            var create = _iAccount.Create(accountVM);
            if (create > 0)
            {
                return Ok(create);
            }
            return BadRequest("Not Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult EditAccount(int id, AccountVM accountVM)
        {
            var edit = _iAccount.Update(accountVM, id);
            if (edit > 0)
            {
                return Ok(edit);
            }
            return BadRequest("Not Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAccount(int id)
        {
            var delete = _iAccount.Delete(id);
            if (delete > 0)
            {
                return Ok(delete);
            }
            return BadRequest("Not Successfully");
        }
    }
}
