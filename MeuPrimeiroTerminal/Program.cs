using System;

namespace MeuPrimeiroTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //  string txt = "Digite a sua idade: ";
            //  int idade = 0;
            //  Console.WriteLine(txt);
            // string idadeEmString = Console.ReadLine();
            // idade = Convert.ToInt32(idadeEmString);
            /*
            lugar para comentário
             */
            
            /*
            int[] meuArray = new int[6];
            meuArray[0] = 0;
            meuArray[1] = 0;
            meuArray[2] = 0;
            meuArray[3] = 0;
            meuArray[4] = 0;
            
            for(int i = 0; i <= 4; i++)
            {
                meuArray[i] = 10 + i;
            }
            for(int i = 0; i < meuArray.Length; i++)
            {
              Console.WriteLine(meuArray[i]);
            }
            Console.WriteLine("---------------------------------------------");
            
            foreach(int variavelIntDoArray in meuArray)
            {
               Console.WriteLine(variavelIntDoArray);
            }
           */
       
            
           {
               Console.WriteLine("Quanto números você quer?");
               string numerosEmString = Console.ReadLine();
               int numeros = Convert.ToInt32(numerosEmString);

                int resultado = 1;
                for(int i = 0; i < numeros; i++){

                    Console.WriteLine("Escreva seu numero:");
                    string numeroEmString = Console.ReadLine();
                    int numero = Convert.ToInt32(numeroEmString);
                    // resultado = resultado * numero;
                    resultado *= numero;
                }
                Console.WriteLine($"O resultado é:{resultado}");
           }
       }
    }
    
}
