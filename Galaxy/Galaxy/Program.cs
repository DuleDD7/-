using Galaxy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Galaxy

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Galaksiq> galaxies = new List<Galaksiq>();
            List<Stars> stars = new List<Stars>();
            List<Planets> planets = new List<Planets>();
            List<Moon> moons = new List<Moon>();
            Galaksiq g = new Galaksiq();
            Stars s = new Stars();
            Planets p = new Planets();
            Moon m = new Moon();
            while (true) 
            {
                string line = Console.ReadLine();
                string[] input = line.Split(" ");
                if (input[0] == "add")
                {
                    if (input[1] == "galaxy")
                    {
                        Enum.TryParse(input[4], out GalaxyType galaxyType);
                        g = new Galaksiq(input[2].Substring(1, input[2].Length-1) + " " + input[3].Substring(0, input[3].Length - 1), galaxyType, input[5]);
                        galaxies.Add(g);
                    }
                    else if (input[1] == "star")
                    {
                        s = new Stars(g, input[4].Substring(1, input[4].Length - 2), Convert.ToDecimal(input[5]), Convert.ToDecimal(input[6]), Convert.ToInt32(input[7]), Convert.ToDecimal(input[8]));
                        stars.Add(s);
                    }
                    else if (input[1] == "planet")
                    {
                        bool _habitable;
                        Enum.TryParse(input[4], out PlanetType planetType);
                        if (input[5] == "yes")
                            _habitable = true;
                        else
                            _habitable = false;
                        p = new Planets(s, input[3].Substring(1, input[3].Length - 2), planetType, _habitable);
                        planets.Add(p);
                    }
                    else
                    {
                        m = new Moon(p, input[3].Substring(1, input[3].Length-2));
                        moons.Add(m);
                    }
                }

                if (line == "stats") {
                    Console.WriteLine("--- Stats ---");
                    Console.WriteLine("Galaxies: " + galaxies.Count());
                    Console.WriteLine("Stars: " + stars.Count());
                    Console.WriteLine("Planets: " + planets.Count());
                    Console.WriteLine("Moons: " + moons.Count());
                    Console.WriteLine("--- End of stats ---");
                }

                if(line == "list galaxies")
                {
                    Console.WriteLine("--- List of all researched galaxies ---");
                    foreach(var galaxy in galaxies)
                    {
                        Console.WriteLine(galaxy.Name);
                    }
                    
                    Console.WriteLine("--- End of galaxies list ---");
                }
                if (input[0] == "print")
                {
                    string inputName = input[1].Substring(1, input[1].Length-1) + " " + input[2].Substring(0, input[2].Length - 1);
                    Console.WriteLine("--- Data for " + inputName + " galaxy ---");
                    foreach (var galaxy in galaxies)
                    {
                        if(galaxy.Name == inputName)
                        {
                            Console.WriteLine("Type: " + galaxy.Type);
                            Console.WriteLine("Age: " + galaxy.Age);
                            Console.WriteLine("Stars:");
                            foreach (var star in stars) 
                            { 
                                if(star.galaxyName == inputName)
                                {
                                    
                                    string className = GetStarClass(star.Temp);
                                    Console.WriteLine("Name: " + star.Name);
                                    Console.WriteLine("Class: " + className + "(" + star.Mass + "," + star.Size + "," + star.Temp + "," + star.Luminosity + ")");
                                }
                                Console.WriteLine("Planets:");
                                foreach (var planet in planets)
                                {
                                    if (planet.starName == star.Name)
                                    {
                                        Console.WriteLine("Name: " + planet.Name);
                                        Console.WriteLine("Type: " + planet.Type);
                                        Console.WriteLine("Support life: " + planet.Habitable);
                                    }
                                    Console.WriteLine("Moons:");
                                    foreach (var moon in moons)
                                    {
                                        if (moon.planetName == planet.Name)
                                        {
                                            Console.WriteLine(moon.Name);
                                        }
                                    }
                                }
                                
                            }
                        }
                    }
                    Console.WriteLine("--- End of data for " + inputName + " galaxy ---");

                }
                if (line == "exit")
                {
                    Environment.Exit(-1);   
                }
            }
        }

        public static string GetStarClass(int temp) {
            if (temp > 30000)
                return "O";
            else if (temp > 10000 && temp < 30000)
                return "B";
            else if (temp > 7500 && temp < 10000)
                return "A";
            else if (temp > 6000 && temp < 7500)
                return "F";
            else if (temp > 5200 && temp < 6000)
                return "G";
            else if (temp > 3700 && temp < 5200)
                return "K";
            else
                return "M";
        }

    }
}
