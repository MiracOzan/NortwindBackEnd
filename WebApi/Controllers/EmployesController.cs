﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[Employess]")]
    [ApiController]
    public class EmployesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
