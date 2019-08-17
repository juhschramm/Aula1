using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        private static object cont ;

        static void Main(string[] args)
        {
             string txt1 = "Hello World!";
             string txt2 = "Julia, com idade de:";
             int idade = 16;
             string txt3 = $"{txt1} {txt2} {idade}";
            
            Console.WriteLine(txt3);
        }
    }
    
}
