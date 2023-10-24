using System;

namespace exemploHeranca
{
    // Classe pai
    public class MeioDeTransporte
    {
        public string nome;
        public string combustivel;
        public float capacidadeEmKg;
        public int numPassageiros;

        // virtual => método pode ser herdado
        public virtual void escrevaNoConsole()
        {
            Console.WriteLine("O " + nome + " usa " + combustivel);
        }
    }


    // Subclasse 
    public class Aviao : MeioDeTransporte
    {
        public int numTripulantes;
        public int numTurbinas;

        // override => método está herdando e sobrescrevendo
        public override void escrevaNoConsole() // polimorfismo
        {
            Console.WriteLine("O " + nome + " usa " + combustivel + " e têm " + numTurbinas.ToString() + " turbinas ");

        }
    }


    class Program
    {
        public static void Main()
        {
            // Instanciando a classe Aviao
            Aviao objAviao = new Aviao();

            // Atribuindo valores aos atributos
            objAviao.nome = "Avião";
            objAviao.combustivel = "gasolina";
            objAviao.capacidadeEmKg = 500;
            objAviao.numPassageiros = 110;
            objAviao.numTripulantes = 5;
            objAviao.numTurbinas = 4;
            objAviao.escrevaNoConsole();
        }
    }
}
