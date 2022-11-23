
using Tek4TV_WebAPI.IServices;
using Tek4TV_WebAPI.Models;

namespace Tek4TV_WebAPI.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly PROJECTPRJ301Context _context;

        public CustomerService(PROJECTPRJ301Context context)
        {
            _context = context;
        }

        public object CreateCustomer(Customer customer)
        {
            Customer cus = new Customer()
            {
                UserName = customer.UserName,
                PassWord = customer.PassWord,
                NameCustomer = customer.NameCustomer,
                IsAdmin = customer.IsAdmin,
                Phone = customer.Phone,
            };

            _context.Customers.Add(cus);
            _context.SaveChanges();
            return cus;
        }

        public object DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public object getAllCustomer()
        {
            return _context.Customers;
        }

        public object SearchByName(Customer customer, int page)
        {
            throw new NotImplementedException();
        }

        public object UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        IQueryable<dynamic> ICustomerService.getAllCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
