public delegate void MyDelegate(); // Declaração do delgate

class MainClass
{ 
    public static void MyMethod() // Declaração do método
    {
        Console.WriteLine("Hello, world!");
    }

    public static void Main(string[] args)
    {
        MyDelegate del1 = new MyDelegate(MyMethod); // Instância do delgate
        del1();
    }
}
