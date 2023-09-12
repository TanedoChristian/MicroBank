using MicroRabbit.Banking.Data.Repository.AccountRepository;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Banking.Domain.Models;
using MicroRabbit.Domain.Core.Bus;
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
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public async Task<IEnumerable<Account>> GetAllAccount()
        {
            return await _accountRepository.GetAll();
        }

        public async Task<Account> GetAccountById(int id)
        {
            return await _accountRepository.GetById(id);
        }

        public async Task<Account> AddAccount(Account account)
        {
             await _accountRepository.Create(account);
            return account;
        }

       

        public void TransferFunds(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TranferAmount
                );

            _eventBus.SendCommand(createTransferCommand);
        }
    }
}
