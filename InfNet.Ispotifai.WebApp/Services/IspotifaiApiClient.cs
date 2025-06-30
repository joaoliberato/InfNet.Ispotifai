using InfNet.Ispotifai.WebApp.Dto.Request;
using InfNet.Ispotifai.WebApp.Dto.Response;
using System.Net.Http;
using System.Reflection;

namespace InfNet.Ispotifai.WebApp.Services
{
    public class IspotifaiApiClient
    {
        private readonly HttpClient _httpClient;
        public IspotifaiApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        internal HttpResponseMessage? AddFavorita(int idUsuario, int idMusica)
        {
            return _httpClient.PostAsync($"Usuario/{idUsuario}/Favorita/{idMusica}", null).Result;
        }

        internal UsuarioResponse GetUsuarioById(int id)
        {
            return _httpClient.GetFromJsonAsync<UsuarioResponse>($"Usuario/{id}").Result;

        }

        internal HttpResponseMessage? Login(LoginRequest loginRequest)
        {
            return _httpClient.PostAsJsonAsync("Account/Login", loginRequest).Result;
        }

        internal HttpResponseMessage? Register(RegisterRequest registerRequest)
        {
            return _httpClient.PostAsJsonAsync("Account/Register", registerRequest).Result;
        }

        internal HttpResponseMessage? RemoveFavorita(int idUsuario, int idMusica)
        {
            return _httpClient.DeleteAsync($"Usuario/{idUsuario}/Favorita/{idMusica}").Result;
        }
    }
}
