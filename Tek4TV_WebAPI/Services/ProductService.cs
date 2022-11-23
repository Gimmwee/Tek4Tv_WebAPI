using Tek4TV_WebAPI.IServices;
using Tek4TV_WebAPI.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Tek4TV_WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly PROJECTPRJ301Context _context;
        public ProductService(PROJECTPRJ301Context context)
        {
            _context = context;
        }

        public dynamic CreateProduct(Product product)
        {
            Product pro = new Product()
            {
                Title = product.Title,
                Name = product.Name,
                Detail = product.Detail,
                Price = product.Price,
                Image = product.Image,
                IdCategories = product.IdCategories,
            };

            _context.Products.Add(pro);
            _context.SaveChanges();
            return pro;
        }

        public object DeleteProduct(Product product)
        {
            var checkId = _context.Products.Where(c => c.IdProduct == product.IdProduct).FirstOrDefault();
            if (checkId == null)
            {
                return false;
            }
            _context.Remove(checkId);
            _context.SaveChanges();
            return checkId;
        }

        public IQueryable<dynamic> getAllProduct()
        {
            return _context.Products;
        }

        public dynamic pagingCate(int page)
        {
            var pageRes = 2f;
            var products = _context.Products.Skip((page - 1) * (int)pageRes).Take((int)pageRes).ToList();

            var pageCount = Math.Ceiling(_context.Products.Count() / pageRes);

            var output = products.Select(c => new
            {
                c.IdProduct,
                c.Name,
                c.Title,
                c.Price,
                pageCount,
            });
            return output;
        }

        public dynamic SearchByName(Product product, int page)
        {

            var checkId = _context.Products.Where(c => c.Name.Contains(product.Name.Trim()));
            var pageRes = 2f;
            var products = checkId.Skip((page - 1) * (int)pageRes).Take((int)pageRes).ToList();
            var pageCount = Math.Ceiling(checkId.Count() / pageRes);
            var output = products.Select(c => new
            {
                c.IdProduct,
                c.Title,
                c.Name,
                c.Detail,
                c.Price,
                c.Image,
                pageCount,
            });
            return output;
            //return keyword.ToList().AsQueryable();
        }

        public dynamic UpdateProduct(Product product)
        {
            var checkId = _context.Products
                .FirstOrDefault(c => c.IdProduct == product.IdProduct);
            if (checkId == null || product.Name.Trim().Equals(""))
            {
                return false;
            }
            else
            {
                checkId.IdProduct = product.IdProduct;
                checkId.Name = product.Name.Trim();
                checkId.Title = product.Title;
                checkId.Price = product.Price;
                checkId.Detail = product.Detail;
                checkId.Image = product.Image;


                _context.Products.Update(checkId);
                _context.SaveChanges();
                return checkId;
            }
        }
    }
}
