﻿using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static IServiceCollection RegisterService(IServiceCollection services)
        {
            //Domain Bus

            services.AddTransient<IEventBus, RabbitMQBus>();
            return services;
        }
    }
}
