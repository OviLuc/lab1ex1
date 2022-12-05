using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care citind de la tastatura cele trei dimensiuni ale unui paralelipiped 
             * dreptunghic, va afisa volumul lui */
            Console.WriteLine("Acest program va calcula volumul unui paralelipiped dreptunghic");
            Console.WriteLine("Introduceti lungimea");
            int lung = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            int lat = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            int inalt = int.Parse(Console.ReadLine());

            Console.WriteLine("Volumul paralelipipedului este: " + (lung * lat * inalt));
        }
    }
}
