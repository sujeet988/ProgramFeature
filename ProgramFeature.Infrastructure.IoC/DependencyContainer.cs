﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

using ProgramFeature.Domain.Interfaces;
using ProgramFeature.Infrastructure.Data.Repositories;
using ProgramFeature.Application.Interfaces;
using ProgramFeature.Application.Services;

namespace ProgramFeature.Infrastructure.IoC
{
  public  class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {
            //CleanArchitecture.Application
            services.AddScoped<IProgramPortfolioService, ProgramPortfolioService>();

            //CleanArchitecture.Domain.Interfaces | CleanArchitecture.Infra.Data.Repositories
            services.AddScoped<IProgramPortfolioRepository, ProgramPortfolioRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}