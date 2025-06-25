namespace InfNet.Ispotifai.API.Dto.Response
{
    public class MusicaFavoritaReponse
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public int IdMusica { get; set; }
        public bool Favorita { get; set; }
    }
}
