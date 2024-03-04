using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, DataListerContext>, ICustomerDal
    {
        public List<CustomerOrderDetailDto> CustomerOrderDetail()
        {
            using (DataListerContext context = new DataListerContext())
            {
                var result = from c in context.Customers
                             join o in context.Orders
                             on c.CustomerId equals o.OrderId
                             select new CustomerOrderDetailDto
                             {
                                 CustomerName = c.CustomerName,
                                 CompanyName = c.CompanyName,
                                 Description = o.Description,
                                 Address = o.Address
                             };

                return result.ToList();
            }

        }

    }
}

