using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Patient : IEntity //Hasta
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientGender { get; set; }
        public DateTime PatientBirthDate { get; set; }
        #nullable enable
        public string? BirthPlace { get; set; }
        public string? PatientProvince { get; set; }//hasta ili istanbul
        public string? PatientDistrict { get; set; }//hasta ilçe sultanbeyli
        public string? PatientNumber { get; set; }
        public string? PatientSGK { get; set; }
        public string? PatientMail { get; set; }
        #nullable disable
        public string PatientPassword { get; set; }
        public string PatientAddress { get; set; }
        //public Clinic Clinic { get; set; }
        //public int ClinicId { get; set; }
        public List<ClinicPatient> ClinicPatients { get; set; }
        public List<Appointment> Appointments { get; set; }
        //public int AppointmentId { get; set; }
        public List<Laboratory> Laboratories { get; set; }
        //public int LaboratoryId { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        //public int PrescriptionId { get; set; }
    }
}
