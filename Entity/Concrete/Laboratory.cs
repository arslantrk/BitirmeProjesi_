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
    public class Laboratory : IEntity
    {
        [Key]
        public int LabId { get; set; }
        public string LabResult { get; set; }
        public List<Doctor> Doctors { get; set; }
        //public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        public DateTime ResultDate { get; set; }//tahlillerin sonuçtarihi
        
    }
}
