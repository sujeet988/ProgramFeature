using ProgramFeature.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFeature.Domain.Interfaces
{
    public interface IProgramPortfolioRepository
    {

        IEnumerable<ProgrammePortfolioModel> GetProgrammePortfolio();
        IEnumerable<Employedata> GetEmpdata();

    }
}
