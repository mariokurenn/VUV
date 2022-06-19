using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
namespace VUV_Projekti
{
    public class Projekt
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
        [Required()]
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
                    _nositelj = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _nositelj;
        [XmlAttribute]
        public string Vrijednost
        {
            get { return _vrijednost; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Vrijednost nije dobro postavljena");
                    }
                    _vrijednost = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _vrijednost;

        [XmlAttribute]

        public string Status
        {
            get { return _status; }
            set
            {
                try
                {
                    if (value.Length <= 0)
                    {
                        throw new Exception("Status nije dobro postavljen");
                    }
                    _status = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string _status;

        [XmlArrayAttribute("ClanProjekta")]
        public List<ClanProjekta> ClanProjekta { get; set; } = new List<ClanProjekta>();


        [XmlArrayAttribute("ListaVoditelja")]
        public List<ClanProjekta> ListaVoditelja { get; set; } = new List<ClanProjekta>();

        [XmlArrayAttribute("Aktivnosti")]
        public List<Aktivnost> Aktivnosti { get; set; } = new List<Aktivnost>();
        public Lokacija Lokacija { get; set; }

        [XmlAttribute]
        public int RedniBroj { get; set; }
    }
}
