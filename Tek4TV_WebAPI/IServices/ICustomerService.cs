using Tek4TV_WebAPI.Models;

namespace Tek4TV_WebAPI.IServices
{
    public interface ICustomerService
    {
        public dynamic CreateCustomer(Customer customer);
        public dynamic DeleteCustomer(Customer customer);
        public IQueryable<dynamic> getAllCustomer();
        public dynamic SearchByName(Customer customer, int page);
        public dynamic UpdateCustomer(Customer customer);
    }
}
