using System.Collections.Generic;
using Xunit;
using TrilhaApiDesafio.Models;  // Ajuste o namespace conforme necessário

public class ValidacoesListaTests
{
    private readonly ValidacoesLista _validacoesLista;

    public ValidacoesListaTests()
    {
        _validacoesLista = new ValidacoesLista();
    }

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        var lista = new List<int> { 1, -2, 3, -4, 5 };
        var resultado = _validacoesLista.RemoverNumerosNegativos(lista);
        var esperado = new List<int> { 1, 3, 5 };

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        var lista = new List<int> { 1, 2, 3, 9, 5 };
        var resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 9);

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        var lista = new List<int> { 1, 2, 3, 9, 5 };
        var resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 10);

        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        var lista = new List<int> { 1, 2, 3 };
        var resultado = _validacoesLista.MultiplicarNumerosLista(lista, 2);
        var esperado = new List<int> { 2, 4, 6 };

        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        var lista = new List<int> { 1, 3, 7, 9 };
        var resultado = _validacoesLista.RetornarMaiorNumeroLista(lista);

        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        var lista = new List<int> { 1, -8, 3, 9 };
        var resultado = _validacoesLista.RetornarMenorNumeroLista(lista);

        Assert.Equal(-8, resultado);
    }
}
