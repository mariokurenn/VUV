using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml;
using ConsoleTables;
using System.Xml.Serialization;

namespace VUV_Projekti.Renta75
{
    [XmlRootAttribute("VUV", IsNullable = false)]
    class VUV
    {
        [XmlArrayAttribute("Projekti")]
        public List<Projekt> projekts = new List<Projekt>();
        [XmlArrayAttribute("ClanoviProjekta")]
        public List<ClanProjekta> clanProjektas = new List<ClanProjekta>();


        public static void SeedData()
        {
            

        }


    }
}
