using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace VUV_Projekti
{
    public abstract class Osoba
    {
        [XmlAttribute]
        public string ID
        {
            get { return _id; }
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

                    _id = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _id;
        string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
        [XmlAttribute]
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
                    foreach (char slovo in znakovi)
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
        private string _ime;
        [XmlAttribute]
        public string Prezime
        {
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
        private string _prezime;
        [XmlAttribute]
        public string OIB
        {
            get { return _oib; }
            set
            {
                try
                {
                    if (value.Length != 11)
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
        private string _oib;

    }
}
