using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class StartingClass
    {
        private string _name;
        private int _soulLevelBase;
        private int _vigorBase;
        private int _attunementBase;
        private int _enduranceBase;
        private int _vitalityBase;
        private int _strengthBase;
        private int _dexterityBase;
        private int _intelligenceBase;
        private int _faithBase;
        private int _luckBase;

        public string name { get; private set; }
        public int soulLevelBase { get; private set; }
        public int vigorBase { get; private set; }
        public int attunementBase { get; private set; }
        public int vitalityBase { get; private set; }
        public int enduranceBase { get; private set; }
        public int strengthBase { get; private set; }
        public int dexterityBase { get; private set; }
        public int intelligenceBase { get; private set; }
        public int faithBase { get; private set; }
        public int luckBase { get; private set; }

        public StartingClass( string name, int soulLevelBase, int vigorBase, int attunementBase, int enduranceBase, int vitalityBase, int strengthBase, int dexterityBase, int intelligenceBase, int faithBase, int luckBase)
        {
            this.name = name;
            this.soulLevelBase = soulLevelBase;
            this.vigorBase = vigorBase;
            this.attunementBase = attunementBase;
            this.enduranceBase = enduranceBase;
            this.vitalityBase = vitalityBase;
            this.strengthBase = strengthBase;
            this.dexterityBase = dexterityBase;
            this.intelligenceBase = intelligenceBase;
            this.faithBase = faithBase;
            this.luckBase = luckBase;
        }

        public StartingClass()
        {
            this.name = "Something Broke";
            this.soulLevelBase = 0;
            this.vigorBase = 0;
            this.attunementBase = 0;
            this.enduranceBase = 0;
            this.vitalityBase = 0;
            this.strengthBase = 0;
            this.dexterityBase = 0;
            this.intelligenceBase = 0;
            this.faithBase = 0;
            this.luckBase = 0;
        }

    }
}
