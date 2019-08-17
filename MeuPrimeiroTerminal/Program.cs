using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            
             string txt = "Digite a sua idade: ";
             int idade = 0;
             Console.WriteLine(txt);
            string idadeEmString = Console.ReadLine();
            idade = Convert.ToInt32(idadeEmString);

            if(idade >10 && idade <15){
                Console.WriteLine($"Vc é adolecente");
            }     
            else if(idade <=10){
                Console.WriteLine($"Vc está novo!");
               }
               
            Console.WriteLine($"Vc digitou: {idadeEmString}");

        }
    }
    
}
