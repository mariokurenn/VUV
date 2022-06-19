using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using BetterConsoleTables;
namespace VUV_Projekti
{


    class Program
    {
        public static void IzlazIzPrograma()
        {
            string prompt = "Jeste li sigurni da zelite napustiti program?";
            string[] opcije = { "Da", "Ne" };
            Izbornik izlaz = new Izbornik(prompt, opcije);
            int OdabraniIndex = izlaz.Pokreni();

            switch (OdabraniIndex)
            {
                case 0:
                    Environment.Exit(0);

                    break;
                case 1:
                    string ispis = "Vracanje u glavni izbornik.......";
                    Console.Clear();
                    Console.WriteLine(ispis, "{0}", Console.ForegroundColor = ConsoleColor.Red);
                    Thread.Sleep(500);
                    Console.Clear();
                    PokreniIzbornik();
                    break;
            }
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        public static void Administracija()
        {
            string prompt = "Odaberite neke od stvari sa menija";
            string[] opcije = { "1. Ispisi listu projekata", "2. Kreiranje projekta", "3. Azuriranje projekata", "4. Lista aktivnosti", "4.1. Ispis aktivnosti iz projekta",
                "5. Dodavanje aktivnosti", "6. Lista clanova projekta", "7. Dodavnaje clana", "8. Brisanje clana", "9. Dodaj Lokaciju", "10. Ispis svih Lokacija","11. Resetiraj podatke"};
            Izbornik izlaz = new Izbornik(prompt, opcije);
            int OdabraniIndex = izlaz.Pokreni();
            switch (OdabraniIndex)
            {
                case 0:
                    VUV.IspisListeProjekata();
                    break;
                case 1:
                    VUV.KreirajProjekt();
                    break;
                case 2:
                    VUV.AzurirajProjekt2();
                    break;
                case 3:
                    VUV.IspisSvihAktivnosti();
                    break;
                case 4:
                    VUV.IspisAktivnostiProjekta();
                    break;

                case 5:
                    VUV.DodajAktivnost();
                    break;
                case 6:
                    VUV.ListaClanova2();
                    break;
                case 7:
                    VUV.DodavanjeClana2();
                    break;

                case 8:
                    VUV.BrisanjeClana();
                    break;
    
                case 9:
                    VUV.KreirajLokaciju();
                    break;
                case 10:
                    VUV.IspisLokacija();
                    break;
                case 11:
                    VUV.ResetirajPodatke();
                    break;
            }
            Console.ReadKey(true);
            Environment.Exit(0);
        }
        public static void Pokreni()
        {

            Administracija();
            PokreniIzbornik();

        }
        public static void Exit()
        {
            string prompt = "";
            string[] opcije = { "Nazad" };
            Izbornik izlaz = new Izbornik(prompt, opcije);
            int OdabraniIndex = izlaz.Pokreni();
            switch (OdabraniIndex)
            {
                case 0:
                    Administracija();
                    break;
            }
        }
        public static void PokreniIzbornik()
        {

            string prompt = "Za kretanje kroz izbornik koristite strijelice gore ili dolje ovisno o odabiru, a za odabir opcije korisite Enter";
            string[] opcije = { "Pokreni", "Izlaz" };
            Izbornik i1 = new Izbornik(prompt, opcije);
            int OdabraniIndex = i1.Pokreni();
            switch (OdabraniIndex)
            {
                case 0:
                    Pokreni();
             
                    break;
                case 1:

                    break;
                case 2:
                    IzlazIzPrograma();
                    break;
            }
        }
      
            static void Main(string[] args)
            {
                Console.Title = "VUV Projekti";
                Console.SetCursorPosition(0, 0);
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"




                                                    ╔════╤╤╤╤════╗    
                                                    ║    │││ \   ║    
                                                    ║    │││  O  ║    
                                                    ║    OOO     ║

                                                  Ucitavnaje programa...");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(@"




                                                    ╔════╤╤╤╤════╗    
                                                    ║    ││││    ║    
                                                    ║    ││││    ║ 
                                                    ║    OOOO    ║

                                                  Ucitavnaje programa...");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(@"




                                                    ╔════╤╤╤╤════╗    
                                                    ║   / │││    ║    
                                                    ║  O  │││    ║  
                                                    ║     OOO    ║

                                                  Ucitavnaje programa...");
                Thread.Sleep(100);
                Console.Clear();
                Console.WriteLine(@"




                                                    ╔════╤╤╤╤════╗
                                                    ║    ││││    ║ 
                                                    ║    ││││    ║
                                                    ║    OOOO    ║
                
                                                  Ucitavnaje programa...");
                Thread.Sleep(100);
                Console.Clear();
                Console.ResetColor();
            }
            PokreniIzbornik();
            }
        }
    }

