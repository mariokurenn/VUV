using System;
using System.Collections.Generic;
using System.Text;
namespace VUV_Projekti
{
    abstract class Osoba
    {
        private string id_clana;
        public string ID_clana
        {
            get { return id_clana; }
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
                    int stringint;
                   try
                    {
                         bool uspjesno = int.TryParse(value, out stringint);
                        if(stringint < 0)
                        {
                            throw new Exception("ID ne moze biti manji od 0");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                   
                    id_clana = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        
        private string _ime;
        public string Ime
        {
             get { return _ime; }
             set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Ime nije dobro postavljeno");
                    }
                    foreach (char slovo in value)
                    {
                        int broj;
                        bool uspjesno;
                        if (uspjesno = int.TryParse(slovo.ToString(), out broj))
                        {
                            throw new Exception("Ime ne moze sadrzavati broj");
                        }
                    }
                    foreach(char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Ime ne moze sadrzavati specijalna slova");
                        }
                    }
                    _ime = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _prezime;
        public string Prezime {
            get { return _prezime; }
            set
            { 
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Prezime nije dobro postavljeno");

                    }
                    foreach (char slovo in value)
                    {
                        int broj;
                        bool uspjesno;
                        if (uspjesno = int.TryParse(slovo.ToString(), out broj))
                        {
                            throw new Exception("Prezime ne moze sadrzavati broj");
                        }
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                        }
                    }
                    _prezime = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _oib;
        public string OIB
        {
            get { return _oib; }
            private set
            {
                try
                {
                    if(value.Length != 11)
                    {
                        throw new Exception("OIB nije dobro postavljen");
                    }
                    foreach (char slovo in slova)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("OIB ne smije sadrzavati slovo");
                        }
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("OIB ne moze sadrzavati specijalna slova");
                        }
                    }
                    _oib = value;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } 
        }
        private string Status{ get; set; }
        public Osoba(string id_clana, string _ime ,string _prezime, string _oib)
        {
           ID_clana = id_clana;
           Ime = _ime;
           Prezime = _prezime;
           OIB = _oib; 
        }
        string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
    }
}
