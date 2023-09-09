using MicroRabbit.Banking.Data.Repository.AccountRepository;
using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<IEnumerable<Account>> GetAllAccount()
        {
            return await _accountRepository.GetAll();
        }

        public async Task<Account> GetAccount(int id)
        {
            return await _accountRepository.GetById(id);
        }

        public async Task AddAccount(Account account)
        {
             await _accountRepository.Create(account);
        }
    }
}
