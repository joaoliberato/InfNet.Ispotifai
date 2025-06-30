using InfNet.Ispotifai.WebApp.Dto.Request;
using InfNet.Ispotifai.WebApp.Models;
using InfNet.Ispotifai.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IspotifaiApiClient _apiClient;

        public AccountController(IspotifaiApiClient apiClient)
        {
            _apiClient = apiClient;
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
            HttpResponseMessage? result = _apiClient.Login(new LoginRequest
            {
                Email = model.Email,
                Password = model.Password
            });

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
            HttpResponseMessage? result = _apiClient.Register(new RegisterRequest
            {
                Email = model.Email,
                Password = model.Password,
                ConfirmPassword = model.ConfirmPassword,
                Plano = model.Plano
            });

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
