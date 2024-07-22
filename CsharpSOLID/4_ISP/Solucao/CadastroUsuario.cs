using CsharpSOLID._4_ISP.Solucao.Interfaces;

namespace CsharpSOLID._4_ISP.Solucao;

public class CadastroUsuario : ICadastroUsuario
{
    public void ValidarDados()
    {
        // Validar CPF, Email
    }

    public void Salvar()
    {
        // Insert na tabela Usuário
    }

    public void EnviarEmail()
    {
        // Enviar e-mail para o usuário
    }
}
