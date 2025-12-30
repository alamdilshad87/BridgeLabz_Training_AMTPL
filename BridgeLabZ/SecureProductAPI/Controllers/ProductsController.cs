using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureProductAPI.DTOs;
using SecureProductAPI.Models;
using SecureProductAPI.Repositories.Interfaces;

namespace SecureProductAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAll());
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };

            _repo.Add(product);
            return Ok(product);
        }
    }
}
