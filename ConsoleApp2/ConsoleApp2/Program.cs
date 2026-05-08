using System;

class Fraccion
{
    public int Numerador;
    public int Denominador;

    public Fraccion(int num, int den)
    {
        if (den == 0)
        {
            throw new ArgumentException("El denominador no puede ser 0");
        }

        Numerador = num;
        Denominador = den;
    }

    public void Mostrar()
    {
        Console.WriteLine($"{Numerador}/{Denominador}");
    }
}

class Program
{
    static void Main()
    {
        Fraccion f = new Fraccion(3, 4);

        f.Mostrar();
    }
}