using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PrescriptionManager : IPrescriptionService
    {
        public readonly IPrescriptionDal _prescriptionDal;
        public PrescriptionManager(IPrescriptionDal prescriptionDal)
        {
            _prescriptionDal = prescriptionDal;
        }
        [CacheAspect]
        public IDataResult<Prescription> GetById(int id)
        {
            return new SuccessDataResult<Prescription>(_prescriptionDal.Get(p=>p.PatientId == id));
        }
        [CacheAspect]
        public IDataResult<List<Prescription>> GetList()
        {
            return new SuccessDataResult<List<Prescription>>(_prescriptionDal.GetList());
        }

        public List<PrescriptionDetailDto> GetListWithDoctor()
        {
            return new List<PrescriptionDetailDto>(_prescriptionDal.GetListWithDoctor());
        }
    }
}
