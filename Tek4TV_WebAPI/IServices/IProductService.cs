using Tek4TV_WebAPI.Models;

namespace Tek4TV_WebAPI.IServices
{
    public interface IProductService
    {
        public dynamic pagingCate(int page);
        public IQueryable<dynamic> getAllProduct();
        public dynamic CreateProduct(Product product);
        public dynamic UpdateProduct(Product product);
        public dynamic SearchByName(Product product, int page);
        public dynamic DeleteProduct(Product product);
    }
}
