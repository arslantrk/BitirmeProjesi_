using AutoMapper;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        //private readonly IMapper _mapper;
        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
           // _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            var result = _appointmentService.GetList();
            if (result.Success)
            {
                var result1 = JsonConvert.SerializeObject(result.Data);
                var result2 = result;
                return Ok(result);
            }
            return BadRequest(result);
            //return Ok(_mapper.Map<List<AppoinmetListDto>>(_appointmentService.GetList()));
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _appointmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
