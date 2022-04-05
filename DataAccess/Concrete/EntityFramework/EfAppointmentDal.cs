using Core.DataAccess;
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
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment,ENabizContext> , IAppointmentDal
    {
    //    public List<AppointmentDetailDto> GetAppointmentDetails()
    //    {
    //        //using (ENabizContext context = new ENabizContext())
    //        //{
    //        //    var result = from p in context.Appointments
    //        //                 join c in context.Clinics
    //        //                 on p. equals c.
    //        //                 select new ProductDetailDto
    //        //                 {
    //        //                     ProductId = p.ProductId,
    //        //                     ProductName = p.ProductName,
    //        //                     CategoryName = c.CategoryName,
    //        //                     UnitsInStock = p.UnitsInStock
    //        //                 };
    //        //    return result.ToList();
    //        //}
    //    }
    }
}
