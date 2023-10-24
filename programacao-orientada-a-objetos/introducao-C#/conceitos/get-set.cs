public class Pessoa
{
    private string nome; // Campo privado

    // Propriedade pública com get e set
    public string Nome
    {
        get
        {
            return nome; // Retorna o valor do campo
        }
        set
        {
            nome = value; // Define o valor do campo
        }
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "João"; // Usando o setter para definir o valor da propriedade
        string nomeDaPessoa = pessoa.Nome; // Usando o getter para obter o valor da propriedade
        Console.WriteLine("Nome da pessoa: " + nomeDaPessoa);
    }
}

