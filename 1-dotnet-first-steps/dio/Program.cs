using System;
using EstruturaDoPrograma.Exemplos;
namespace dio
{
    class Program
    {

        static void Main()
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }

        // static void Main(string[] args)
        // {
        //     int times = 5;

        //     for(int i= 0; i < times; i++)
        //     {
        //         Console.WriteLine($"number of times {i}");
        //     }
        //     Console.WriteLine("Hello World!");
        // }

    }
}
