using System;

class Program
{
    static void Main(string[] args)
    {
        // método String.Format
        decimal temp = 22.0m;
        string texto = String.Format("A temperatura é {0} ºC.", temp);
        // Saída de texto: A temperatura é 22,4 ºC.


        // indexOf 
        String frase = "Esta e uma string maior ainda para teste";
        int tamanho = frase.Length -1;
        int indiceInicial = 0;
        string valor = "maior";
        int posicao = frase.IndexOf(valor, indiceInicial, tamanho);
        // Saída: 18, pois a subpalavra maior é encontrada na posição 18 da string


        // String.Concat
        string nome = "Gabriel";
        string sobrenome = " Silva";
        string nomeCompleto = String.Concat(nome,sobrenome);
        // Gabreil Silva


        // String.Join -> concatena os elementos de uma matriz usando um separador específico
        String[] frutas = { "uva", "laranja", "pera", "abacaxi" };
        String separador = ", ";
        string frutasSeparadas = String.Join(separador, frutas);
        // uva, laranja, pera, abacaxi
    }
}