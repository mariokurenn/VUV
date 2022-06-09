using System;
using System.Collections.Generic;
using System.Text;

namespace VUV_Projekti
{
    
    class Aktivnost
    {
         public List<ClanProjekta> clanp;

        
        public Aktivnost(string _id_aktivnosti, string _naziv, string _opis, string _vrijeme, string id_lokacije, List<ClanProjekta> clanp)
        {
            this.id_aktivnosti = _id_aktivnosti;
            this.Naziv = _naziv;
            this.Opis = _opis;
            this.Vrijeme = _vrijeme;
            this.id_lokacije = id_lokacije;
            this.clanp = clanp;
           
        }

        string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
        

        private string _id_lokacije;
        public string id_lokacije
        {
            get { return _id_lokacije; }
            set
            {
                try
                {

                  
                    _id_lokacije = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _id_aktivnosti;
        public string id_aktivnosti
        {
            get { return _id_aktivnosti; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("ID nije dobro postavljen");
                    }

                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    int stringint;
                    
                        bool uspjesno = int.TryParse(value, out stringint);
                    if (stringint < 0)
                    {
                        throw new Exception("ID ne moze biti manji od 0");
                    }
                    _id_aktivnosti = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }



        private string _naziv;
        public string Naziv
        {
            get { return _naziv; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Naziv nije dobro postavljen");

                    }
                    foreach (char slovo in value)
                    {
                        int broj;
                        bool uspjesno;
                        if (uspjesno = int.TryParse(slovo.ToString(), out broj))
                        {
                            throw new Exception("Naziv ne moze sadrzavati broj");
                        }
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Naziv ne moze sadrzavati specijalna slova");
                        }
                    }
                    _naziv = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _opis;
        public string Opis
        {
            get { return _opis; }
            set { _opis = value; }
        }
        private string _vrijeme;
        public string Vrijeme 
        { 
          get { return _vrijeme; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Vrijeme nije dobro postavljeno");

                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Vrijeme ne moze sadrzavati specijalna slova");
                        }
                    }
                    _vrijeme = value;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message); 
                }
            } 
        }

        List<ClanProjekta> ClanoviAktivnost;
        Projekt p;
        Lokacija l;
        
    }
}
