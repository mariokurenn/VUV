using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Xml.Serialization;
using BetterConsoleTables;
using Console = Colorful.Console;
namespace VUV_Projekti
{
    [XmlRootAttribute("VUV", IsNullable = false)]
    public class VUV
    {
        [XmlArrayAttribute("Projekti")]
        public List<Projekt> Projekti { get; set; } = new List<Projekt>();
        [XmlArrayAttribute("ClanoviProjekta")]
        public List<ClanProjekta> Clanovi { get; set; } = new List<ClanProjekta>();
        [XmlArrayAttribute("Lokacije")]
        public List<Lokacija> Lokacije { get; set; } = new List<Lokacija>();
        [XmlArrayAttribute("ListaVoditelja")]
        public List<ClanProjekta> ListaVoditelja { get; set; } = new List<ClanProjekta>();

        // Funkcija za resetiranje Podataka
        public static void ResetirajPodatke()
        {
            VUV vuv = new VUV();
            ClanProjekta mario = new ClanProjekta { ID = "1", Ime = "Mario", Prezime = "Ivakovic", OIB = "28993030571", Voditelj = true, Deleted = false };
            ClanProjekta ivan = new ClanProjekta { ID = "2", Ime = "Ivan", Prezime = "Peric", OIB = "85739312800", Voditelj = true, Deleted = false };
            ClanProjekta helena = new ClanProjekta { ID = "3", Ime = "Helena", Prezime = "Ivic", OIB = "54684809551", Voditelj = true, Deleted = false };
            ClanProjekta vedran = new ClanProjekta { ID = "4", Ime = "Vedran", Prezime = "Jerkovic", OIB = "92029545561", Voditelj = true, Deleted = false };

            ClanProjekta bozo = new ClanProjekta { ID = "5", Ime = "Bozidar", Prezime = "Bozidarevic", OIB = "50736098472", Voditelj = true, Deleted = false };
            ClanProjekta petar = new ClanProjekta { ID = "6", Ime = "Petar", Prezime = "Peric", OIB = "62869221238", Voditelj = false, Deleted = false };
            ClanProjekta zeljko = new ClanProjekta { ID = "7", Ime = "Zeljko", Prezime = "Sendvic", OIB = "99384575988", Voditelj = false, Deleted = false };
            ClanProjekta zdravko = new ClanProjekta { ID = "8", Ime = "Zdravko", Prezime = "Babic", OIB = "86809339209", Voditelj = false, Deleted = false };
            ClanProjekta hamzo = new ClanProjekta { ID = "9", Ime = "Hamzo", Prezime = "Cuturic", OIB = "68689538295", Voditelj = false, Deleted = false };
            ClanProjekta vito = new ClanProjekta { ID = "10", Ime = "Vito", Prezime = "Rukavina", OIB = "90144583083", Voditelj = false, Deleted = false };
            ClanProjekta magda = new ClanProjekta { ID = "11", Ime = "Magda", Prezime = "Babic", OIB = "41511091594", Voditelj = false, Deleted = false };
            vuv.Clanovi.Add(mario);
            vuv.Clanovi.Add(ivan);
            vuv.Clanovi.Add(helena);
            vuv.Clanovi.Add(vedran);
            vuv.Clanovi.Add(bozo);
            vuv.Clanovi.Add(zeljko);
            vuv.Clanovi.Add(zdravko);
            vuv.Clanovi.Add(hamzo);
            vuv.Clanovi.Add(vito);
            vuv.ListaVoditelja.Add(mario);
            vuv.ListaVoditelja.Add(ivan);
            vuv.ListaVoditelja.Add(helena);
            vuv.ListaVoditelja.Add(vedran);

            Projekt p1 = new Projekt
            {
                ID = "1",
                Naziv = "Studentski startup inkubator",
                Nositelj = "Veleučilište u Virovitici – Odjel za ekonomiju",
                Status = "Aktivan",
                Vrijednost = "1000000 kuna",
                Lokacija = new Lokacija { Id = "1", Adresa = "Ulica Matije Gupca 23", Grad = "Virovitica", Longituda = "45.84193993175785", Latituda = "17.38768898218219", Postanskibroj = "33000" }
            };
            Aktivnost a1 = new Aktivnost { Id = "1", Naziv = "Održana konferencija", Opis = "Konferencija za studentski startup inkubator u Virovitici", Vrijeme = "1.9.2010. – 1.9.2011." };

            Projekt p2 = new Projekt
            {
                ID = "2",
                Naziv = "Izrada mobilne aplikacije Life Old Drava",
                Nositelj = "Visoka škola Virovitica – Centar za istraživanje i razvoj",
                Status = "Aktivan",
                Vrijednost = "20000 kuna",
                Lokacija = new Lokacija { Id = "2", Adresa = "Ulica Matije Gupca 23", Grad = "Virovitica", Longituda = "45.84193993175785", Latituda = "17.38768898218219", Postanskibroj = "33000" }
            };
            Aktivnost a2 = new Aktivnost { Id = "2", Naziv = "Team Meet-up", Opis = "Odrzavanje Team Meetupa nakon izrade mobilne aplikacije Life Old Drava", Vrijeme = "18.9.2017.-31.3.2017." };

            Projekt p3 = new Projekt
            {
                ID = "3",
                Naziv = "Provedba HKO u stručnim studijima računarstva (2019. – 2022.)",
                Nositelj = "Visoko učilište Algebra",
                Status = "Aktivan",
                Vrijednost = "3.836.901,74 kuna",
                Lokacija = new Lokacija { Id = "3", Adresa = "Gradišćanska ul. 24, 10000, Zagreb", Grad = "Zagreb", Longituda = "45.810331562989", Latituda = " 15.941404447629267", Postanskibroj = "10000" }
            };
            Aktivnost a3 = new Aktivnost { Id = "3", Naziv = "Razvoj i izrada standarda kvalifikacija na preddiplomskoj i diplomskoj razini", Opis = "Sudjelovanje na konferenciji i/ili edukaciji namijenjenoj unaprijeđenju stručnosti nastavnik", Vrijeme = "2014-2020." };


            Projekt p4 = new Projekt
            {
                ID = "4",
                Naziv = "Izgradnja studentskog doma u Virovitici",
                Nositelj = "Visoka škola Virovitica",
                Status = "Zavrsen",
                Vrijednost = "5.836.901,74 kuna",
                Lokacija = new Lokacija { Id = "4", Adresa = "Ul. Matije Gupca 78/4 ", Grad = "Virovitica", Longituda = "45.8418487638295", Latituda = "17.38902768907842", Postanskibroj = "33000" }
            };
            Aktivnost a4 = new Aktivnost { Id = "4", Naziv = "Izgradnja i planiranje doma za studente", Opis = "Tijekom tog perioda, ulozen je velik trud i napor za nase studente. Izgradnja je trajala preko godinu dana.", Vrijeme = "14.4.2015. -30.8.2017." };

            Projekt p5 = new Projekt
            {
                ID = "5",
                Naziv = "Usvajanje principa Hrvatskog kvalifikacijskog okvira(HKO - a)",
                Nositelj = "Libertas međunarodno sveučilište",
                Status = "Zavrsen",
                Vrijednost = "2684983.77 kuna",
                Lokacija = new Lokacija { Id = "5", Adresa = "Ul. Ive Lole Ribara ", Grad = "Donji Lapac", Longituda = "45.8418487638295", Latituda = "17.38902768907842", Postanskibroj = "53250" }
            };
            Aktivnost a5 = new Aktivnost { Id = "5", Naziv = "organizacija relevantnih fokus grupa,razvoj pet kvalifikacijskih standarda, jedan novi te prilagodba 4 postojeća studijska programa", Opis = "Organizirali smo relevantne fokus grupe, razvili pet kvalifikacijskih standarda, jedan novi te prilagodbu 4 postojeća programa", Vrijeme = "19.08.2013 - 19.03.2015" };


            p1.ClanProjekta.Add(bozo);


            a1.ClanoviProjekta.Add(mario);
            a1.ClanoviProjekta.Add(petar);
            a1.ClanoviProjekta.Add(ivan);



            p2.ListaVoditelja.Add(vedran);
            p2.ListaVoditelja.Add(helena);

            a2.ClanoviProjekta.Add(vito);
            a2.ClanoviProjekta.Add(bozo);
            a2.ClanoviProjekta.Add(hamzo);


            p3.ClanProjekta.Add(petar);
            p3.ClanProjekta.Add(vito);

            a3.ClanoviProjekta.Add(magda);
            a3.ClanoviProjekta.Add(mario);
            a3.ClanoviProjekta.Add(petar);
            a3.ClanoviProjekta.Add(ivan);

            p4.ClanProjekta.Add(vedran);
            p4.ClanProjekta.Add(vito);
            a4.ClanoviProjekta.Add(vedran);
            a4.ClanoviProjekta.Add(zdravko);
            a4.ClanoviProjekta.Add(helena);


            p5.ClanProjekta.Add(hamzo);
            p5.ClanProjekta.Add(vito);
            p5.ClanProjekta.Add(vedran);
            p5.ClanProjekta.Add(zdravko);
            a5.ClanoviProjekta.Add(vedran);
            a5.ClanoviProjekta.Add(petar);
            a5.ClanoviProjekta.Add(helena);

            p1.Aktivnosti.Add(a1);
            p2.Aktivnosti.Add(a2);
            p3.Aktivnosti.Add(a3);
            p4.Aktivnosti.Add(a4);
            p5.Aktivnosti.Add(a5);


            p1.ListaVoditelja.Add(ivan);
            p1.ListaVoditelja.Add(mario);


            p2.ClanProjekta.Add(zdravko);
            p2.ClanProjekta.Add(hamzo);

            p3.ListaVoditelja.Add(helena);

            p4.ListaVoditelja.Add(ivan);
            p4.ListaVoditelja.Add(mario);

            p5.ListaVoditelja.Add(ivan);
            vuv.Projekti.Add(p1);
            vuv.Projekti.Add(p2);
            vuv.Projekti.Add(p3);
            vuv.Projekti.Add(p4);
            vuv.Projekti.Add(p5);

            vuv.Lokacije.Add(p1.Lokacija);
            vuv.Lokacije.Add(p2.Lokacija);
            vuv.Lokacije.Add(p3.Lokacija);
            vuv.Lokacije.Add(p4.Lokacija);
            vuv.Lokacije.Add(p5.Lokacija);


            RedniBroj(vuv.Projekti);
            XmlSerializer x = new XmlSerializer(typeof(VUV));
            TextWriter writer = new StreamWriter("VUV.xml");
            x.Serialize(writer, vuv);
            writer.Dispose();
            Console.WriteLine("Podaci uspjesno resetirani");
            Meni();
        }
        // Funkcija koja objekte stavlja u XML
        public static void Serijalizacija(VUV vuv)
        {
            XmlSerializer x = new XmlSerializer(typeof(VUV));
            TextWriter writer = new StreamWriter("VUV.xml");
            x.Serialize(writer, vuv);
            writer.Dispose();
        }
        // Funkcija koja iz XMLa kreira objekte
        public static VUV Deserilizacija()
        {
            XmlSerializer x = new XmlSerializer(typeof(VUV));
            using var reader = new StreamReader("VUV.xml");
            var des = (VUV)x.Deserialize(reader);
            reader.Dispose();
            return des;

        }
        // Funkcija za kreiranje rednog broja
        public static void RedniBroj(List<Projekt> projekti)
        {

            int i = 1;
            foreach (Projekt p in projekti)
            {
                p.RedniBroj = i;
                i++;
            }
        }

        // Funkcija za ispis svih Lokacija
        public static VUV IspisLokacija()
        {
            var des = Deserilizacija();
            Table tablica = new Table("ID", "Grad", "Latituda", "Longituda", "Postanski Broj");
            tablica.Config = TableConfiguration.MySql();
            foreach (Lokacija l in des.Lokacije)
            {
                tablica.AddRow(l.Id, l.Grad, l.Latituda, l.Longituda, l.Postanskibroj);

            }
            Console.Write(tablica.ToString());

            return des;
        }
        // Funkcija za dohvacanje Voditelja i daljnje baratanje njima
        public static string GetVoditeljiString(List<ClanProjekta> voditelji)
        {
            var result = string.Empty;
            foreach (var clan in voditelji)
            {
                result = result + clan.Ime + " " + clan.Prezime + " ";
            }
            return result;
        }
        // Funkcija za meni
        public static void Meni()
        {
            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Program.Administracija();
            }

            string prompt = "";
            string[] opcije = { "Nazad" };
            Izbornik izlaz = new Izbornik(prompt, opcije);
            int OdabraniIndex = izlaz.Pokreni();

            switch (OdabraniIndex)
            {
                case 0:

                    Program.Administracija();
                    break;
            }
        }
        // Funkcija za ispis svih Projekata
        public static VUV IspisListeProjekata()
        {
            var des = Deserilizacija();
            Table tablica = new Table("R.Br", "Naziv", "Nositelj", "Vrijednost", "Status", "Voditelji", "Lokacija");
            tablica.Config = TableConfiguration.MySql();
            if (des.Projekti.Count > 0)
            {
                foreach (Projekt p in des.Projekti)
                {
                    tablica.AddRow(p.RedniBroj, p.Naziv, p.Nositelj, p.Vrijednost, p.Status, GetVoditeljiString(p.ListaVoditelja), p.Lokacija.Grad);
                }
                Console.Write(tablica.ToString());
            }
            else
            {
                Console.WriteLine("Ne postoji ni jedan projekt");
            }
            Meni();
            return des;
        }
        // Funkcija za ispis svih Aktivnosti
        public static VUV IspisSvihAktivnosti()
        {
            var des = Deserilizacija();
            Table tablica = new Table("ID aktivnosti", "Naziv", "Opis", "Vrijeme");
            tablica.Config = TableConfiguration.MySql();
            foreach (Projekt p in des.Projekti)
            {
                foreach (Aktivnost a in p.Aktivnosti)
                {
                    tablica.AddRow(a.Id, a.Naziv, a.Opis, a.Vrijeme);
                }
            }
            Console.Write(tablica.ToString());
            VUV.Serijalizacija(des);
            Meni();
            return des;
        }

        // Funkcija za kreiranje Projekta 
        public static void KreirajProjekt()
        {
            try
            {
                var des = Deserilizacija();
                Console.WriteLine("Dodajte projekt:");
                Console.WriteLine("");
                string id;
                string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
                string slova = @"ABCĆČŽDĐEFGHIJKLMNOPRQRSTUVWXYZabcćčđždefghijklmnoprqđrstuvwxyz";
                Projekt p = new Projekt();
                do
                {

                    try
                    {
                        Console.WriteLine("Upišite ID projekta: ");
                        id = Console.ReadLine();
                        if (id.Length == 0)
                        {
                            throw new Exception("ID je prazan");
                        }

                        foreach (char slovo in znakovi)
                        {
                            if (id.Contains(slovo))
                            {
                                throw new Exception("ID ne moze sadrzavati specijalna slova");

                            }
                        }
                        foreach (char slovo in slova)
                        {
                            if (id.Contains(slovo))
                            {
                                throw new Exception("ID ne smije sadrzavati slovo");
                            }
                        }
                        foreach (Projekt i in des.Projekti)
                        {

                            if (i.ID == id)
                            {
                                throw new Exception("Projekt s tim ID-em već postoji");
                            }

                        }
                        p.ID = id;
                        break;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }

                }
                while (true);
                do
                {
                    try
                    {
                        Console.WriteLine("Unesite naziv: ");
                        string naziv = Console.ReadLine();
                        if (naziv.Length == 0)
                        {
                            throw new Exception("Naziv je prazan, pokušajte ponovo");
                        }
                        p.Naziv = naziv;
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (true);
                do
                {
                    try
                    {
                        Console.WriteLine("Unesite nositelja: ");
                        string nositelj = Console.ReadLine();
                        if (nositelj.Length == 0)
                        {
                            throw new Exception("Nositelj je prazan, pokušajte ponovo");
                        }
                        p.Nositelj = nositelj;
                        break;
                    }
                    catch (Exception enaziv)
                    {
                        Console.WriteLine(enaziv.Message);
                    }
                } while (true);
                do
                {
                    try
                    {
                        Console.WriteLine("Unesite vrijednost");
                        string vrijednost = Console.ReadLine();
                        if (vrijednost.Length == 0)
                        {
                            throw new Exception("Vrijednost je prazna");
                        }
                        if (vrijednost.Contains(slova))
                        {
                            throw new Exception("Vrijednost ne smije sadrzavati slova");
                        }
                        p.Vrijednost = vrijednost + " kuna";
                        break;
                    }
                    catch (Exception evrijednost)
                    {
                        Console.WriteLine(evrijednost.Message);
                    }
                } while (true);
                do
                {
                    try
                    {
                        IspisLokacija();
                        Console.WriteLine("Unesite ID lokacije");
                        string id_lokacije = Console.ReadLine();
                        bool lokacijaprovjera = false;

                        if (id_lokacije.Length == 0)
                        {
                            throw new Exception("Vrijednost je prazna");
                        }
                        if (id_lokacije.Contains(slova))
                        {
                            throw new Exception("Vrijednost ne smije sadrzavati slova");
                        }
                        foreach (Lokacija l in des.Lokacije)
                        {
                            if (l.Id == id_lokacije)
                            {
                                p.Lokacija = l;
                                lokacijaprovjera = true;
                                break;
                            }
                        }
                        break;
                    }
                    catch (Exception elokacija)
                    {
                        Console.WriteLine(elokacija.Message);
                    }
                } while (true);


                try
                {
                    string prompt = "Unesite status projekta:";
                    string[] opcije = { "Aktivan", "Zavrsen", "Neaktivan" };
                    Izbornik izlaz = new Izbornik(prompt, opcije);
                    int OdabraniIndex = izlaz.Pokreni();

                    switch (OdabraniIndex)
                    {
                        case 0:
                            prompt = "Aktivan";
                            break;
                        case 1:
                            prompt = "Zavrsen";
                            break;
                        case 2:
                            prompt = "Neaktivan";
                            break;
                    }
                    p.Status = prompt;

                }
                catch (Exception eprojekt)
                {
                    Console.WriteLine(eprojekt.Message);
                }
                try
                {
                    Console.WriteLine("Projekt je uspjesno dodan.");
                    des.Projekti.Add(p);
                    RedniBroj(des.Projekti);
                    VUV.Serijalizacija(des);
                    Meni();
                }
                catch (Exception uspijeh)
                {

                    Console.WriteLine(uspijeh);
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        // Funckija za dodavnja aktivnosti sa svim atributima u dokument
        public static void DodajAktivnost()
        {
            var des = Deserilizacija();
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCĆČŽDĐEFGHIJKLMNOPRQRSTUVWXYZabcćčđždefghijklmnoprqđrstuvwxyz";
            string id;
            string idProjekta;
            string naziv;
            string opis;
            string vrijeme;
            Table tablica = new Table("R.Br", "Naziv", "Nositelj", "Vrijednost", "Status", "Voditelji", "Lokacija");

            tablica.Config = TableConfiguration.MySql();
            if (des.Projekti.Count > 0)
            {
                foreach (Projekt p in des.Projekti)
                {
                    tablica.AddRow(p.ID, p.Naziv, p.Nositelj, p.Vrijednost, p.Status, GetVoditeljiString(p.ListaVoditelja), p.Lokacija.Grad);
                }
                Console.Write(tablica.ToString());
            }
            else
            {
                Console.WriteLine("Ne postoji ni jedan projekt");
            }

            do
            {
                try
                {
                    Console.WriteLine("Dodajte aktivnost:");
                    Console.WriteLine("");
                    Console.WriteLine("Unesite ID projekta: ");
                    idProjekta = Console.ReadLine();
                    if (idProjekta.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }

                    foreach (char slovo in znakovi)
                    {
                        if (idProjekta.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");

                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (idProjekta.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    bool provjerabool = false;
                    foreach (Projekt provjera in des.Projekti)
                    {
                        if (idProjekta == provjera.ID)
                        {
                            provjerabool = true;
                        }
                    }
                    if (provjerabool == false)
                    {
                        throw new Exception("Projekt ne postoji");
                    }
                    break;
                }
                catch (Exception aktivnost)
                {
                    Console.WriteLine(aktivnost.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Unesite ID aktivnosti koji želite: ");
                    id = Console.ReadLine();
                    if (id.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }

                    foreach (char slovo in znakovi)
                    {
                        if (id.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");

                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (id.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }

                    foreach (Projekt p in des.Projekti)
                    {
                        foreach (Aktivnost a in p.Aktivnosti)
                        {
                            if (a.Id == id)
                            {
                                throw new Exception("Aktivnost s tim ID-em postoji");
                            }
                        }

                    }
                    break;
                }
                catch (Exception p)
                {

                    Console.WriteLine(p.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Unesite naziv: ");
                    naziv = Console.ReadLine();
                    if (naziv.Length == 0)
                    {
                        throw new Exception("Naziv je prazan, pokušajte ponovo");
                    }
                    break;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Unesite opis: ");
                    opis = Console.ReadLine();
                    if (opis.Length == 0)
                    {
                        throw new Exception("Opis ne moze biti prazan");
                    }
                    break;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.Write("Unesite početak trajanja aktivnosti u formatu dd.mm.yyyy: ");
                    string unos = Console.ReadLine();
                    if (!DateTime.TryParse(unos, out _))
                        throw new Exception("Unesen neispravan format!\n Pokušajte ponovno...");
                    Console.Write("Unesite kraj trajanja aktivnosti u formatu dd.mm.yyyy: ");
                    string kraj = Console.ReadLine();
                    if (!DateTime.TryParse(unos, out _))
                        throw new Exception("Unesen neispravan format!\n Pokušajte ponovno...");
                    vrijeme = $"{unos} - {kraj}";
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
            bool uspjesno = false;
            foreach (Projekt p in des.Projekti)
            {

                if (p.ID == idProjekta)
                {
                    Aktivnost a = new Aktivnost();
                    a.Id = id;
                    a.Naziv = naziv;
                    a.Opis = opis;
                    a.Vrijeme = vrijeme;
                    Console.WriteLine("Aktivnost je uspjesno dodana.");
                    p.Aktivnosti.Add(a);

                }
                foreach (Aktivnost a in p.Aktivnosti)
                {
                    if (a.ClanoviProjekta.Count == 0)
                    {
                        uspjesno = true;
                    }
                }

            }
            if (uspjesno == true)
            {
                Console.WriteLine("Aktivnost ne sadrži člana, molimo dodajte ga preko funkcije u izborniku");
            }
            VUV.Serijalizacija(des);
            IspisSvihAktivnosti();
            Meni();
        }
   
        // Ispis aktivnosti iz projekta
        public static VUV IspisAktivnostiProjekta()
        {
            var des = Deserilizacija();

            Console.WriteLine("Iz kojeg projekta zelite ocitati: ");
            Table tablica = new Table("R.Br", "Naziv", "Nositelj", "Vrijednost", "Status", "Voditelji", "Lokacija");
            tablica.Config = TableConfiguration.MySql();
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCĆČŽDĐEFGHIJKLMNOPRQRSTUVWXYZabcćčđždefghijklmnoprqđrstuvwxyz";
            string odabirprojekta = "";
            if (des.Projekti.Count > 0)
            {
                foreach (Projekt p in des.Projekti)
                {
                    tablica.AddRow(p.ID, p.Naziv, p.Nositelj, p.Vrijednost, p.Status, GetVoditeljiString(p.ListaVoditelja), p.Lokacija.Grad);
                }
                Console.Write(tablica.ToString());

                do
                {
                    try
                    {
                        Console.WriteLine("Unesite ID projekta:");
                        odabirprojekta = Console.ReadLine();
                        if (odabirprojekta.Length == 0)
                        {
                            throw new Exception("ID je prazan");
                        }
                        foreach (char slovo in znakovi)
                        {
                            if (odabirprojekta.Contains(slovo))
                            {
                                throw new Exception("ID ne moze sadrzavati specijalna slova");
                            }
                        }
                        foreach (char slovo in slova)
                        {
                            if (odabirprojekta.Contains(slovo))
                            {
                                throw new Exception("ID ne smije sadrzavati slovo");
                            }
                        }
                        bool postoji = false;
                        foreach (Projekt p in des.Projekti)
                        {
                            if (p.ID == odabirprojekta)
                            {
                                postoji = true;
                            }

                        }
                        if (postoji == false)
                        {
                            throw new Exception("Projekt s tim ID-em ne postoji");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                while (true);
                try
                {

                    Table tablica2 = new Table("ID", "Naziv", "Opis", "Vrijeme");
                    tablica2.Config = TableConfiguration.MySql();
                    foreach (Projekt p in des.Projekti)
                    {
                        if (odabirprojekta == p.ID)
                        {
                            foreach (Aktivnost a in p.Aktivnosti)
                            {
                                tablica2.AddRow(a.Id, a.Naziv, a.Opis, a.Vrijeme);
                            }

                        }
                    }
                    Console.Clear();
                    Console.Write(tablica2.ToString());
                }
                catch (Exception p)
                {

                    Console.WriteLine(p.Message);
                }
            }
            else
            {
                Console.WriteLine("Ne postoji ni jedan projekt");

            }
            VUV.Serijalizacija(des);
            Meni();
            return des;
        }
        // Funckija za azuriranje Projekta
        public static void AzurirajProjekt2()

        {
            var des = Deserilizacija();
            Table tablica = new Table("ID", "Naziv", "Nositelj", "Vrijednost", "Status", "Voditelji", "Lokacija");
            tablica.Config = TableConfiguration.MySql();
            foreach (Projekt p in des.Projekti)
            {
                tablica.AddRow(p.ID, p.Naziv, p.Nositelj, p.Vrijednost, p.Status, GetVoditeljiString(p.ListaVoditelja), p.Lokacija.Grad);
            }
            Console.Write(tablica.ToString());
            Console.WriteLine("Odaberite projekt:");
            Console.WriteLine("");
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
            string id = "";
            string naziv = "";
            string nositelj = "";
            string vrijednost = "";
            string id_lokacije = "";
            string voditelj;

            do
            {

                try
                {
                    Console.WriteLine("Upišite ID projekta: ");
                    id = Console.ReadLine();
                    if (id.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (id.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (id.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    break;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                break;
            }
            while (true);
            foreach (Projekt p1 in des.Projekti)
            {

                if (p1.ID == id)
                {

                    string prompt = "Koji dio želite ažurirati?";
                    string[] opcije = { "Naziv", "Nositelja", "Vrijednost", "Status", "Lokaciju", "Voditelja" };
                    Izbornik izlaz = new Izbornik(prompt, opcije);
                    int OdabraniIndex = izlaz.Pokreni();

                    switch (OdabraniIndex)
                    {
                        case 0:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite naziv: ");
                                    naziv = Console.ReadLine();
                                    if (naziv.Length == 0)
                                    {
                                        throw new Exception("Naziv je prazan");
                                    }
                                    p1.Naziv = naziv;
                                    break;
                                }
                                catch (Exception enaziv)
                                {
                                    Console.WriteLine(enaziv.Message);
                                }
                            } while (true);
                            break;

                        case 1:
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Unesite nositelja: ");
                                    nositelj = Console.ReadLine();
                                    if (nositelj.Length == 0)
                                    {
                                        throw new Exception("Naziv je prazan");
                                    }
                                    p1.Nositelj = nositelj;
                                    break;
                                }
                                catch (Exception enositelj)
                                {
                                    Console.WriteLine(enositelj.Message);
                                }

                            } while (true);
                            break;
                        case 2:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite vrijednost: ");
                                    vrijednost = Console.ReadLine();
                                    if (vrijednost.Length == 0)
                                    {
                                        throw new Exception("Vrijednost je prazna");
                                    }
                                    p1.Vrijednost = vrijednost;
                                    break;
                                }
                                catch (Exception evrijednost)
                                {

                                    Console.WriteLine(evrijednost.Message);
                                }

                            } while (true);
                            break;
                        case 3:
                            try
                            {
                                string prompt2 = "Unesite status projekta:";
                                string[] opcije2 = { "Aktivan", "Zavrsen", "Neaktivan" };
                                Izbornik izlaz2 = new Izbornik(prompt2, opcije2);
                                int OdabraniIndex2 = izlaz2.Pokreni();

                                switch (OdabraniIndex2)
                                {
                                    case 0:
                                        p1.Status = "Aktivan";
                                        break;
                                    case 1:
                                        p1.Status = "Zavrsen";
                                        break;
                                    case 2:
                                        p1.Status = "Neaktivan";
                                        break;
                                }


                            }
                            catch (Exception estatus)
                            {

                                Console.WriteLine(estatus.Message);
                            }
                            break;
                        case 4:
                            do
                            {
                                try
                                {

                                    Console.WriteLine("Unesite ID lokacije");
                                    foreach (Lokacija l in des.Lokacije)
                                    {
                                        Console.WriteLine(l.Id);
                                    }
                                    id_lokacije = Console.ReadLine();
                                    foreach (Lokacija l2 in des.Lokacije)
                                    {
                                        if (l2.Id == id_lokacije)
                                        {
                                            p1.Lokacija = l2;
                                        }
                                    }

                                    if (id_lokacije.Length == 0)
                                    {
                                        throw new Exception("Lokacija je prazna");
                                    }
                                    break;
                                }
                                catch (Exception elokacija)
                                {

                                    Console.WriteLine(elokacija.Message);
                                }
                            } while (true);
                            break;
                        case 5:
                            do
                            {
                                try
                                {
                                    string prompt3 = "Ažuriranje Voditelja:";
                                    string[] opcije3 = { "Dodaj", "Obriši" };
                                    Izbornik izlaz3 = new Izbornik(prompt3, opcije3);
                                    int OdabraniIndex3 = izlaz3.Pokreni();

                                    switch (OdabraniIndex3)
                                    {
                                        case 0:
                                            Table t2 = new Table("ID", "Ime", "Prezime", "OIB");
                                            t2.Config = TableConfiguration.MySql();
                                            foreach (ClanProjekta cp in des.ListaVoditelja)
                                            {
                                                t2.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB);
                                            }
                                            Console.WriteLine(t2.ToString());
                                            Console.WriteLine("Dodaj Voditelja");

                                            voditelj = Console.ReadLine();
                                            ClanProjekta clanVoditelj = new ClanProjekta();
                                            foreach (ClanProjekta clanProjekta in des.ListaVoditelja)
                                            {
                                                if (clanProjekta.ID == voditelj)
                                                {
                                                    clanVoditelj = clanProjekta;
                                                }
                                            }
                                            foreach (ClanProjekta clanProjekta in p1.ListaVoditelja)
                                            {
                                                if (clanProjekta.ID == voditelj)
                                                {
                                                    throw new Exception("Projekt ne moze sadrzavati dva ista voditelja");

                                                }
                                                break;
                                            }

                                            p1.ListaVoditelja.Add(clanVoditelj);
                                            VUV.Serijalizacija(des);
                                            break;
                                        case 1:
                                            do
                                            {
                                                try
                                                {
                                                    Table t3 = new Table("ID", "Ime", "Prezime", "OIB");
                                                    t3.Config = TableConfiguration.MySql();
                                                    foreach (ClanProjekta cp in p1.ListaVoditelja)
                                                    {
                                                        t3.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB);
                                                    }
                                                    Console.WriteLine(t3.ToString());
                                                    Console.WriteLine("Unesite ID Voditelja kojeg želite obrisati");
                                                    string a = Console.ReadLine();

                                                    int indexVoditelj = -1;
                                                    for (int i = 0; i < p1.ListaVoditelja.Count; i++)
                                                    {
                                                        if (p1.ListaVoditelja[i].ID == a)
                                                        {
                                                            indexVoditelj = i;
                                                        }
                                                    }
                                                    p1.ListaVoditelja.RemoveAt(indexVoditelj);
                                                    VUV.Serijalizacija(des);
                                                    break;
                                                }
                                                catch (Exception e)
                                                {

                                                    Console.WriteLine(e.Message);
                                                }
                                            } while (true);
                                            break;

                                    }
                                }
                                catch (Exception elokacija)
                                {

                                    Console.WriteLine(elokacija.Message);
                                }
                            } while (true);
                            break;
                    }
                }
            }
            VUV.Serijalizacija(des);
            IspisListeProjekata();
            Meni();
        }

        // Funkcija sa ispisom liste clanova
        public static VUV ListaClanova2()
        {
            var des = Deserilizacija();
            Table tablicaClanova;
            Table tablicaProjekata;
            Table tablicaAktivnosti;
            Console.WriteLine("Lista članova:");
            foreach (ClanProjekta cp in des.Clanovi)
            {

                tablicaClanova = new Table("ID Clana", "Ime", "Prezime", "OIB", "Voditelj");
                tablicaClanova.Config = TableConfiguration.MySql();
                tablicaClanova.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB, cp.Voditelj);



                foreach (Projekt p in des.Projekti)
                {
                    tablicaProjekata = new Table("ID Clana", "ID Projekta", "Naziv", "Nositelj", "Vrijednost", "Status");
                    tablicaProjekata.Config = TableConfiguration.Simple();
                    tablicaProjekata.AddRow(cp.ID, p.ID, p.Naziv, p.Nositelj, p.Vrijednost, p.Status);
                    foreach (Aktivnost a in p.Aktivnosti)
                    {

                        tablicaAktivnosti = new Table("ID Clana", "ID Projekta", "ID Aktivnosti", "Naziv Aktivnosti", "Opis Aktivnosti", "Vrijeme");
                        tablicaAktivnosti.Config = TableConfiguration.MySqlSimple();
                        tablicaAktivnosti.AddRow(cp.ID, p.ID, a.Id, a.Naziv, a.Opis, a.Vrijeme);
                        Console.WriteLine();
                   
                        Console.WriteLine();
                        Console.Write(tablicaClanova.ToString(), Color.FromArgb(1,138, 192, 100));
                        Console.WriteLine();
                       
                        Console.WriteLine();
                        Console.Write(tablicaProjekata.ToString(),Color.FromArgb(1, 217, 179, 255));
                        Console.WriteLine();
                      
                        Console.WriteLine();
                        Console.Write(tablicaAktivnosti.ToString(), Color.FromArgb(1, 255, 0, 102));
                        Console.WriteLine();
                        Console.WriteLine(@"________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________");
                       Console.WriteLine();
                    }
                }
                Console.WriteLine("Tablica Clanova ▬ ", Color.FromArgb(1, 138, 192, 100));
                Console.WriteLine("Tablica Projekata ▬", Color.FromArgb(1, 217, 179, 255));
                Console.WriteLine("Tablica Aktivnosti ▬", Color.FromArgb(1, 255, 0, 102));
            }

            VUV.Serijalizacija(des);
            Meni();
            return des;
        }

        // Backup Funkcije
        public static VUV ListaClanova()
        {
            var des = Deserilizacija();
            Table tablica = new Table("ID Clana", "Ime", "Prezime", "OIB", "Voditelj");
            tablica.Config = TableConfiguration.MySql();
            foreach (ClanProjekta cp in des.Clanovi)
            {
                tablica.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB, cp.Voditelj);
                foreach (Projekt p in des.Projekti)
                {
                    tablica.AddRow(p.ID, p.Naziv, p.Nositelj, p.Vrijednost, p.Status);
                    foreach (Aktivnost a in p.Aktivnosti)
                    {
                        tablica.AddRow(a.Id, a.Naziv, a.Opis, a.Vrijeme);

                    }
                }
            }
            Console.WriteLine("Lista članova:");
            Console.Write(tablica.ToString());
            VUV.Serijalizacija(des);
            Meni();
            return des;
        }

        // Funkcija za brisanje clana iz dokumenta
        public static VUV BrisanjeClana()
        {
            var des = Deserilizacija();
            Table tablica = new Table("ID Clana", "Ime", "Prezime", "OIB", "Voditelj", "Obrisan");
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCĆČŽDĐEFGHIJKLMNOPRQRSTUVWXYZabcćčđždefghijklmnoprqđrstuvwxyz";
            tablica.Config = TableConfiguration.MySql();
            string a;
            foreach (ClanProjekta cp in des.Clanovi)
            {
                tablica.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB, cp.Voditelj, cp.Deleted);
            }
            Console.Write(tablica.ToString());
            do
            {
                try
                {
                    Console.WriteLine("Unesite ID člana kojeg želite obrisati");
                    a = Console.ReadLine();
                    if (a.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }

                    foreach (char slovo in znakovi)
                    {
                        if (a.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");

                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (a.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    bool jedobro = false;
                    foreach (ClanProjekta _clan in des.Clanovi)
                    {
                        if (_clan.ID == a)
                        {
                            jedobro = true;
                        }
                    }
                    if (jedobro == false)
                    {
                        throw new Exception("Clan ne postoji");
                    }
                    break;
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
            } while (true);

            foreach (ClanProjekta clan in des.Clanovi)
            {
                if (a == clan.ID)
                {
                    clan.Deleted = true;
                }

            }

            Table tablicaPoslje = new Table("ID Clana", "Ime", "Prezime", "OIB", "Voditelj", "Obrisan");
            tablicaPoslje.Config = TableConfiguration.MySql();
            foreach (ClanProjekta cp in des.Clanovi)
            {
                tablicaPoslje.AddRow(cp.ID, cp.Ime, cp.Prezime, cp.OIB, cp.Voditelj, cp.Deleted);
            }
            Console.Write(tablicaPoslje.ToString());
            foreach (Projekt p in des.Projekti)
            {
                foreach (ClanProjekta cp in p.ClanProjekta)
                {
                    if (p.ClanProjekta.Count == 1)
                    {
                        p.Status = "Neaktivan";
                    }
                }
            }
            VUV.Serijalizacija(des);
            Meni();
            return des;
        }

        public static void DodavanjeClana()
        {
            var des = Deserilizacija();

            Table tablica = new Table("R.Br", "Naziv", "Status", "Lokacija");
            tablica.Config = TableConfiguration.MySql();
            foreach (Projekt p in des.Projekti)
            {
                tablica.AddRow(p.ID, p.Naziv, p.Status, p.Lokacija.Grad);
            }
            Console.Write(tablica.ToString());
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
            string brojeiv = @"0123456789";
            Console.WriteLine("U koji projekt želite dodati clana:");
            string odabirprojekta;
            bool pronadenprojet = false;
            string id;
            string ime = "";
            string prezime = "";
            string oib = "";
            bool voditelj = false;
            bool deleted = false;

            do
            {
                try
                {
                    Console.WriteLine("Odaberite projekt: ");
                    odabirprojekta = Console.ReadLine();
                    if (odabirprojekta.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (odabirprojekta.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (odabirprojekta.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    break;
                }
                catch (Exception ks)
                {

                    Console.WriteLine(ks.Message);
                }
            } while (true);
            foreach (Projekt p in des.Projekti)
            {

                if (odabirprojekta == p.ID)
                {
                    string prompt = "Koga želite dodati?";
                    string[] opcije = { "Clan", "Voditelja" };
                    Izbornik izlaz = new Izbornik(prompt, opcije);
                    int OdabraniIndex = izlaz.Pokreni();

                    switch (OdabraniIndex)
                    {
                        case 0:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Dodajte člana");
                                    Console.WriteLine("");
                                    Console.WriteLine("Unesite ID: ");
                                    id = Console.ReadLine();
                                    if (id.Length == 0)
                                    {
                                        throw new Exception("ID je prazan");
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (id.Contains(slovo))
                                        {
                                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    foreach (char slovo in slova)
                                    {
                                        if (id.Contains(slovo))
                                        {
                                            throw new Exception("ID ne smije sadrzavati slovo");
                                        }
                                    }
                                    bool postoji = false;
                                    foreach (ClanProjekta cp in des.Clanovi)
                                    {
                                        if (cp.ID == id)
                                        {
                                            postoji = true;
                                            break;
                                        }
                                    }
                                    if (postoji == true)
                                    {
                                        throw new Exception("Clan s tim ID-em vec postoji");
                                    }
                                    break;
                                }
                                catch (Exception enaziv)
                                {
                                    Console.WriteLine(enaziv.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite ime: ");
                                    ime = Console.ReadLine();
                                    if (ime.Length == 0)
                                    {
                                        throw new Exception("Ime ne moze biti prazno");
                                    }
                                    foreach (char slovo in brojeiv)
                                    {
                                        if (ime.Contains(slovo))
                                        {
                                            throw new Exception("Ime ne moze sadrzavati brojeve");
                                        }
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (ime.Contains(slovo))
                                        {
                                            throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    break;
                                }
                                catch (Exception i)
                                {

                                    Console.WriteLine(i.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite prezime: ");
                                    prezime = Console.ReadLine();
                                    if (prezime.Length == 0)
                                    {
                                        throw new Exception("Prezime ne moze biti prazno");
                                    }
                                    foreach (char slovo in brojeiv)
                                    {
                                        if (prezime.Contains(slovo))
                                        {
                                            throw new Exception("Prezime ne moze sadrzavati brojeve");
                                        }
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (prezime.Contains(slovo))
                                        {
                                            throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    break;
                                }
                                catch (Exception ep)
                                {

                                    Console.WriteLine(ep.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Molimo upišite oib");
                                    oib = Console.ReadLine();
                                    if (oib.Length != 11)
                                    {
                                        throw new Exception("Pogresan unos OIBA");
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (oib.Contains(slovo))
                                        {
                                            throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    foreach (char slovo in slova)
                                    {
                                        if (oib.Contains(slovo))
                                        {
                                            throw new Exception("OIB ne moze sadrzavati slova");
                                        }
                                    }
                                    foreach (Projekt pi in des.Projekti)
                                    {
                                        foreach (ClanProjekta cp in pi.ClanProjekta)
                                        {
                                            foreach (ClanProjekta vodi in pi.ListaVoditelja)
                                            {
                                                if (cp.OIB == vodi.OIB)
                                                {
                                                    throw new Exception("Postoji osoba sa istim oibom");
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                                catch (Exception oi)
                                {

                                    Console.WriteLine(oi.Message);
                                }
                            } while (true);

                            ClanProjekta cp1 = new ClanProjekta();
                            cp1.ID = id;
                            cp1.Ime = ime;
                            cp1.Prezime = prezime;
                            cp1.OIB = oib;
                            cp1.Voditelj = voditelj;
                            des.Clanovi.Add(cp1);
                            p.ClanProjekta.Add(cp1);
                            VUV.Serijalizacija(des);
                            break;

                        case 1:
                            voditelj = true;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Dodajte voditelja");
                                    Console.WriteLine("");
                                    Console.WriteLine("Unesite ID: ");
                                    id = Console.ReadLine();
                                    if (id.Length == 0)
                                    {
                                        throw new Exception("ID je prazan");
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (id.Contains(slovo))
                                        {
                                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    foreach (char slovo in slova)
                                    {
                                        if (id.Contains(slovo))
                                        {
                                            throw new Exception("ID ne smije sadrzavati slovo");
                                        }
                                    }
                                    bool postoji = false;
                                    foreach (ClanProjekta cp in des.ListaVoditelja)
                                    {
                                        if (cp.ID == id)
                                        {
                                            postoji = true;
                                            break;
                                        }
                                    }
                                    if (postoji == true)
                                    {
                                        throw new Exception("Voditelj s tim ID-em vec postoji");
                                    }
                                    break;
                                }
                                catch (Exception enaziv)
                                {
                                    Console.WriteLine(enaziv.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite ime: ");
                                    ime = Console.ReadLine();
                                    if (ime.Length == 0)
                                    {
                                        throw new Exception("Ime ne moze biti prazno");
                                    }
                                    foreach (char slovo in brojeiv)
                                    {
                                        if (ime.Contains(slovo))
                                        {
                                            throw new Exception("Ime ne moze sadrzavati brojeve");
                                        }
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (ime.Contains(slovo))
                                        {
                                            throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    break;
                                }
                                catch (Exception i)
                                {

                                    Console.WriteLine(i.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite prezime: ");
                                    prezime = Console.ReadLine();
                                    if (prezime.Length == 0)
                                    {
                                        throw new Exception("Prezime ne moze biti prazno");
                                    }
                                    foreach (char slovo in brojeiv)
                                    {
                                        if (prezime.Contains(slovo))
                                        {
                                            throw new Exception("Prezime ne moze sadrzavati brojeve");
                                        }
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (prezime.Contains(slovo))
                                        {
                                            throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    break;
                                }
                                catch (Exception ep)
                                {

                                    Console.WriteLine(ep.Message);
                                }
                            } while (true);
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Molimo upišite oib");
                                    oib = Console.ReadLine();
                                    if (oib.Length != 11)
                                    {
                                        throw new Exception("Pogresan unos OIBA");
                                    }
                                    foreach (char slovo in znakovi)
                                    {
                                        if (oib.Contains(slovo))
                                        {
                                            throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                        }
                                    }
                                    foreach (char slovo in slova)
                                    {
                                        if (oib.Contains(slovo))
                                        {
                                            throw new Exception("OIB ne moze sadrzavati slova");
                                        }
                                    }
                                    foreach (Projekt pi in des.Projekti)
                                    {
                                        foreach (ClanProjekta cp in pi.ClanProjekta)
                                        {
                                            foreach (ClanProjekta vodi in pi.ListaVoditelja)
                                            {
                                                if (cp.OIB == vodi.OIB)
                                                {
                                                    throw new Exception("Postoji osoba sa istim oibom");
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                                catch (Exception oi)
                                {
                                    Console.WriteLine(oi.Message);
                                }
                            } while (true);

                            ClanProjekta cp2 = new ClanProjekta();
                            cp2.ID = id;
                            cp2.Ime = ime;
                            cp2.Prezime = prezime;
                            cp2.OIB = oib;
                            cp2.Voditelj = voditelj;
                            des.ListaVoditelja.Add(cp2);
                            p.ListaVoditelja.Add(cp2);
                            VUV.Serijalizacija(des);
                            break;

                    }
                }
            }
            VUV.Serijalizacija(des);
            Meni();
        }
        public static void DodavanjeClana2()
        {
            var des = Deserilizacija();

            Table tablica = new Table("ID", "Naziv", "Status", "Lokacija");
            tablica.Config = TableConfiguration.MySql();
            foreach (Projekt p in des.Projekti)
            {
                tablica.AddRow(p.ID, p.Naziv, p.Status, p.Lokacija.Grad);
            }
            Console.Write(tablica.ToString());
            string znakovi = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            string slova = @"ABCDĐEFGHIJKLMNOPRQRSTUVWXYZabcdefghijklmnoprqđrstuvwxyz";
            string brojeiv = @"0123456789";
            Console.WriteLine("U koji projekt želite dodati clana:");
            string odabirprojekta;
            string odabiraktivnost;
            bool pronadenprojet = false;
            string id;
            string ime = "";
            string prezime = "";
            string oib = "";
            bool voditelj = false;
            bool deleted = false;

            do
            {
                try
                {
                    Console.WriteLine("Odaberite projekt: ");
                    odabirprojekta = Console.ReadLine();
                    if (odabirprojekta.Length == 0)
                    {
                        throw new Exception("ID je prazan");
                    }
                    foreach (char slovo in znakovi)
                    {
                        if (odabirprojekta.Contains(slovo))
                        {
                            throw new Exception("ID ne moze sadrzavati specijalna slova");
                        }
                    }
                    foreach (char slovo in slova)
                    {
                        if (odabirprojekta.Contains(slovo))
                        {
                            throw new Exception("ID ne smije sadrzavati slovo");
                        }
                    }
                    break;
                }
                catch (Exception ks)
                {

                    Console.WriteLine(ks.Message);
                }
            } while (true);


            string prompt2 = "";
            string[] opcije2 = { "Projekt", "Aktivnost" };
            Izbornik izlaz2 = new Izbornik(prompt2, opcije2);
            int OdabraniIndex2 = izlaz2.Pokreni();

            switch (OdabraniIndex2)
            {
                case 0:
                    foreach (Projekt p in des.Projekti)
                    {
                        if (odabirprojekta == p.ID)
                        {
                            string prompt = "Koga želite dodati?";
                            string[] opcije = { "Clan", "Voditelja" };
                            Izbornik izlaz = new Izbornik(prompt, opcije);
                            int OdabraniIndex = izlaz.Pokreni();
                            switch (OdabraniIndex)
                            {
                                case 0:
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Dodajte člana");
                                            Console.WriteLine("");
                                            Console.WriteLine("Unesite ID: ");
                                            id = Console.ReadLine();
                                            if (id.Length == 0)
                                            {
                                                throw new Exception("ID je prazan");
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (id.Contains(slovo))
                                                {
                                                    throw new Exception("ID ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            foreach (char slovo in slova)
                                            {
                                                if (id.Contains(slovo))
                                                {
                                                    throw new Exception("ID ne smije sadrzavati slovo");
                                                }
                                            }
                                            bool postoji = false;
                                            foreach (ClanProjekta cp in des.Clanovi)
                                            {
                                                if (cp.ID == id)
                                                {
                                                    postoji = true;
                                                    break;
                                                }
                                            }
                                            if (postoji == true)
                                            {
                                                throw new Exception("Clan s tim ID-em vec postoji");
                                            }
                                            break;
                                        }
                                        catch (Exception enaziv)
                                        {
                                            Console.WriteLine(enaziv.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Unesite ime: ");
                                            ime = Console.ReadLine();
                                            if (ime.Length == 0)
                                            {
                                                throw new Exception("Ime ne moze biti prazno");
                                            }
                                            foreach (char slovo in brojeiv)
                                            {
                                                if (ime.Contains(slovo))
                                                {
                                                    throw new Exception("Ime ne moze sadrzavati brojeve");
                                                }
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (ime.Contains(slovo))
                                                {
                                                    throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception i)
                                        {

                                            Console.WriteLine(i.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Unesite prezime: ");
                                            prezime = Console.ReadLine();
                                            if (prezime.Length == 0)
                                            {
                                                throw new Exception("Prezime ne moze biti prazno");
                                            }
                                            foreach (char slovo in brojeiv)
                                            {
                                                if (prezime.Contains(slovo))
                                                {
                                                    throw new Exception("Prezime ne moze sadrzavati brojeve");
                                                }
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (prezime.Contains(slovo))
                                                {
                                                    throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception ep)
                                        {

                                            Console.WriteLine(ep.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Molimo upišite oib");
                                            oib = Console.ReadLine();
                                            if (oib.Length != 11)
                                            {
                                                throw new Exception("Pogresan unos OIBA");
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (oib.Contains(slovo))
                                                {
                                                    throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            foreach (char slovo in slova)
                                            {
                                                if (oib.Contains(slovo))
                                                {
                                                    throw new Exception("OIB ne moze sadrzavati slova");
                                                }
                                            }
                                            foreach (Projekt pi in des.Projekti)
                                            {
                                                foreach (ClanProjekta cp in des.Clanovi)
                                                {
                                                    if (cp.OIB == oib)
                                                    {
                                                        throw new Exception("Clan Projekta sa tim OIBom");
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception oi)
                                        {

                                            Console.WriteLine(oi.Message);
                                        }
                                    } while (true);

                                    ClanProjekta cp1 = new ClanProjekta();
                                    cp1.ID = id;
                                    cp1.Ime = ime;
                                    cp1.Prezime = prezime;
                                    cp1.OIB = oib;
                                    cp1.Voditelj = voditelj;
                                    des.Clanovi.Add(cp1);
                                    p.ClanProjekta.Add(cp1);
                                    VUV.Serijalizacija(des);
                                    break;

                                case 1:
                                    voditelj = true;
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Dodajte voditelja");
                                            Console.WriteLine("");
                                            Console.WriteLine("Unesite ID: ");
                                            id = Console.ReadLine();
                                            if (id.Length == 0)
                                            {
                                                throw new Exception("ID je prazan");
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (id.Contains(slovo))
                                                {
                                                    throw new Exception("ID ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            foreach (char slovo in slova)
                                            {
                                                if (id.Contains(slovo))
                                                {
                                                    throw new Exception("ID ne smije sadrzavati slovo");
                                                }
                                            }
                                            bool postoji = false;
                                            foreach (ClanProjekta cp in des.ListaVoditelja)
                                            {
                                                if (cp.ID == id)
                                                {
                                                    postoji = true;
                                                    break;
                                                }
                                            }
                                            if (postoji == true)
                                            {
                                                throw new Exception("Voditelj s tim ID-em vec postoji");
                                            }
                                            break;
                                        }
                                        catch (Exception enaziv)
                                        {
                                            Console.WriteLine(enaziv.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Unesite ime: ");
                                            ime = Console.ReadLine();
                                            if (ime.Length == 0)
                                            {
                                                throw new Exception("Ime ne moze biti prazno");
                                            }
                                            foreach (char slovo in brojeiv)
                                            {
                                                if (ime.Contains(slovo))
                                                {
                                                    throw new Exception("Ime ne moze sadrzavati brojeve");
                                                }
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (ime.Contains(slovo))
                                                {
                                                    throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception i)
                                        {

                                            Console.WriteLine(i.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Unesite prezime: ");
                                            prezime = Console.ReadLine();
                                            if (prezime.Length == 0)
                                            {
                                                throw new Exception("Prezime ne moze biti prazno");
                                            }
                                            foreach (char slovo in brojeiv)
                                            {
                                                if (prezime.Contains(slovo))
                                                {
                                                    throw new Exception("Prezime ne moze sadrzavati brojeve");
                                                }
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (prezime.Contains(slovo))
                                                {
                                                    throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception ep)
                                        {

                                            Console.WriteLine(ep.Message);
                                        }
                                    } while (true);
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Molimo upišite oib");
                                            oib = Console.ReadLine();
                                            if (oib.Length != 11)
                                            {
                                                throw new Exception("Pogresan unos OIBA");
                                            }
                                            foreach (char slovo in znakovi)
                                            {
                                                if (oib.Contains(slovo))
                                                {
                                                    throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                                }
                                            }
                                            foreach (char slovo in slova)
                                            {
                                                if (oib.Contains(slovo))
                                                {
                                                    throw new Exception("OIB ne moze sadrzavati slova");
                                                }
                                            }
                                            foreach (Projekt pi in des.Projekti)
                                            {
                                                foreach (ClanProjekta cp in pi.ClanProjekta)
                                                {
                                                    foreach (ClanProjekta vodi in pi.ListaVoditelja)
                                                    {
                                                        if (cp.OIB == vodi.OIB)
                                                        {
                                                            throw new Exception("Postoji osoba sa istim oibom");
                                                        }
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                        catch (Exception oi)
                                        {
                                            Console.WriteLine(oi.Message);
                                        }
                                    } while (true);

                                    ClanProjekta cp2 = new ClanProjekta();
                                    cp2.ID = id;
                                    cp2.Ime = ime;
                                    cp2.Prezime = prezime;
                                    cp2.OIB = oib;
                                    cp2.Voditelj = voditelj;
                                    des.ListaVoditelja.Add(cp2);
                                    p.ListaVoditelja.Add(cp2);
                                    VUV.Serijalizacija(des);
                                    break;

                            }
                        }

                    }
                    break;

                case 1:
                    bool jedobro = true;
                    Table t1 = new Table("ID", "Naziv", "Opis", "Vrijeme trajanja");
                    foreach (Projekt p in des.Projekti)
                    {

                        if (odabirprojekta == p.ID)
                        {
                            if (p.Aktivnosti.Count == 0)
                            {
                                string prompt3 = "Projekt nije sadrzao ni jednu aktivnost, stoga molimo vas odaberite jednu od ponudenih opcija";
                                string[] opcije3 = { "Dodajte Aktivnost", "Natrag" };
                                Izbornik izlaz3 = new Izbornik(prompt3, opcije3);
                                int OdabraniIndex3 = izlaz3.Pokreni();
                                switch (OdabraniIndex3)
                                {
                                    case 0:
                                        DodajAktivnost();
                                        break;
                                    case 1:
                                        Program.Administracija();
                                        break;
                                }
                            }
                            foreach (Aktivnost ap in p.Aktivnosti)
                            {
                                t1.AddRow(ap.Id, ap.Naziv, ap.Opis, ap.Vrijeme);

                            }

                            Console.WriteLine(t1.ToString());

                            do
                            {
                                try
                                {
                                    Console.WriteLine("Unesite aktivnost u koju želite dodati člana");
                                    odabiraktivnost = Console.ReadLine();
                                    foreach (Aktivnost ap1 in p.Aktivnosti)
                                    {
                                        if (odabiraktivnost == ap1.Id)
                                        {
                                            jedobro = false;
                                            string prompt = "Koga želite dodati?";
                                            string[] opcije = { "Clan", "Voditelja" };
                                            Izbornik izlaz = new Izbornik(prompt, opcije);
                                            int OdabraniIndex = izlaz.Pokreni();
                                            switch (OdabraniIndex)
                                            {
                                                case 0:
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Dodajte člana");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Unesite ID: ");
                                                            id = Console.ReadLine();
                                                            if (id.Length == 0)
                                                            {
                                                                throw new Exception("ID je prazan");
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (id.Contains(slovo))
                                                                {
                                                                    throw new Exception("ID ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            foreach (char slovo in slova)
                                                            {
                                                                if (id.Contains(slovo))
                                                                {
                                                                    throw new Exception("ID ne smije sadrzavati slovo");
                                                                }
                                                            }
                                                            bool postoji = false;
                                                            foreach (ClanProjekta cp in des.Clanovi)
                                                            {
                                                                if (cp.ID == id)
                                                                {
                                                                    postoji = true;
                                                                    break;
                                                                }
                                                            }
                                                            if (postoji == true)
                                                            {
                                                                throw new Exception("Clan s tim ID-em vec postoji");
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception enaziv)
                                                        {
                                                            Console.WriteLine(enaziv.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Unesite ime: ");
                                                            ime = Console.ReadLine();
                                                            if (ime.Length == 0)
                                                            {
                                                                throw new Exception("Ime ne moze biti prazno");
                                                            }
                                                            foreach (char slovo in brojeiv)
                                                            {
                                                                if (ime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Ime ne moze sadrzavati brojeve");
                                                                }
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (ime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception i)
                                                        {

                                                            Console.WriteLine(i.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Unesite prezime: ");
                                                            prezime = Console.ReadLine();
                                                            if (prezime.Length == 0)
                                                            {
                                                                throw new Exception("Prezime ne moze biti prazno");
                                                            }
                                                            foreach (char slovo in brojeiv)
                                                            {
                                                                if (prezime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Prezime ne moze sadrzavati brojeve");
                                                                }
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (prezime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception ep)
                                                        {

                                                            Console.WriteLine(ep.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Molimo upišite oib");
                                                            oib = Console.ReadLine();
                                                            if (oib.Length != 11)
                                                            {
                                                                throw new Exception("Pogresan unos OIBA");
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (oib.Contains(slovo))
                                                                {
                                                                    throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            foreach (char slovo in slova)
                                                            {
                                                                if (oib.Contains(slovo))
                                                                {
                                                                    throw new Exception("OIB ne moze sadrzavati slova");
                                                                }
                                                            }
                                                            foreach (Projekt pi in des.Projekti)
                                                            {
                                                                foreach (ClanProjekta cp in pi.ClanProjekta)
                                                                {
                                                                    foreach (ClanProjekta vodi in pi.ListaVoditelja)
                                                                    {
                                                                        if (cp.OIB == vodi.OIB)
                                                                        {
                                                                            throw new Exception("Postoji osoba sa istim oibom");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception oi)
                                                        {

                                                            Console.WriteLine(oi.Message);
                                                        }
                                                    } while (true);

                                                    ClanProjekta cp1 = new ClanProjekta();
                                                    cp1.ID = id;
                                                    cp1.Ime = ime;
                                                    cp1.Prezime = prezime;
                                                    cp1.OIB = oib;
                                                    cp1.Voditelj = voditelj;
                                                    des.Clanovi.Add(cp1);
                                                    ap1.ClanoviProjekta.Add(cp1);
                                                    Console.WriteLine("Clan je uspjesno dodan");
                                                    VUV.Serijalizacija(des);
                                                    break;

                                                case 1:
                                                    voditelj = true;
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Dodajte voditelja");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Unesite ID: ");
                                                            id = Console.ReadLine();
                                                            if (id.Length == 0)
                                                            {
                                                                throw new Exception("ID je prazan");
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (id.Contains(slovo))
                                                                {
                                                                    throw new Exception("ID ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            foreach (char slovo in slova)
                                                            {
                                                                if (id.Contains(slovo))
                                                                {
                                                                    throw new Exception("ID ne smije sadrzavati slovo");
                                                                }
                                                            }
                                                            bool postoji = false;
                                                            foreach (ClanProjekta cp in des.Clanovi)
                                                            {
                                                                if (cp.ID == id)
                                                                {
                                                                    postoji = true;
                                                                    break;
                                                                }
                                                            }
                                                            if (postoji == true)
                                                            {
                                                                throw new Exception("Voditelj s tim ID-em vec postoji");
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception enaziv)
                                                        {
                                                            Console.WriteLine(enaziv.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Unesite ime: ");
                                                            ime = Console.ReadLine();
                                                            if (ime.Length == 0)
                                                            {
                                                                throw new Exception("Ime ne moze biti prazno");
                                                            }
                                                            foreach (char slovo in brojeiv)
                                                            {
                                                                if (ime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Ime ne moze sadrzavati brojeve");
                                                                }
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (ime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Ime ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception i)
                                                        {

                                                            Console.WriteLine(i.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Unesite prezime: ");
                                                            prezime = Console.ReadLine();
                                                            if (prezime.Length == 0)
                                                            {
                                                                throw new Exception("Prezime ne moze biti prazno");
                                                            }
                                                            foreach (char slovo in brojeiv)
                                                            {
                                                                if (prezime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Prezime ne moze sadrzavati brojeve");
                                                                }
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (prezime.Contains(slovo))
                                                                {
                                                                    throw new Exception("Prezime ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception ep)
                                                        {

                                                            Console.WriteLine(ep.Message);
                                                        }
                                                    } while (true);
                                                    do
                                                    {
                                                        try
                                                        {
                                                            Console.WriteLine("Molimo upišite oib");
                                                            oib = Console.ReadLine();
                                                            if (oib.Length != 11)
                                                            {
                                                                throw new Exception("Pogresan unos OIBA");
                                                            }
                                                            foreach (char slovo in znakovi)
                                                            {
                                                                if (oib.Contains(slovo))
                                                                {
                                                                    throw new Exception("OIB ne moze sadrzavati specijalna slova");
                                                                }
                                                            }
                                                            foreach (char slovo in slova)
                                                            {
                                                                if (oib.Contains(slovo))
                                                                {
                                                                    throw new Exception("OIB ne moze sadrzavati slova");
                                                                }
                                                            }
                                                            foreach (Projekt pi in des.Projekti)
                                                            {
                                                                foreach (ClanProjekta cp in pi.ClanProjekta)
                                                                {
                                                                    foreach (ClanProjekta vodi in pi.ListaVoditelja)
                                                                    {
                                                                        if (cp.OIB == vodi.OIB)
                                                                        {
                                                                            throw new Exception("Postoji osoba sa istim oibom");
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        }
                                                        catch (Exception oi)
                                                        {
                                                            Console.WriteLine(oi.Message);
                                                        }
                                                    } while (true);
                                                    ClanProjekta cp2 = new ClanProjekta();
                                                    cp2.ID = id;
                                                    cp2.Ime = ime;
                                                    cp2.Prezime = prezime;
                                                    cp2.OIB = oib;
                                                    cp2.Voditelj = voditelj;
                                                    des.Clanovi.Add(cp2);
                                                    ap1.ClanoviProjekta.Add(cp2);
                                                    Console.WriteLine("Voditelj je uspjesno dodan");
                                                    VUV.Serijalizacija(des);
                                                    break;
                                            }
                                        }

                                    }
                                    if (jedobro == true)
                                    {
                                        throw new Exception("Aktivnost s tim ID-em ne postoji");
                                    }
                                    break;
                                }
                                catch (Exception pdodavanje)
                                {
                                    Console.WriteLine(pdodavanje.Message);
                                }
                            } while (true);
                        }
                    }
                    break;
            }
            VUV.Serijalizacija(des);
            Meni();
        }
    }
}

