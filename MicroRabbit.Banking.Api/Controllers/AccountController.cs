using AutoMapper;
using MicroRabbit.Banking.Api.DTO;
using MicroRabbit.Banking.Application.Services.AccountService;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Banking.Api.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccounts()
        {
            return Ok(await _accountService.GetAllAccount());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccountById(int id)
        {
            return Ok(await _accountService.GetAccountById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddAcount(AccountDto accountDto)
        {
            var account = _mapper.Map<Account>(accountDto);

            return Ok(await _accountService.AddAccount(account));
        }
    }
}
