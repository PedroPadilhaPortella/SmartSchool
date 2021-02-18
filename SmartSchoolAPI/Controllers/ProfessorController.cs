using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchoolAPI.Models;

namespace SmartSchoolAPI.Controllers
{
    [Route("/professor")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        
        public ProfessorController()
        {
            
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok("Professor GET");
        }
    }
}