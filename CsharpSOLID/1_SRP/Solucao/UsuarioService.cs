namespace CsharpSOLID._1_SRP.Solucao;

public class UsuarioService
{
    public string AdicionarUsuario(Usuario usuario)
    {
        if (!usuario.IsValid())
            return "Dados inválidos";

        var repo = new UsuarioRepository();
        repo.AdicionarUsuario(usuario);

        EmailService.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

        return "Usuário cadastrado com sucesso";
    }
}
