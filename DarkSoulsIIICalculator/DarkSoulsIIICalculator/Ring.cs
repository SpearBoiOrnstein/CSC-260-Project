using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Ring
    {
        private string _name;
        private int _WGT;

        private int _vigorBonus;
        private int _attunementBonus;
        private int _enduranceBonus;
        private int _vitalityBonus;
        private int _strengthBonus;
        private int _dexterityBonus;
        private int _intelligenceBonus;
        private int _faithBonus;
        private int _luckBonus;
        private int _physicalBonus;
        private int _strikeBonus;
        private int _slashBonus;
        private int _thrustBonus;
        private int _magicBonus;
        private int _fireBonus;
        private int _lightningBonus;
        private int _darkBonus;

        public string name { get; private set; }
        public int WGT { get; private set; }

        public int vigorBonus { get; private set; }
        public int attunementBonus { get; private set; }
        public int vitalityBonus { get; private set; }
        public int enduranceBonus { get; private set; }
        public int strengthBonus { get; private set; }
        public int dexterityBonus { get; private set; }
        public int intelligenceBonus { get; private set; }
        public int faithBonus { get; private set; }
        public int luckBonus { get; private set; }
        public int physicalBonus { get; private set; }
        public int strikeBonus { get; private set; }
        public int slashBonus { get; private set; }
        public int thrustBonus { get; private set; }
        public int magicBonus { get; private set; }
        public int fireBonus { get; private set; }
        public int lightningBonus { get; private set; }
        public int darkBonus{ get; private set; }

        public Ring( string name, int WGT, int vigorBonus = 0, int attunementBonus = 0, int vitalityBonus = 0, int enduranceBonus = 0, int strengthBonus = 0, int dexterityBonus = 0, int intelligenceBonus = 0, int faithBonus = 0, int luckBonus = 0,
           int physicalBonus = 0, int strikeBonus = 0, int slashBonus = 0, int thrustBonus = 0, int magicBonus = 0, int fireBonus = 0, int lightningBonus = 0, int darkBonus = 0 )
        {
            this.name = name;
            this.WGT = WGT;
            this.vigorBonus = vigorBonus;
            this.attunementBonus = attunementBonus;
            this.enduranceBonus = enduranceBonus;
            this.vitalityBonus = vitalityBonus;
            this.strengthBonus = strengthBonus;
            this.dexterityBonus = dexterityBonus;
            this.intelligenceBonus = intelligenceBonus;
            this.faithBonus = faithBonus;
            this.luckBonus = luckBonus;
            this.physicalBonus = physicalBonus;
            this.strikeBonus = strikeBonus;
            this.slashBonus = slashBonus;
            this.thrustBonus = thrustBonus;
            this.magicBonus = magicBonus;
            this.fireBonus = fireBonus;
            this.lightningBonus = lightningBonus;
            this.darkBonus = darkBonus;
        }
    }
}
