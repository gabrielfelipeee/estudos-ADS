using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;




// Classe 
public class myClass
{
    // Atributos/ variáveis
    public string name = "Gabriel";
    int age = 19;
    float height = 1.75f;


    // Referência da outra classe(exempleClass), isso é necessário para acessar as variáveis e/ou métodos dentro dessa classe (myClass);
    exempleClass exemple;


    // Coleções
    int[] myArray = new int[] {1, 2, 3, 4, 5}; // Array
    List<int> myList = new List<int>() {1, 2, 3, 4, 5}; // List



    // Método 
    void myMethod() 
    {
        // Loops
        foreach( int numbers in myArray)
        {

        }


        for( int i = 0; i < myArray.Length; i++) // Quantidade de itens no array usamos Length
        {
            int currentNumber = myArray[i];
        }


        for( int i = 0; i < myList.Count; i++) // Quantidade de itens no array usamos Count
        {

        }



        // Condições
        if(0 > 1) 
        { 

        } else {

        }


        // Acessando atributos e métodos de outras classes
        void accessExternalClassMethod()
        {
            exemple.method();
            exemple.number = 100;
        }
    }

}


// Outras classe
public class exempleClass
{

    public int number;

    public void method()
    {

    }
}
