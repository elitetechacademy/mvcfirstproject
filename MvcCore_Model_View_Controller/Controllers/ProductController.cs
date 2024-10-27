using Microsoft.AspNetCore.Mvc;
using MvcCore_Model_View_Controller.Models;
using MvcCore_Model_View_Controller.Services.Abstraction;

namespace MvcCore_Model_View_Controller.Controllers
{
    [Route("Product")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("GetAll")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {            
            return View(_productService.Products);
        }

        [Route("Detail")]
        [HttpGet]
        public IActionResult Detail(int productId, string comment)
        {
            ViewBag.Comment = comment;
            var product = _productService.Products.Find(x => x.Id == productId);
            return View(product);
        }

        [Route("Create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("Create")]
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.Products.Add(product);
            return RedirectToAction("GetAllProducts");
        }
    }
}
