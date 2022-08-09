using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstrack;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployesController : Controller
    {
        private IEmployessService _employessService;
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getall")]
        public IActionResult GetList()
        {

            var result = _employessService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
