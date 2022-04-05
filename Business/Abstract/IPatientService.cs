﻿using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPatientService 
    {
        IDataResult<Patient> GetById(int id);
        IDataResult<List<Patient>> GetList();
    }
}
