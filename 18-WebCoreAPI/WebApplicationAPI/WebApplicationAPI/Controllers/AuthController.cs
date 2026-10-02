using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.Models;
using WebApplicationAPI.Services;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JWTService _jwtService;

        public AuthController(JWTService jwtService)
        {
            _jwtService = jwtService;
        }
        [HttpPost]
        public IActionResult Login(LoginRequestVM vm)
        {
            // Burada kullanıcı doğrulama işlemi yapılır. Örnek olarak, kullanıcı adı ve şifreyi kontrol edebilirsiniz.
            // Bu örnekte, kullanıcı adı "veysel" ve şifre "1234" olarak kabul ediliyor.
            if (vm.UserName == "veysel" && vm.Password == "1234")
            {
                // Kullanıcı doğrulandı, JWT token oluşturuluyor.
                var token = _jwtService.GenerateToken("1", vm.UserName); // Örnek olarak kullanıcı ID'si 1 olarak alındı.
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized("Kullanıcı adı veya şifre hatalı.");
            }

        }
    }
}
