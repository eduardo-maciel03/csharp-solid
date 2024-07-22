using CsharpSOLID._5_DIP.Solucao.Interfaces;

namespace CsharpSOLID._5_DIP.Solucao;

public class UsuarioServices : IUsuarioServices
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IEmailService _emailServices;

    public UsuarioServices(
        IEmailService emailServices,
        IUsuarioRepository usuarioRepository)
    {
        _emailServices = emailServices;
        _usuarioRepository = usuarioRepository;
    }

    public string AdicionarUsuario(Usuario usuario)
    {
        if (!usuario.IsValid())
            return "Dados inválidos";

        _usuarioRepository.AdicionarUsuario(usuario);

        _emailServices.Enviar("csharp@solid.com", usuario.Email, "Bem Vindo", "Parabéns está Cadastrado");

        return "Usuário cadastrado com sucesso";
    }
}
