using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Head : Armour
    {
        public Head(string name, int physical, int strike, int slash, int thrust, int magic, int fire, int lightning, int dark)
        {
            this.name = name;
            this.physical = physical;
            this.strike = strike;
            this.slash = slash;
            this.thrust = thrust;
            this.magic = magic;
            this.fire = fire;
            this.lightning = lightning;
            this.dark = dark;
        }
    }
}
