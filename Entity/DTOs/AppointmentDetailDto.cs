using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class AppointmentDetailDto:IDto
    {
        public int AppointmentDetailId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentProvince { get; set; }
        public string ClinicName { get; set; }
        public string DoctorName { get; set; }

    }
}
