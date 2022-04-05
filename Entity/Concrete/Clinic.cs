using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Clinic : IEntity
    {
        [Key]
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public List<Doctor> Doctors { get; set; }
        //public int DoctorId { get; set; }
        //public List<Patient> Patient { get; set; }
        public List<ClinicPatient> ClinicPatients { get; set; }
        //public int PatientId { get; set; }
        /*public List<Appointment> Appointment { get; set; }
        public int AppointmentId { get; set; }*/
    }
}
