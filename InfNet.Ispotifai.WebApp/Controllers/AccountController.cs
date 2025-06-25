using InfNet.Ispotifai.WebApp.Dto.Request;
using InfNet.Ispotifai.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            var client = _httpClientFactory.CreateClient();
            var result = client.PostAsJsonAsync("http://localhost:5206/api/Account/Login", new LoginRequest
            {
                Email = model.Email,
                Password = model.Password
            }).Result;

            if (!result.IsSuccessStatusCode)
            {
                model.Erros.Add("Login ou senha incorretos");
                return View(model);
            }

            int idUsuario = int.Parse(result.Content.ReadAsStringAsync().Result);

            return RedirectToAction("Index", "Home", new { id = idUsuario });
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            var client = _httpClientFactory.CreateClient();

            var result = client.PostAsJsonAsync("http://localhost:5206/api/Account/Register", new RegisterRequest
            {
                Email = model.Email,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword,
                Plano = model.Plano
            }).Result;

            if (!result.IsSuccessStatusCode)
            {
                model.Erros.Add("Erro ao registrar usuário. Verifique os dados e tente novamente.");
                return View(model);
            }

            int idUsuario = int.Parse(result.Content.ReadAsStringAsync().Result);

            return RedirectToAction("Index", "Home", new { id = idUsuario, usuarioNovo = true });
        }
    }
}
