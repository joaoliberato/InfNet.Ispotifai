using System.Diagnostics;
using InfNet.Ispotifai.WebApp.Dto.Response;
using InfNet.Ispotifai.WebApp.Models;
using InfNet.Ispotifai.WebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace InfNet.Ispotifai.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IspotifaiApiClient _apiClient;

        public HomeController(IspotifaiApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        private HomeIndexModel GetHomeIndexModel(int id)
        {
            UsuarioResponse response = _apiClient.GetUsuarioById(id);
            var result = new HomeIndexModel();

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

        [HttpPost]
        public IActionResult AddFavorita(int idUsuario, int idMusica)
        {
            HttpResponseMessage? response = _apiClient.AddFavorita(idUsuario, idMusica);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", new { id = idUsuario });
            }
            return View("Error", new ErrorViewModel { RequestId = "Erro ao adicionar música favorita." });
        }

        [HttpPost]
        public IActionResult RemoveFavorita(int idUsuario, int idMusica)
        {
            HttpResponseMessage? response = _apiClient.RemoveFavorita(idUsuario, idMusica);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", new { id = idUsuario });
            }
            return View("Error", new ErrorViewModel { RequestId = "Erro ao remover música favorita." });
        }
    }
}
