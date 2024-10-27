using MvcCore_Model_View_Controller.Models;

namespace MvcCore_Model_View_Controller.Services.Abstraction
{
    public interface IProductService
    {        
        List<Product> Products { get; }
    }
}
