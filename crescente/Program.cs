using System;

namespace menor_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y;

            Console.Write("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y){
                if (x < y){
                    Console.Write("CRESCENTE!");
                 }
             else {
                Console.Write("DECRESCENTE!");
            }

            Console.Write("Digite outros dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());



        }
    }
}