using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPrescriptionDal : EfEntityRepositoryBase<Prescription, ENabizContext>, IPrescriptionDal
    {
        public List<PrescriptionDetailDto> GetListWithDoctor()
        {
            using (ENabizContext context = new ENabizContext())
            {
                var result = from p in context.Prescriptions
                             join c in context.Doctors
                             on p.DoctorId equals c.DoctorId
                             select new PrescriptionDetailDto
                             {
                                 PrescriptionId = p.PrescriptionId,
                                 DoctorName = c.DoctorName,
                                 Date = p.PrescriptionDate,
                                 ReceteTuru = "Normal"
                             };
                return result.ToList();
            }
        }
    }
}
