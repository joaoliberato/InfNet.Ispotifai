
namespace InfNet.Ispotifai.Domain
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Plano Plano { get; set; }
        public virtual List<Musica> Favoritas { get; set; } = [];

        public void RemoveFavorita(int idMusica)
        {
            Favoritas.RemoveAll(m => m.IdMusica == idMusica);
        }
        public void AddFavorita(Musica musica)
        {
            Favoritas ??= [];
            Favoritas.Add(musica);
        }
    }
}
