using Xunit;
using TrilhaApiDesafio.Models;  // Ajuste o namespace conforme necessário

public class ValidacoesStringTests
{
    private readonly ValidacoesString _validacoesString;

    public ValidacoesStringTests()
    {
        _validacoesString = new ValidacoesString();
    }

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        var texto = "Matrix";
        var resultado = _validacoesString.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        var texto = "Esse é um texto qualquer";
        var resultado = _validacoesString.ContemCaractere(texto, "qualquer");

        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        var texto = "Esse é um texto qualquer";
        var resultado = _validacoesString.ContemCaractere(texto, "teste");

        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        var texto = "Começo, meio e fim do texto procurado";
        var resultado = _validacoesString.TextoTerminaCom(texto, "procurado");

        Assert.True(resultado);
    }
}
