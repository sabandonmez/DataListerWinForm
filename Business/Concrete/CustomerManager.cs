using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<CustomerOrderDetailDto> CustomerOrderDetail()
        {
            var customerOrderDetail = _customerDal.CustomerOrderDetail();
            return customerOrderDetail;

        }

        public List<Customer> GetAll()
        {
            var result = _customerDal.GetAll();
            return result;
        }
    }
}
