using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProgramFeature.Service.Interfaces;
using ProgramFeature.Service.ViewModels;

namespace ProgramFeature.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramFeaturemasterController : ControllerBase
    {

        private IProgramPortfolioService _programPortfolioService;
        public ProgramFeaturemasterController(IProgramPortfolioService programPortfolioService)
        {
            _programPortfolioService = programPortfolioService;


        }

        [HttpGet]
        public IActionResult GetPortfolio()
        {
            ProgrammePortfolioViewModel obj = _programPortfolioService.getemp();
            return Ok(obj.empdatadetails);
        }




    }

}