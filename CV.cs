using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Console
{
    public class CV
    {
        public InfoPersonali InfoPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }

        public List<Impiego> Impieghi { get; set; }
    }

    public class InfoPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
    }

    public class Studi
    {
        public string Istituto { get; set; }
        public string Qualifica { get; set; }
        public string Tipo { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
    }

    public class Impiego
    {
        public Esperienza Esperienza { get; set; }
    }

    public class Esperienza
    {
        public string Azienda { get; set; }
        public string jobTiTle { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
    }
}
