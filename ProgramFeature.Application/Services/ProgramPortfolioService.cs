﻿using ProgramFeature.Service.Interfaces;
using ProgramFeature.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using ProgramFeature.Domain.Interfaces;

namespace ProgramFeature.Service.Services
{
 public   class ProgramPortfolioService : IProgramPortfolioService
    {

        public IProgramPortfolioRepository  _programPortfolioRepository;

        public ProgramPortfolioService(IProgramPortfolioRepository programPortfolioRepository)
        {
            _programPortfolioRepository = programPortfolioRepository;
        }

        public ProgrammePortfolioViewModel getemp()
        {
            return new ProgrammePortfolioViewModel()
            {
                empdatadetails = _programPortfolioRepository.GetEmpdata()

            };
        }

        public ProgrammePortfolioViewModel GetProgrammePortfolio()
        {
            return new ProgrammePortfolioViewModel()
            {
                ProgrammePortfolios = _programPortfolioRepository.GetProgrammePortfolio()

            };
        }
    }
}
