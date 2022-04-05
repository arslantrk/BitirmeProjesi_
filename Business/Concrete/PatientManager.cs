using Business.Abstract;
using Core.Aspects.Autofac.Caching;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PatientManager : IPatientService
    {
        public readonly IPatientDal _patientDal;
        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }

        [CacheAspect]
        public IDataResult<Patient> GetById(int id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(p => p.PatientId == id));
        }

        [CacheAspect]
        public IDataResult<List<Patient>> GetList()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetList());
        }
    }
}
