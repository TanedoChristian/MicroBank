using MediatR;
using MicroRabbit.Banking.Application.Services.AccountService;
using MicroRabbit.Banking.Data.DataContext;
using MicroRabbit.Banking.Data.Repository.AccountRepository;
using MicroRabbit.Banking.Domain.CommandHandlers;
using MicroRabbit.Banking.Domain.Commands;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infra.IoC
{
    public  class DependencyContainer
    {
        public static void  RegisterService(IServiceCollection services)
        {

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            //Domain Bus
            services.AddScoped<IEventBus, RabbitMQBus>();

            //Services
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            //Banking Data
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<BankingDbContext>();




        }
    }
}
