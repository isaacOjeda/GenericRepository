using GenericRepository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericRepository.Services
{
    public class CustomersService : BaseService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return Repository.GetAll<Customer>();
        }
    }
}