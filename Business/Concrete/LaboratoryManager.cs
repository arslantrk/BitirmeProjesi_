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
    public class LaboratoryManager : ILaboratoryService
    {
        private readonly ILaboratoryDal _laboratoryDal;
        public LaboratoryManager(ILaboratoryDal laboratoryDal)
        {
            _laboratoryDal = laboratoryDal;
        }

        [CacheAspect]
        public IDataResult<Laboratory> GetById(int id)
        {
            return new SuccessDataResult<Laboratory>(_laboratoryDal.Get(p => p.LabId == id));
        }

        [CacheAspect]
        public IDataResult<List<Laboratory>> GetList()
        {
            return new SuccessDataResult<List<Laboratory>>(_laboratoryDal.GetList());
        }
    }
}
