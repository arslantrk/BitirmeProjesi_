using Business.Abstract;
using Business.Constants;
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
    public class ClinicManager : IClinicService
    {
        private readonly IClinicDal _clinicDal;
        public ClinicManager(IClinicDal clinicDal)
        {
            _clinicDal = clinicDal;
        }

        [CacheAspect]
        public IDataResult<Clinic> GetById(int id)
        {
            return new SuccessDataResult<Clinic>(_clinicDal.Get(p => p.ClinicId == id));
        }

        [CacheAspect]
        public IDataResult<List<Clinic>> GetList()
        {
            return new SuccessDataResult<List<Clinic>>(_clinicDal.GetList(),Messages.ClinicsListed);
        }
    }
}
