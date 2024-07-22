using CsharpSOLID._5_DIP.Solucao.Interfaces;

namespace CsharpSOLID._5_DIP.Solucao;

public class CPFServices : ICPFService
{
    public bool IsValid(string cpf)
    {
        return cpf.Length == 11;
    }
}
