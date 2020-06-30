using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgramFeature.Domain.Interfaces;
using ProgramFeature.Domain.Models;
using ProgramFeature.Infrastructure.Data.DbModels;

namespace ProgramFeature.Infrastructure.Data.Repositories
{
    public class ProgramPortfolioRepository : IProgramPortfolioRepository
    {

        public programfeatureContext _Context;

        public ProgramPortfolioRepository(programfeatureContext context)
        {
            _Context = context;
        }


        public IEnumerable<Employedata> GetEmpdata()
        {
            List<Employedata> obj = new List<Employedata>();
            obj.Add(new Employedata { empid = "1", name = "sujeet" });
            return obj;
        }

        IEnumerable<ProgrammePortfolioModel> IProgramPortfolioRepository.GetProgrammePortfolio()
        {

            ProgrammePortfolioModel _ProgrammePortfolio = new Domain.Models.ProgrammePortfolioModel();
            var data = _Context.ProgrammePortfolio.ToList<DbModels.ProgrammePortfolio>();
            List<Domain.Models.ProgrammePortfolioModel> List = new List<Domain.Models.ProgrammePortfolioModel>();
            foreach(var a in data)
            {
                List.Add(new Domain.Models.ProgrammePortfolioModel { Id = a.Id, Name=a.Name
                }); ;
            }
            return List;

        }



    }
}
