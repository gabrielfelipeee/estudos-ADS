using System;

// Parâmetros


// value ->  Quando um parâmetro não tem um modificador, ele é tratado como value por default.
public double calcularArea( double x, double y) {
    return (x * y)/2;
}





// out -> O modificador out passa um parâmetro por referência. Isso significa que caso o parâmetro seja alterado dentro da função, a variável que representa o parâmetro no código que chamou a função também será alterada. 
static void Main()
{
    void exempleOut( out double valor) {
        valor = 100;
    }

    double valorOriginal = 9;
    exempleOut(out valorOriginal);
    Console.WriteLine(valorOriginal); // output: 100 
}





// ref -> é de entrada e saída. Isso significa que eles podem ser usados tanto para passar um valor para uma função quanto para receber de volta esse valor
static void testeRef(ref int valor) {
    valor = valor + 100;
}
static void Main()
{
    int valorOriginal = 10;
    testeRef(ref valorOriginal);
    Console.WriteLine(valorOriginal); // output: 110
}





// params -> permite que você passe um número variável de argumentos para um método
public class ExemploParams
{
    public static void ImprimirValores(params int[] valores)
    {
        foreach (int valor in valores)
        {
            Console.WriteLine(valor);
        }
    }

    public static void Main()
    {
        Console.WriteLine("Valores:");
        ImprimirValores(1, 2, 3, 4, 5); // Chamando o método com vários argumentos int
    }
}
