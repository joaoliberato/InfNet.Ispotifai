namespace InfNet.Ispotifai.Domain
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Plano Plano { get; set; }
        public List<Musica> Favoritas { get; set; }

    }
}
