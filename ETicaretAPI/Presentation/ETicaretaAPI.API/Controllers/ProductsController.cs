using ETicaretAPI.Application.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretaAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService; //abstract sınıfa karşılık bana concrete nesnesi gelecek
        }

        [HttpGet] // swagger için gerekli
        public IActionResult GetProducts() // Applicationdaki aynı isimli metoda ulaşır ve cevap olarak presentationdaki aynı isimli metodu döndürür.
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }
}
