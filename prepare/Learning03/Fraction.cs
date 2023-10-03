using System;

public class Fraction
{
    private int _top;

    private int _botton;


    public Fraction()
    { }

    public Fraction(int numerador)
    {
        _top = numerador;
        _botton = 1;
    }

    public Fraction(int numerador, int denominador)
    {
        _top = numerador;
        _botton = denominador;
    }

    //Esto sería lo ideal
    public string GetFractionString()
    {
        return ($"{_top}/{_botton}");
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_botton;
    }

    // //No cumple con los requisitos de la encapsulación
    // //Ya que no queremos que se muestren los atributos
    // string GetFractionString(string numerador, string denominador)
    // {
    //     return ($"{numerador}/{denominador}");
    // }
    // double GetDecimalValue(int numerador, int denominador)
    // {
    //     return numerador / denominador;
    // }


    // //This example is from the Sample Solution
    // string SinParametrosGetFractionString()
    // {
    //     string resultado = ($"{_top}/{_botton}");
    //     return resultado;
    // }

    // //This example is from the Sample Solution
    // double GetDecimalValue()
    // {
    //     return (double)_top / (double)_botton;
    // }


}