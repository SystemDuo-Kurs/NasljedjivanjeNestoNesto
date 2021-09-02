using System;
using System.Collections.Generic;

namespace NasljedjivanjeNestoNesto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new();
            osobe.Add(new Student { Ime = "Pera", Prezime = "Peric" });
            osobe.Add(new Ucenik { Ime = "Bla", Prezime = "Bla", Knjizica="XVI124" });
            osobe.Add(new Radnik { Ime = "Neko", Prezime = "Nekic" });

            foreach(Osoba o in osobe)
            {
               // if (o is Ucenik)
                //{
                 //   Console.WriteLine("Ucenik je :)");  
                //}
                o.PredstaviSe();
            }
        }
    }

    abstract class Osoba
    {
        public string Ime;
        public string Prezime;
        public abstract void PredstaviSe();
        
    }

    class Ucenik : Osoba
    {
        public string Knjizica;

        public override void PredstaviSe()
        {
            Console.WriteLine($"Ja sam {Ime} {Prezime}, broj knji mi je {Knjizica}");
        }
    }
    class Student : Osoba
    {
        public string Indeks;

        public override void PredstaviSe()
        {
            Console.WriteLine("Student ovde :)");
        }
    }
    class Radnik : Osoba
    {
        public decimal Plata;
        public override void PredstaviSe()
        {
            Console.WriteLine("Radnik ovde :)");
        }
    }
}
