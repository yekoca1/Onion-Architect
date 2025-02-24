using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController: ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Name = "product1", Price = 100, CreatedTime = DateTime.UtcNow, Stock = 10 },
                new() {Id = Guid.NewGuid(), Name = "product2", Price = 200, CreatedTime = DateTime.UtcNow, Stock = 20 },
                new() {Id = Guid.NewGuid(), Name = "product3", Price = 300, CreatedTime = DateTime.UtcNow, Stock = 30 },
            });
            var count = await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
