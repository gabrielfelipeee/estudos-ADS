using System;  // Inclui o namespace System, que contém classes e tipos úteis.

namespace SeuNamespace  // Declara um namespace chamado SeuNamespace.
{
    class SuaClasse  // Declara uma classe chamada SuaClasse.
    {
        // Você pode adicionar membros e métodos dentro desta classe.
    }

    struct SuaEstrutura  // Declara uma estrutura chamada SuaEstrutura.
    {
        // Você pode adicionar campos e métodos dentro desta estrutura.
    }

    interface SuaInterface  // Declara uma interface chamada SuaInterface.
    {
        // Você pode declarar métodos que as classes devem implementar aqui.
    }

    delegate int SeuDelegado();  // Declara um delegado chamado SeuDelegado que representa um tipo de método.

    enum SeuEnum  // Declara um enum chamado SeuEnum.
    {
        // Você pode definir valores enumerados aqui.
    }

    namespace SeuNamespaceDentroDaClasse  // Declara um namespace aninhado dentro de SeuNamespace.
    {
        struct SuaEstrutura  // Declara uma estrutura com o mesmo nome dentro deste namespace.
        {
            // Esta é uma estrutura diferente da SuaEstrutura definida no namespace pai.
        }
    }

    class SuaClassePrincipal  // Declara uma classe chamada SuaClassePrincipal.
    {
        static void Main(string[] args)  // Método de ponto de entrada do programa.
        {
            // Seu programa começa a ser executado a partir deste método.
        }
    }
}