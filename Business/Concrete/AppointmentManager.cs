using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private readonly IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        [CacheAspect]
        public IDataResult<Appointment> GetById(int id)
        {
            var hasan = _appointmentDal.Queryable().Where(p => p.AppointmentId == id).Include(p => p.Doctor).SingleOrDefault();
            return new SuccessDataResult<Appointment>(_appointmentDal.Queryable().Where(p=>p.AppointmentId==id).Include(p=>p.Doctor).SingleOrDefault());
        }

        [SecuredOperation("appointment.getlist,admin")]

        [CacheAspect]

        public IDataResult<List<Appointment>> GetList()
        {
            //return new SuccessDataResult<List<Appointment>>(_appointmentDal.Queryable().Where(x => x.AppointmentId))
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetList(),Messages.AppointmentsListed);
        }
    }
}
