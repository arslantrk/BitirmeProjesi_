using Core.Utilities;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPrescriptionService
    {
        IDataResult<Prescription> GetById(int id);
        IDataResult<List<Prescription>> GetList();
        List<PrescriptionDetailDto> GetListWithDoctor();
    }
}
