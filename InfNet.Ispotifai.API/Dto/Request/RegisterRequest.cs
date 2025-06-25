namespace InfNet.Ispotifai.API.Dto.Request
{
    public class RegisterRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Plano { get; set; }
    }
}
