using MicroRabbit.Banking.Application.Services.AccountService;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> PostData(IEnumerable<Account> account)
        {
            await _accountService.AddAccount(account);

            return Ok("success");
        }
    }
}
