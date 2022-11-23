using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Příklad_2
{
    class Clovek
    {
        string jmeno;
        DateTime narozen;
        DateTime Ted = DateTime.Now;
        int vek;
        public Clovek(string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }
        public void NastavJmeno(string jmeno)
        {
            this.jmeno = jmeno;
        }

        public string VypisJmeno()
        {
            return jmeno;
        }

        public int Vek()
        {
            TimeSpan vek = narozen - Ted;
            return vek;
        }

        public bool Plnolety()
        {
            if(vek >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
