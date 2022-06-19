using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace VUV_Projekti
{
    
     public class Aktivnost
    {
        [XmlArrayAttribute("ClanoviProjekta")]
        public List<ClanProjekta> ClanoviProjekta { get; set; } = new List<ClanProjekta>();


        [XmlAttribute]
        public string Id
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

        string znakovi = @"\|!#$%&/=?»«@£§€{};'<>_";
        string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
        private string _id_aktivnosti;

        [XmlAttribute]
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
        private string _naziv;

        [XmlAttribute]
        public string Opis
        {
            get { return _opis; }
            set { _opis = value; }
        }

        private string _opis;

        [XmlAttribute]
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


        private string _vrijeme;

    }
}
