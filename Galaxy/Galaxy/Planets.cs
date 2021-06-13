using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Planets : LGalaxy
    {
        public string starName;
        public string name;
        public PlanetType type;
        public bool habitable;

        public Planets() { }
        public Planets(Stars s, string name, PlanetType type, bool habitable)
        {
            this.starName = s.Name;
            this.name = name;
            this.type = type;
            this.habitable = habitable;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public PlanetType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public bool Habitable
        {
            get { return this.habitable; }
            set { this.habitable = value; }
        }
    }
}
