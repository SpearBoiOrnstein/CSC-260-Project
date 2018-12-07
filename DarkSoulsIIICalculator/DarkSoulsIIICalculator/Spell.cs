using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Spell
    {
        private string _name;
        private int _attunement;
        private int _minINT;
        private int _minFTH;

        public string name { get; private set; }

        public int attunement { get; private set; }

        public int minINT { get; private set; }

        public int minFTH { get; private set; }

        public Spell(string name, int attunement, int minINT, int minFTH)
        {
            this.name = name;
            this.attunement = attunement;
            this.minINT = minINT;
            this.minFTH = minFTH;
        }
    }
}
