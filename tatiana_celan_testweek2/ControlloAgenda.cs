using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_celan_testweek2
{
 public static   class ControlloAgenda
    { 
        public static void Start()
        {
            Console.WriteLine("\rSono la tua assistente personale, ti suggerisco di darmi sempre retta!");
            Console.WriteLine("\rBene, ora guarda cosa puoi fare");

            bool continua = true;
            do
            {
                Console.WriteLine(" \n\nScegli cosa vuoi fare: ");
                Console.WriteLine("         1- per vedere i tuoi impegni ");
                Console.WriteLine("         2- per aggiungere un nuovo task ");
                Console.WriteLine("         3- per eliminare un task ");
                Console.WriteLine("         4- per vedere la priorita dei tuoi impegni ");
                Console.WriteLine("         0- per uscire");
                Console.WriteLine();
                Console.WriteLine("Fai la tua scelta");

                int scelta;

                do
                {
                    Console.WriteLine("\nInserisci una  tra le opzioni proposte.");
                }
                while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 5));

                switch (scelta)
                {
                    case 1: // vedere gli impegni 
                        GestioneAgenda.StampaTuttiITask();
                        break;

                    case 2:// aggiungere nuovo task 
                        GestioneAgenda.AggiungiTask();
                        break;

                    case 3://elimina impegno 
                        GestioneAgenda.EliminaTask();
                        break;

                    case 4: // elenco delle priorita 
                        GestioneAgenda.FiltraTaskPerPriorita();
                        break;

                    case 0: // uscire 
                        Console.WriteLine();
                        Console.WriteLine("Hai scelto di uscire. I tuoi appuntamenti futuri sarrano salvati nel file"); 
                        Console.WriteLine();

                        GestioneAgenda.SalvataggioSuFileTask();


                        Console.WriteLine();
                        Console.WriteLine("\n**************Puoi tornare a dormire! Arrivederci :)**************");
                        Console.WriteLine("******************************************************************");

                        continua = false;

                        break;
                }
            }
            while (continua);

        }
    }
}
