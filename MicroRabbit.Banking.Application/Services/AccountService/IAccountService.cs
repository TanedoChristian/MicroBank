using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services.AccountService
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAccount();
        Task<Account> GetAccountById(int id);

        Task AddAccount(Account account);
    }
}
