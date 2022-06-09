using System;
using System.Collections.Generic;
using System.Text; 
namespace VUV_Projekti.Renta75
{
    class Projekt
    {
        public string ID { get; set; } 
        public string Naziv { get; set; }

        public string Nositelj { get; set; }

        public string Vrijednost { get; set; }
        
        public string Status { get; set; }

        public List<ClanProjekta> Clanovi=new List<ClanProjekta>();
        public Lokacija Lokacija;   
    }
}
