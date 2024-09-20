using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Criar uma lista com números inteiros//
        List<int> numeros = new List<int>();

        // Adicionar números à lista
        numeros.Add(05);
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);
        numeros.Add(40);
        numeros.Add(50);
        numeros.Add(60);
        numeros.Add(80);
        numeros.Add(90);
        numeros.Add(100);

        // passar sobre os elementos da lista e imprimir os números//
        Console.WriteLine("Lista de números:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
