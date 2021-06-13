using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Moon : LGalaxy
    {
        public string planetName;
        public string name;
        public Moon() { }
        public Moon(Planets p,string name)
        {
            this.planetName = p.Name;
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
