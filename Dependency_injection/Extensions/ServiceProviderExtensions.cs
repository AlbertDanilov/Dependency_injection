﻿using Dependency_injection.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dependency_injection.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static void AddTimeService(this IServiceCollection services) {
            services.AddTransient<TimeService>();
        }
    }
}
