using MvcCore_Model_View_Controller.Models;
using MvcCore_Model_View_Controller.Services.Abstraction;

namespace MvcCore_Model_View_Controller.Services.Concrate
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
            {
                new Product{Id = 1, Name = "Ürün 1", Detail="Detay 1", ImageUrl="~/images/products/urun1.jpg"},
                new Product{Id = 2, Name = "Ürün 2", Detail="Detay 2", ImageUrl="~/images/products/urun2.jpg"},
            };
        }
        //TODOsoykuTest tamam bu iş

        public List<Product> Products { get { return _products; } }
    }
}
