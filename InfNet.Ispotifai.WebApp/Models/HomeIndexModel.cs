using InfNet.Ispotifai.WebApp.Dto.Response;

namespace InfNet.Ispotifai.WebApp.Models
{
    public class HomeIndexModel
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public List<MusicaFavoritaReponse> Favoritas { get; set; } = [];
        public bool UsuarioNovo { get; internal set; }
        public bool IsAuthenticated { get; set; }
    }
}
