using System.Diagnostics;
using InfNet.Ispotifai.WebApp.Dto.Response;
using InfNet.Ispotifai.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;


        public HomeController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        private HomeIndexModel GetHomeIndexModel(int id)
        {
            var result = new HomeIndexModel();
            UsuarioResponse response = _httpClientFactory.CreateClient()
                .GetFromJsonAsync<UsuarioResponse>($"http://localhost:5206/api/Usuario/{id}").Result;

            if (response is null)
            {
                result.IsAuthenticated = false;
                return result;
            }

            result.IdUsuario = response.IdUsuario;
            result.Email = response.Email;
            result.Favoritas = response.Favoritas ?? new List<MusicaFavoritaReponse>();
            result.IsAuthenticated = true;
            return result;
        }

        public IActionResult Index(int? id = null, bool usuarioNovo = false)
        {
            if (id is null)
            {
                return View(new HomeIndexModel() { IsAuthenticated = false });
            }

            var model = GetHomeIndexModel(id.Value);
            model.UsuarioNovo = usuarioNovo;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
