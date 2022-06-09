using ef_coreCodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ef_coreCodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly CompanyContext _companyContext;

        public HomeController(ILogger<HomeController> logger, CompanyContext companyContext)
        {
            _logger = logger;
            _companyContext = companyContext;
        }

        public IActionResult Index()
        {

            //var employees = _companyContext.Employees.Where(x => x.Id > 1);
            var employees = _companyContext.Employees.FromSqlRaw("Select * from Employees ").ToList();

            return View(employees);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {

            //var employees = _companyContext.Employees.Where(x => x.Id > 1);
            var employees = _companyContext.Employees.FromSqlRaw("Select * from Employees where name ='" + name + "'").ToList();

            return View(employees);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
