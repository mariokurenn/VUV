using System;
using System.Collections.Generic;
using System.Text;
namespace VUV_Projekti.Renta75
{
    class Lokacija
    {
        Projekt id_projekta;
        string znakovi = @"\|!#$%&/()=?»«@£§€{}-;'<>_,";
        string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
        public Lokacija(string _id_lokacije,string _adresa, string _postanskibroj, string _grad, string _latituda, string _longituda)
        {
            this.id_lokacije = _id_lokacije;
            this.Adresa = _adresa;
            this.Postanskibroj = _postanskibroj;
            this.Grad = _grad;
            this.Latituda = _latituda;
            this.Longituda = _longituda;


        }
        private string _id_lokacije;
        public string id_lokacije
        {
            get { return _id_lokacije; }
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
                        if (stringint < 0)
                        {
                            throw new Exception("ID ne moze biti manji od 0");
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }

                    _id_lokacije = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _adresa;
        public string Adresa
        {
            get { return _adresa; }
            set
            {
                    try
                    {
                        if (value.Length <= 0)
                        {
                            throw new Exception("Adresa nije dobro postavljena");

                        }
                    
                        foreach (char slovo in znakovi)
                        {
                            if (value.Contains(slovo))
                            {
                                throw new Exception("Adresa ne moze sadrzavati specijalna slova");
                            }
                        }
                        _adresa = value;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
            }
        }
        private string _postanskibroj;
        public string Postanskibroj
        {
            get { return _postanskibroj; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Postanski broj nije dobro postavljen");

                    }

                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Postanski broj ne moze sadrzavati specijalna slova");
                        }
                    }

                    _postanskibroj = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _grad;
        public string Grad
        {
            get { return _grad; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Naziv Grada nije dobro postavljen");

                    }

                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Naziv Grada ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in value)
                    {
                        int broj;
                        bool uspjesno;
                        if (uspjesno = int.TryParse(slovo.ToString(), out broj))
                        {
                            throw new Exception("Naziv Grada ne moze sadrzavati broj");
                        }
                    }
                    _grad = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _latituda;
        public string Latituda
        {
            get { return _latituda; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Latituda nije dobro postavljena");

                    }

                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Latituda ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Latituda ne smije sadrzavati slovo");
                        }
                    }
                    _latituda = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _longituda;
        public string Longituda
        {
            get { return _longituda; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Latituda nije dobro postavljena");

                    }

                    foreach (char slovo in znakovi)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Latituda ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("Longituda ne smije sadrzavati slovo");
                        }
                    }
                    _longituda = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }   
    }
}
