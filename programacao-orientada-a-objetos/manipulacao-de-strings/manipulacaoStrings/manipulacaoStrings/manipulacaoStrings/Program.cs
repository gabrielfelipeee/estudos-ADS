using System;

class Program
{
    static void Main(string[] args)
    {
        // string no estado não inicializada
        string naoIcicializada;

        // string nula
        string nula = null;
        
        // string com valor
        string comValor = "Gabriel";

        // vazia com empty
        string vaziaComEmpty = System.String.Empty;

        // vazia com ""
        string vaziaComAspas = "";

        /* em variáveis locais (dentro do corpo de um método)
         * com o var, o compilador infere o tipo de dado (string, int..)*/
        var texto = "Hello, World!";


        /* usando o constructor string - usar quando:
         * a string for um char*, char[], ou sbyte*
        */
        char[] letras = { 'A', 'B', 'C' };
        string alfabeto = new string(letras);




        // Usando o método String.Format
        decimal temp = 22.0m;
        string frase = String.Format("A temperatura é {0} ºC.", temp);
        Console.WriteLine(frase); // A temperatura é 22,4 ºC.

        // Ppressione uma tecla para sair
        Console.ReadKey();
    }
}
