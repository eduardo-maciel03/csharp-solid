using CsharpSOLID._5_DIP.Solucao.Interfaces;

namespace CsharpSOLID._5_DIP.Solucao;

public class Usuario
{
    private readonly ICPFService _cpfServices;
    private readonly IEmailService _emailServices;

    public Usuario(
        ICPFService cpfServices,
        IEmailService emailServices)
    {
        _cpfServices = cpfServices;
        _emailServices = emailServices;
    }

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }

    public bool IsValid()
    {
        return _emailServices.IsValid(Email) && _cpfServices.IsValid(CPF);
    }
}
