public class ValidacoesString
{
    public int RetornarQuantidadeCaracteres(string texto)
    {
        return texto.Length;
    }

    public bool ContemCaractere(string texto, string caractere)
    {
        return texto.Contains(caractere);
    }

    public bool TextoTerminaCom(string texto, string trecho)
    {
        return texto.EndsWith(trecho);
    }
}
