﻿namespace CsharpSOLID._4_ISP.Problema;

public class CadastroUsuario : ICadastro
{
    public void ValidarDados()
    {
        // Validar CPF, Email
    }

    public void Salvar()
    {
        // Insert na tabela Usuario
    }

    public void EnviarEmail()
    {
        // Enviar e-mail para o usuario
    }
}
