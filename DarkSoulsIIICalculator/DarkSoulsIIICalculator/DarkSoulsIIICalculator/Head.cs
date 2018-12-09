using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Head : Armour
    {
        public Head(string name, double WGT, double physical, double strike, double slash, double thrust, double magic, double fire, double lightning, double dark)
        {
            this.name = name;
            this.WGT = WGT;
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
