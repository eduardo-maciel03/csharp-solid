﻿namespace CsharpSOLID._3_LCP.Problema;

public class Quadrado : Retangulo
{
    public override double Altura
    {
        set { base.Altura = base.Largura = value; }
    }

    public override double Largura
    {
        set { base.Altura = base.Largura = value; }
    }
}
