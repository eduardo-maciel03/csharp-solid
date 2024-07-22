namespace CsharpSOLID._2_OCP.Solucao;

public class DebitoContaCorrente : DebitoConta
{
    public override string Debitar(decimal valor, string conta)
    {
        // Debita Conta Corrente
        return FormatarTransacao();
    }
}
