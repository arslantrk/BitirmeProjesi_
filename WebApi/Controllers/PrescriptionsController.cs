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
    public class PrescriptionsController : ControllerBase
    {
        IPrescriptionService _prescriptionService;
        public PrescriptionsController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }
        //[HttpGet("getlist")]
        //public IActionResult GetList()
        //{
        //    var result = _prescriptionService.GetList();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
        [HttpGet]
        public IActionResult GetListWithDoctor()
        {
            var result = _prescriptionService.GetListWithDoctor();
            try
            {
                return Ok(result);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
