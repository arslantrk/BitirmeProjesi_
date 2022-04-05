using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILaboratoryService
    {
        IDataResult<Laboratory> GetById(int id);
        IDataResult<List<Laboratory>> GetList();
    }
}
