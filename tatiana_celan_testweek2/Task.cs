using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tatiana_celan_testweek2
{
  public  class Task
    {
        // elenco delle proprieta dei tasks
     
        public string Descrizione { get; set; }
        public DateTime DataScadenza { get; set; }
        public Priorità LivelloPriorità { get; set; }

        // costruttore 
        public Task()
        {
            
        }
    }
    public enum Priorità
    {
        Alto=1,
        Medio=2,
        Basso=3,
    }


}


