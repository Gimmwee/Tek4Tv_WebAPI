using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tek4TV_WebAPI.IServices;
using Tek4TV_WebAPI.Models;
using Tek4TV_WebAPI.Services;

namespace Tek4TV_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [Route("get-all")]
        [HttpGet]
        public dynamic getAllCustomer()
        {
            try
            {
                var data = _customerService.getAllCustomer();
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("create")]
        [HttpPost]
        public dynamic CreateCustomer(Customer customer)
        {
            try
            {
                var data = _customerService.CreateCustomer(customer);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("update")]
        [HttpPut]
        public dynamic UpdateCustomer(Customer customer)
        {
            try
            {
                var data = _customerService.UpdateCustomer(customer);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("delete")]
        [HttpDelete]
        public dynamic DeleteCustomer(Customer customer)
        {
            try
            {
                var data = _customerService.DeleteCustomer(customer);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("search-by-name")]
        [HttpPost]
        public dynamic SearchByName(Customer customer, int page)
        {
            try
            {
                var data = _customerService.SearchByName(customer, page);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
