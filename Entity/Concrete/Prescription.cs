using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete
{
    public class Prescription : IEntity //Reçete
    {
        [Key]
        public int PrescriptionId { get; set; }
        public string DoctorComment { get; set; }
        public DateTime PrescriptionDate { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }

    }
}
