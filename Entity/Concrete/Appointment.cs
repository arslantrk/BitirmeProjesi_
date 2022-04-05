using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Appointment : IEntity //doktor randevusu
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        //public string AppointmentTime { get; set; } //randevu saati
        //public string AppointmentDescription { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }

        /*public List<Clinic> Clinic { get; set; }
        public int ClinicId { get; set; }*/
    }
}
