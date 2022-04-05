using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratorysController : ControllerBase
    {
        ILaboratoryService _laboratoryService;
        public LaboratorysController(ILaboratoryService laboratoryService)
        {
            _laboratoryService = laboratoryService;
        }
        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _laboratoryService.GetList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
