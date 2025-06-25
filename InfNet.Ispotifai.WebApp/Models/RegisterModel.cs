namespace InfNet.Ispotifai.WebApp.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Plano { get; set; }

        public List<string> Erros { get; set; } = [];
        public string Sucesso { get; set; }
    }
}
