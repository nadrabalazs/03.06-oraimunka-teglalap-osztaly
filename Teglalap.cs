using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglalap
{
    internal class Teglalap
    {
        double aOldal, bOldal;
        string nev;

        public Teglalap(double aOldal, double bOldal, string nev = "")
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
            this.nev = nev;
        }
        public Teglalap(string csvLine)
        {
            string[] adatok = csvLine.Split(';');
            aOldal = double.Parse(adatok[0]);
            bOldal = double.Parse(adatok[1]);
            nev = adatok[2];
        }
        public double AOldal { get => aOldal;}
        public double BOldal { get => bOldal; }
        public string Nev { get => nev; set => nev = value; }
        public void SetNev(string ujErtek)
        {
            if (ujErtek != "")
            {
                this.nev = ujErtek;
            }
            else
            {
                throw new ArgumentException("A név nem maradhat üres!");
            }
        }
        public override string ToString()
        {
            return $"a oldal:{aOldal}\t b oldal:{bOldal}\t név:{nev}";
        }
        public double Kerulet()
        {
            return (aOldal + bOldal)*2;
        }
        public double Terulet()
        {
            return aOldal * bOldal;
        }
        public double Atlo()
        {
            return Math.Sqrt(Math.Pow(aOldal,2)+Math.Pow(bOldal,2));
        }
        public bool NegyzetE()
        {
            return aOldal == bOldal;
        }
        public void oldalNovelesSzazalekkal(double szazalek)
        {
            aOldal += aOldal * szazalek / 100;
            bOldal += bOldal * szazalek / 100;
        }
        public void teruletNovelesSzazalekkal(double teruletSzazalek)
        {
            double ujTerulet = Terulet() + Terulet() * teruletSzazalek / 100;
            double arany = aOldal / bOldal;
            aOldal = arany * bOldal;
            bOldal = Math.Sqrt(ujTerulet / arany);
        }
        public void teruletFelezese()
        {
            teruletNovelesSzazalekkal(50);
        }
    }
}

