namespace CalculadoraTestes;
using Calculadora.Models;

public class UnitTest1
{
    private Calculadora _calc = new Calculadora();
    [Theory]
    [InlineData (1,2,3)]
    [InlineData (4,5,9)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calc.somar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1,2,2)]
    [InlineData (4,5,20)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calc.multiplicar(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (2,2,1)]
    [InlineData (6,2,3)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calc.dividir(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (10,5,5)]
    [InlineData (6,2,4)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        int resultadoCalculadora = _calc.subtrair(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisãoPorZero()
    {
        Assert.Throws<DivideByZeroException>(()=>_calc.dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        _calc.somar(1,1);
        _calc.somar(5,10);
        _calc.somar(7,8);
        var lista = _calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }

    [Theory]
    [InlineData (2,2,4)]
    [InlineData (5,3,125)]
    public void TestePotencia(int num1, int num2, double resultado)
    {
        double resultadoCalculadora = _calc.Potencia(num1, num2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (30,0.5)]
    [InlineData (0,0)]
    [InlineData (90,1)]
    public void TesteSeno(double num, double resultado)
    {
        double resultadoCalculadora = _calc.Seno(num);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (60,0.5)]
    [InlineData (0,1)]
    [InlineData (90,0)]
    public void TesteCos(double num, double resultado)
    {
        double resultadoCalculadora = _calc.Cosseno(num);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (45,1)]
    [InlineData (0,0)]
    public void TesteTan(double num, double resultado)
    {
        double resultadoCalculadora = _calc.Tangente(num);
        Assert.Equal(resultado, resultadoCalculadora);
    }

}