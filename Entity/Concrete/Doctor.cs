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
    public class Doctor : IEntity
    {
        [Key]
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }
        public DateTime DoctorBirthDate { get; set; }
        public string DoctorTc { get; set; }
        public string DoctorArea { get; set; }//BeyinCerrahi--Dahiliye--KalpVeDamar
        public string DoctorGender { get; set; }
        #nullable enable
        public string? DoctorPassword { get; set; }
        #nullable disable
        public List<Appointment> Appointments { get; set; }
        public Clinic Clinic { get; set; }
        [ForeignKey("ClinicId")]
        public int ClinicId { get; set; }
        public Laboratory Laboratory { get; set; }
        [ForeignKey("LaboratoryId")]
        public int LaboratoryId { get; set; }
        public List<Prescription> Prescriptions { get; set; }
        //public int PrescriptionId { get; set; }

    }
}
