using ProgramFeature.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFeature.Application.Interfaces
{
    public interface IProgramPortfolioService
    {
        public ProgrammePortfolioViewModel GetProgrammePortfolio();
        public ProgrammePortfolioViewModel getemp();


    }
}
