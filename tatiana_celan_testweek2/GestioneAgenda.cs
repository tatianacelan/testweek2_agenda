using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_celan_testweek2
{
  public static class GestioneAgenda
    {
        public static List<Task> tasks = new List<Task>();

   

        public static void AggiungiTask()
        {
            Task task = new Task();

            Console.WriteLine(" \n Descrivi in poche parole il tuo impegno");
            task.Descrizione = Console.ReadLine();

            task.DataScadenza = InserisciDataTaskPrevista();

         

            task.LivelloPriorità = InserisciLivelloPriorita();
          
            // aggiungo 
            tasks.Add(task);
            Console.WriteLine(" \n Ho aggiunto il tuo impegno corretamente");

        }

        private static DateTime InserisciDataTaskPrevista()
        {
            DateTime data;
            do
            {
                Console.WriteLine();
                Console.WriteLine("\n Data prevista del impegno, o  aggiungi una data di scadenza ");

            }

            while (!(DateTime.TryParse(Console.ReadLine(), out data) && data >= DateTime.Today));

            return data;
        }

        private static Priorità InserisciLivelloPriorita()

        {
            Console.WriteLine();
            Console.WriteLine("\n Che livello di priorità scegliere?");
            Console.WriteLine();
            Console.WriteLine($"          {(int)Priorità.Alto} -{Priorità.Alto}");
            Console.WriteLine($"          {(int)Priorità.Medio} -{Priorità.Medio}");
            Console.WriteLine($"          {(int)Priorità.Basso} -{Priorità.Basso}");

            int priorità;
            do
            {
                Console.WriteLine("\nScegli ");
            }
            while (!(int.TryParse(Console.ReadLine(), out priorità) && priorità >= 1 && priorità <= 3));
            return (Priorità)priorità;

        }

      public static void FiltraTaskPerPriorita()
        {
            Priorità p = InserisciLivelloPriorita();
            List<Task> taskPerPriorità = new List<Task>();
            foreach (var item in tasks)
            {
                if(item.LivelloPriorità==p)
                {
                    taskPerPriorità.Add(item);

                }
            }

            Console.WriteLine("|n     I tuoi impegni sono i seguenti:        ");
            StampaITaskDiUnaCertaLista(taskPerPriorità);


         }

       public static void SalvataggioSuFileTask()
        {
     
          //  StampaITaskDiUnaCertaLista(tasks);

            
                string path = @"C:\Users\Tatiana\Desktop\prova venerdi 2 settimana\tatiana_celan_testweek2_agenda\tatiana_celan_testweek2\fileAgenda.txt";
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Questi sono i  tuoi impegni");

               //     StampaITaskListaSuFile(tasks);

                    sw.WriteLine($"");
                }

            



        }

        //public static void StampaITaskListaSuFile(List<Task> fileTasks)     
        //{
        //    if (fileTasks.Count == 0)                                                            //*qui volevo generare il metodo che salva i task su file 

        //    {
        //        sw.WriteLine();
              
        //    }

        //    {
        //        sw.WriteLine();

        //        foreach (var item in fileTasks)

        //        {
        //            sw.WriteLine($"             DaFare: {item.Descrizione}\t");
        //            sw.WriteLine($"             DataPrevista: {item.DataScadenza}\t");
        //            sw.WriteLine($"             Livello di priorità: {item.LivelloPriorità}\t");
        //            sw.WriteLine();

        //        }
        //    }

        //}
        public static void EliminaTask()
        {
            Console.WriteLine();
            Console.WriteLine(" Questo e l'elenco dei tuoi impegni:");
            Console.WriteLine();
            StampaTuttiITask();
            Console.WriteLine();
            Console.WriteLine("\n Cancella quelli che hai portato a termine o che non ti servono piu");
            Console.WriteLine("\n Scrivi la descrizione del evento da cancellare");
            string descrizioneEventoDaEliminare = Console.ReadLine();
            Task taskDaCancellare = CercaTaskPerDescrizione(descrizioneEventoDaEliminare);

            if (taskDaCancellare == null)
            {
                Console.WriteLine("\n   Non esiste questo impegno   ");
            }
            else
                tasks.Remove(taskDaCancellare);
            Console.WriteLine("\n **************Ho eliminato!******************** ");
            Console.WriteLine("**************************************************");

        }

        private static Task CercaTaskPerDescrizione(string descrizione)
        {
         foreach (var item in tasks)
            { 
                if (item.Descrizione==descrizione)
                {
                    return item;
                }
                    
            }
            return null;

        }

        public static void StampaTuttiITask()

        {

            Console.WriteLine(" ****************Sono questi i tuoi impegni!******************");
            StampaITaskDiUnaCertaLista(tasks);
            Console.WriteLine();
         

        }


        public static void StampaITaskDiUnaCertaLista(List<Task> elencoTasks)
        {
            if (elencoTasks.Count==0)
            {
                Console.WriteLine();
                Console.WriteLine("\n         **********Non hai nessun impegno!Createne uno!**********");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            }

            {
                Console.WriteLine();

                foreach (var item in elencoTasks)

                {
                    Console.WriteLine($"             DaFare: {item.Descrizione}\t");
                    Console.WriteLine($"             DataPrevista: {item.DataScadenza}\t");
                    Console.WriteLine($"             Livello di priorità: {item.LivelloPriorità}\t");
                    Console.WriteLine();

                }


            }
        }
    }
}
