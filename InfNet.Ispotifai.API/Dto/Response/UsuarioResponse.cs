namespace InfNet.Ispotifai.API.Dto.Response
{
    public class UsuarioResponse
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public List<MusicaFavoritaReponse> Favoritas { get; set; } = [];
    }

}
