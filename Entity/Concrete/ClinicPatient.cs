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
    public class ClinicPatient : IEntity
    {
        [Key]
        public int ClinicPatientId { get; set; }
        [ForeignKey("ClinicId")]
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
