using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    abstract class Ring
    {
        private string _name;
        private double _WGT;

        private int _vigorMod;
        private int _attunementMod;
        private int _enduranceMod;
        private int _vitalityMod;
        private int _strengthMod;
        private int _dexterityMod;
        private int _intelligenceMod;
        private int _faithMod;
        private int _luckMod;
        private int _physicalMod;
        private int _strikeMod;
        private int _slashMod;
        private int _thrustMod;
        private int _magicMod;
        private int _fireMod;
        private int _lightningMod;
        private int _darkMod;
        private int _hpMod;
        private int _fpMod;
        private int _staminaMod;
        private int _equiploadMod;

        public string name { get; protected set; }
        public double WGT { get; protected set; }

        public int vigorMod { get; protected set; }
        public int attunementMod { get; protected set; }
        public int vitalityMod { get; protected set; }
        public int enduranceMod { get; protected set; }
        public int strengthMod { get; protected set; }
        public int dexterityMod { get; protected set; }
        public int intelligenceMod { get; protected set; }
        public int faithMod { get; protected set; }
        public int luckMod { get; protected set; }
        public int physicalMod { get; protected set; }
        public int strikeMod { get; protected set; }
        public int slashMod { get; protected set; }
        public int thrustMod { get; protected set; }
        public int magicMod { get; protected set; }
        public int fireMod { get; protected set; }
        public int lightningMod { get; protected set; }
        public int darkMod { get; protected set; }
        public int hpMod { get; protected set; }
        public int fpMod { get; protected set; }
        public int staminaMod { get; protected set; }
        public double equiploadMod { get; protected set; }

       /* public Ring(string name, double WGT, int vigorMod = 0, int attunementMod = 0, int vitalityMod = 0, int enduranceMod = 0, int strengthMod = 0, int dexterityMod = 0, int intelligenceMod = 0, int faithMod = 0, int luckMod = 0,
           int physicalMod = 0, int strikeMod = 0, int slashMod = 0, int thrustMod = 0, int magicMod = 0, int fireMod = 0, int lightningMod = 0, int darkMod = 0, int hpMod = 0, int fpMod = 0, int staminaMod = 0)
        {
            this.name = name;
            this.WGT = WGT;
            this.vigorMod = vigorMod;
            this.attunementMod = attunementMod;
            this.enduranceMod = enduranceMod;
            this.vitalityMod = vitalityMod;
            this.strengthMod = strengthMod;
            this.dexterityMod = dexterityMod;
            this.intelligenceMod = intelligenceMod;
            this.faithMod = faithMod;
            this.luckMod = luckMod;
            this.physicalMod = physicalMod;
            this.strikeMod = strikeMod;
            this.slashMod = slashMod;
            this.thrustMod = thrustMod;
            this.magicMod = magicMod;
            this.fireMod = fireMod;
            this.lightningMod = lightningMod;
            this.darkMod = darkMod;
            this.hpMod = hpMod;
            this.fpMod = fpMod;
            this.staminaMod = staminaMod;

        }*/

        public virtual int vigorBonus()
        {
            return 0;
        }

        public virtual int attunementBonus()
        {
            return 0;
        }

        public virtual int enduranceBonus()
        {
            return 0;
        }

        public virtual int vitalityBonus()
        {
            return 0;
        }

        public virtual int strengthBonus()
        {
            return 0;
        }

        public virtual int dexterityBonus()
        {
            return 0;
        }

        public virtual int intelligenceBonus()
        {
            return 0;
        }

        public virtual int faithBonus()
        {
            return 0;
        }

        public virtual int luckBonus()
        {
            return 0;
        }

        public virtual int physicalBonus()
        {
            return 0;
        }

        public virtual int strikeBonus()
        {
            return 0;
        }

        public virtual int slashBonus()
        {
            return 0;
        }

        public virtual int thrustBonus()
        {
            return 0;
        }

        public virtual int magicBonus()
        {
            return 0;
        }
        
        public virtual int fireBonus()
        {
            return 0;
        }

        public virtual int lightningBonus()
        {
            return 0;
        }

        public virtual int darkBonus()
        {
            return 0;
        }

        public virtual int hpBonus()
        {
            return 0;
        }

        public virtual int hpBonus( int hp )
        {
            return 0;
        }

        public virtual int fpBonus()
        {
            return 0;
        }

        public virtual int fpBonus( int fp )
        {
            return 0;
        }

        public virtual int staminaBonus()
        {
            return 0;
        }

        public virtual int staminaBonus( int st )
        {
            return 0;
        }

        public virtual double equiploadBonus()
        {
            return 0;
        }

        public virtual double equiploadBonus( double eq )
        {
            return 0;
        }

    }
}
