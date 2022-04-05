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
    public class DoctorManager : IDoctorService
    {
        private readonly IDoctorDal _doctorDal;
        public DoctorManager(IDoctorDal doctorDal)
        {
            _doctorDal= doctorDal;
        }

        [CacheAspect]
        public IDataResult<Doctor> GetById(int id)
        {
            return new SuccessDataResult<Doctor>(_doctorDal.Get(p => p.DoctorId == id));
        }

        [CacheAspect]
        public IDataResult<List<Doctor>> GetList()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetList());
        }
    }
}
