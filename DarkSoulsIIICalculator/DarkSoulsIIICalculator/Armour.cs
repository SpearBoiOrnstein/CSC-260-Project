using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    abstract class Armour
    {
        private string _name;
        private double _WGT;
        private double _physical;
        private double _strike;
        private double _slash;
        private double _thrust;
        private double _magic;
        private double _fire;
        private double _lightning;
        private double _dark;

        public string name { get; protected set; }
        public double WGT { get; protected set; }
        public double physical { get; protected set; }
        public double strike { get; protected set; }
        public double slash { get; protected set; }
        public double thrust { get; protected set; }
        public double magic { get; protected set; }
        public double fire { get; protected set; }
        public double lightning { get; protected set; }
        public double dark { get; protected set; }
    }
}
