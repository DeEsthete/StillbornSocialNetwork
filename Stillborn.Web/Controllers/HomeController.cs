using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stillborn.Domain.Entities;
using Stillborn.Services.Repositories;

namespace Stillborn.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly RepositoryService service;

        public HomeController(RepositoryService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}