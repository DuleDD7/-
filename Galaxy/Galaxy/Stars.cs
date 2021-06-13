using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy
{
    class Stars : LGalaxy
    {
        public string galaxyName;
        public string name;
        public ClassStars type;
        public decimal age;
        public decimal mass;
        public decimal size;
        public int temp;
        public decimal luminosity;

        public Stars() { }
        public Stars(Galaksiq galaxy, string name, decimal mass, decimal size, int temp, decimal luminosity)
        {
            this.galaxyName = galaxy.Name;
            this.name = name;
            this.mass = mass;
            this.size = size;
            this.temp = temp;
            this.luminosity = luminosity;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public ClassStars Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public decimal Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public decimal Mass
        {
            get { return this.mass; }
            set { this.mass = value; }
        }
        public decimal Size
        {
            get { return this.size; }
            set { this.size = value; }
        }
        public int Temp
        {
            get { return this.temp; }
            set { this.temp = value; }
        }
        public decimal Luminosity
        {
            get { return this.luminosity; }
            set { this.luminosity = value; }
        }
    }
}
