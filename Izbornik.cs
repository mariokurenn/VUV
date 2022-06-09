using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace VUV_Projekti
{
    class Izbornik
    {


        private int OdabraniIndex;
        private string[] Opcije;
        private string Prompt;
        
        public Izbornik(string prompt, string[] opcije)
        {
            this.Prompt = prompt;
            this.Opcije = opcije;
            OdabraniIndex = 0;
        }
        
        public static void DodajProjekt()
        {
            string xml = "";
            StreamReader sr = new StreamReader(@"C:\Users\Korisnik\Desktop\VUV_Projekti\ClanProjekta.xml");
            using (sr)
            {
                xml = sr.ReadToEnd();
            }

            XmlDocument xmlObject = new XmlDocument();
            xmlObject.LoadXml(xml);
            XmlNodeList projekti = xmlObject.SelectNodes("//vuv/projekti/projekt");
        }
        private void PokaziIzbornik()
        {

            Console.ForegroundColor= ConsoleColor.Red;

            string a = @"
                 __     ___   ___     __  ____  ____   ___      _ _____ _  _______ ___ 
                 \ \   / / | | \ \   / / |  _ \|  _ \ / _ \    | | ____| |/ /_   _|_ _|
                  \ \ / /| | | |\ \ / /  | |_) | |_) | | | |_  | |  _| | ' /  | |  | | 
                   \ V / | |_| | \ V /   |  __/|  _ <| |_| | |_| | |___| . \  | |  | | 
                    \_/   \___/   \_/    |_|   |_| \_\\___/ \___/|_____|_|\_\ |_| |___|
                                                                       
";
            Console.WriteLine(a ,"{0}", Console.ForegroundColor);
            Console.WriteLine("");
            Console.WriteLine(Prompt, "{0}", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("");
            for (int i = 0; i< Opcije.Length; i++)
            {
                string trenutnaOpcija = Opcije[i];
                string prefix;
                if(i == OdabraniIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    prefix =  " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}|{trenutnaOpcija}|");
            }
            Console.ResetColor();
        }
        public int Pokreni()
        {
            ConsoleKey odabranigumb;
            do
            {
                Console.Clear();
                PokaziIzbornik();
                ConsoleKeyInfo info = Console.ReadKey(true);
                odabranigumb = info.Key;
                
                if (odabranigumb == ConsoleKey.UpArrow)
                {
                    OdabraniIndex--;
                    if(OdabraniIndex == -1)
                    {
                        OdabraniIndex = Opcije.Length - 1;
                    }
                }
                else if (odabranigumb == ConsoleKey.DownArrow)
                {
                    OdabraniIndex++;
                    if(OdabraniIndex == Opcije.Length)
                    {
                        OdabraniIndex = 0;
                    }
                }

                if(odabranigumb != ConsoleKey.Enter && odabranigumb != ConsoleKey.UpArrow && odabranigumb != ConsoleKey.DownArrow)
                {
                    Console.Beep();
                }
            }
            while (odabranigumb != ConsoleKey.Enter);
            return OdabraniIndex;
        }
        
    }
}
