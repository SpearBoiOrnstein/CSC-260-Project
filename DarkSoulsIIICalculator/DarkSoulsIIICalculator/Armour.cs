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
        private int _physical;
        private int _strike;
        private int _slash;
        private int _thrust;
        private int _magic;
        private int _fire;
        private int _lightning;
        private int _dark;

        public string name { get; protected set; }
        public int physical { get; protected set; }
        public int strike { get; protected set; }
        public int slash { get; protected set; }
        public int thrust { get; protected set; }
        public int magic { get; protected set; }
        public int fire { get; protected set; }
        public int lightning { get; protected set; }
        public int dark { get; protected set; }
    }
}
