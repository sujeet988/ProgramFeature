using ProgramFeature.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramFeature.Service.ViewModels
{
 public   class ProgrammePortfolioViewModel
    {

        public IEnumerable<ProgrammePortfolioModel> ProgrammePortfolios { get; set; }
        public IEnumerable<Employedata> empdatadetails { get; set; }


    }
}
