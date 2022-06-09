using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
namespace VUV_Projekti
{
    class ClanProjekta : Osoba
    {
        Projekt p;


        private bool _voditelj;



        public bool Voditelj
        {
            get { return _voditelj; }
            set
            {
                try
                {
                    if (Voditelj)
                    {

                    }
                    _voditelj = value;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            }
        }
        

        public ClanProjekta(string id_clana, string _ime, string _prezime, string _oib, bool _voditelj) : base(id_clana, _ime, _prezime, _oib)
        {
         
            this.Voditelj = _voditelj;
       
        }

       
}
}
