using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Příklad_2
{
    class Clovek
    {
        string celeJmeno;
        DateTime narozen;
        public Clovek(string celeJmeno, DateTime narozen)
        {
            this.celeJmeno = celeJmeno;
            this.narozen = narozen;
        }

        public void Nastavjmeno(string celeJmeno)
        {
            this.celeJmeno = celeJmeno;
        }
        public string VypisJmeno()
        {
            return celeJmeno;
        }

        public int Vek()
        {
            TimeSpan vek = DateTime.Now - narozen;
            double let = (vek.TotalDays) / 365;
            return Convert.ToInt32(let);
        }
        public bool Plnolety()
        {
            if (Vek() >= 18)
            {
                return true;
            }
            else return false;
        }

        public string Starsi(Clovek clovek1, Clovek clovek2)
        {
            if (clovek1.Vek() > clovek2.Vek())
            {
                return clovek1.VypisJmeno() + " je starší než " + clovek2.VypisJmeno();
            }
            else if (clovek1.Vek() == clovek2.Vek())
            {
                return clovek1.VypisJmeno() + " a " + clovek2.VypisJmeno() + " jsou stejně staří.";
            }
            else
            {
                return clovek2.VypisJmeno() + " je starší než " + clovek1.VypisJmeno();
            }
        }

        public override string ToString()
        {
            if (this.Plnolety() == true)
            {
                return this.VypisJmeno() + " má " + this.Vek() + " a je plnoletý.";
            }
            else 
            {
                return this.VypisJmeno() + " má " + this.Vek() + " a není plnoletý.";
            }
        }
    }
}
