using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace VUV_Projekti
{
    public class ClanProjekta : Osoba, IValidate
    {
        public Projekt Projekt;

        [XmlAttribute]

        public bool Voditelj
        {
            get { return _voditelj; }


            set
            {
            
                
                    _voditelj = value;
                
            }
        }


        private bool _voditelj;

        [XmlAttribute]
        public bool Deleted {
            
          get { return _deleted; }
          set
              {

                _deleted = value;
                }


            }

        private bool _deleted;
        public bool Validate()
        {
            if (this.ID.Length == 0)
            {
                Console.WriteLine("ID ne smije biti prazan");
                return false;
            }
            if (this.Ime.Length == 0)
            {
                Console.WriteLine("Ime ne smije biti prazno");
                return false;
            }
            return true;
        }
    }
}
