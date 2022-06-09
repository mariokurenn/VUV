using System;
using System.Collections.Generic;
using System.Text; 
namespace VUV_Projekti
{
    class Projekt
    {
        string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        private string _id_projekta;
        public string ID
        {
            get { return _id_projekta; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Redni broj nije dobro postavljen");

                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Redni broj ne moze sadrzavati specijalna slova");
                        }
                    }
                    _id_projekta = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _naziv;
        public string Naziv {

            get { return _naziv; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Naziv nije dobro postavljen");

                    }
                    _naziv = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }
        private string _nositelj;
        public string Nositelj
        {
            get { return _nositelj; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Nositelj nije dobro postavljen");

                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Nositelj ne moze sadrzavati specijalna slova");
                        }
                    }
                _nositelj = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _vrijednost;
        public string Vrijednost;
        private string _status;
        public string Status;

        List<ClanProjekta> Clanovi;
        Lokacija id_lokacije;


        public Projekt(string _id_projekta, string id_lokacije,List<ClanProjekta> Clanovi, string _naziv, string _nositelj, string _vrijednost, string _status)
        {
            this.ID = _id_projekta;
            this.Naziv = _naziv;
            this.Nositelj = _nositelj;
            this.Vrijednost = _vrijednost;
            this.Status = _status;
            this.Clanovi = Clanovi;
        }

   
    }
}
