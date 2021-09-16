using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            String frasedigitada, frasecomdislalia;
            Console.Write("Digite um Flase:");
            frasedigitada = Console.ReadLine();

            frasecomdislalia = frasedigitada.Replace("r", "l").Replace("R", "L");

            Console.WriteLine(frasecomdislalia);


            
        }
    }
}
