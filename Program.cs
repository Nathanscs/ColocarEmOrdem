using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    class Program
{       
    static int InsertionSorting()
    {
        int quantidade;
        Console.Write("Quantos numeros você quer colocar? ");
        quantidade = int.Parse(Console.ReadLine());
        Console.Write("\nDigite os numeros\n");

        int[] sequencia = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("\nDigite: ");
            sequencia[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nSequencia colocada: ");
        for (int k = 0; k < quantidade; k++)
        Console.Write("{0}, ", sequencia[k]);
        Console.Write("\n");

        for (int i = 1; i < quantidade; i++)
        {
            int j = i;
            while (j > 0)
        {
            if(sequencia[j - 1] > sequencia[j])
            {
                int temp = sequencia[j - 1];
                sequencia[j - 1] = sequencia[j];
                sequencia[j] = temp;
                j--;
            }
            else
            {
                break;
            }
        }

        for (int k = 0; k < quantidade; k++) ;
        }

        Console.Write("\n\nSerquencia de numero em ordem: \n\n");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("{0}, ",sequencia[i]);
        }
        return 0;
        }
        static void Main(string[] args)
        {
            InsertionSorting();
            Console.ReadLine();
        }
    }
}
