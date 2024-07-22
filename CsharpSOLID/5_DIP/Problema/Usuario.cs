namespace CsharpSOLID._5_DIP.Problema;

public class Usuario
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }

    public bool IsValid()
    {
        return EmailService.IsValid(Email) && CPFService.IsValid(CPF);
    }
}
