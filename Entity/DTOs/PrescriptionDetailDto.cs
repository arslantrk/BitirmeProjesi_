using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class PrescriptionDetailDto
    {
        public int PrescriptionId { get; set; }
        public string DoctorName { get; set; }
        public string ReceteTuru { get; set; } = "NORMAL";
        public DateTime Date { get; set; }
        
    }
}
