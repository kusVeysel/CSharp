using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Services;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        //[AllowAnonymous] // Herkes tarafından erişilebilir olur
        [Authorize] // Jwt tokin bilgisi ile giriş yapmış kullanıcılar için erişim izni verilir
        public IActionResult AllProducts()
        {
            return Ok(_productService.GetAllProducts());
        }

    }
}
