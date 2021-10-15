using System;

namespace tatiana_celan_testweek2
{ // gestione agenda 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(); 
            Console.WriteLine("                         *****BUONGIORNO!*****");
            Console.WriteLine("                  E' giunta  l'ora di fare qualcosa !");
            Console.WriteLine();

            {
                ControlloAgenda.Start();
            }
        }
    }
}
