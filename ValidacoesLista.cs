public class ValidacoesLista
{
    public List<int> RemoverNumerosNegativos(List<int> lista)
    {
        return lista.Where(n => n >= 0).ToList();
    }

    public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
    {
        return lista.Contains(numero);
    }

    public List<int> MultiplicarNumerosLista(List<int> lista, int multiplicador)
    {
        return lista.Select(n => n * multiplicador).ToList();
    }

    public int RetornarMaiorNumeroLista(List<int> lista)
    {
        return lista.Max();
    }

    public int RetornarMenorNumeroLista(List<int> lista)
    {
        return lista.Min();
    }
}
