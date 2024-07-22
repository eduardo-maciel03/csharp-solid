namespace CsharpSOLID._5_DIP.Problema;

public static class CPFService
{
    public static bool IsValid(string cpf)
    {
        return cpf.Length == 11;
    }
}
