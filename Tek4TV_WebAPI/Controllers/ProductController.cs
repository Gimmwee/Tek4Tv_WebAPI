using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tek4TV_WebAPI.IServices;
using Tek4TV_WebAPI.Models;

namespace Tek4TV_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [Route("paging")]
        [HttpGet]
        public dynamic pagingCate(int page)
        {
            try
            {
                var data = _productService.pagingCate(page);
                return data;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("get-all")]
        [HttpGet]
        public dynamic getAllProduct()
        {
            try
            {
                var data = _productService.getAllProduct();
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("create")]
        [HttpPost]
        public dynamic CreateProduct(Product product)
        {
            try
            {
                var data = _productService.CreateProduct(product);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("update")]
        [HttpPut]
        public dynamic UpdateProduct(Product product)
        {
            try
            {
                var data = _productService.UpdateProduct(product);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("delete")]
        [HttpDelete]
        public dynamic DeleteProduct(Product product)
        {
            try
            {
                var data = _productService.DeleteProduct(product);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        [Route("search-by-name")]
        [HttpPost]
        public dynamic SearchByName(Product product, int page)
        {
            try
            {
                var data = _productService.SearchByName(product, page);
                return Ok(data);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
