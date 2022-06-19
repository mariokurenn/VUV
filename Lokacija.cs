using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace VUV_Projekti
{
    public class Lokacija
    {

        [XmlAttribute]
        public string Id
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

                    _id_lokacije = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        string znakovi = @"\|!#$%&/=?»«@£§€{};<>_";
        string slova = @"ABCDEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqrstuvwxyz";
        private string _id_lokacije;


        [XmlAttribute]
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

                   
                    _adresa = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _adresa;

        [XmlAttribute]
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
                    foreach (char slovo in slova)
                    {
                        if (value.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
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

        private string _postanskibroj;


        [XmlAttribute]
        public string Grad
        {
            get; set;
        }
   

        [XmlAttribute]
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
        private string _latituda;

        [XmlAttribute]
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
    

    private string _longituda;
    }
}
