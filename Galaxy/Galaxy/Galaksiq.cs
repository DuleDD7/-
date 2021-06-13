using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Galaksiq : LGalaxy
    {
       public string name;
        public  GalaxyType type;
        public string age;

        public Galaksiq() { }
        public Galaksiq(string name, GalaxyType type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public GalaxyType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

       

    }
}

