using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class RingByPercentage : Ring
    {
        public RingByPercentage(string name, double WGT, int vigorMod = 0, int attunementMod = 0, int vitalityMod = 0, int enduranceMod = 0, int strengthMod = 0, int dexterityMod = 0, int intelligenceMod = 0, int faithMod = 0, int luckMod = 0,
           int physicalMod = 0, int strikeMod = 0, int slashMod = 0, int thrustMod = 0, int magicMod = 0, int fireMod = 0, int lightningMod = 0, int darkMod = 0, int hpMod = 0, int fpMod = 0, int staminaMod = 0, double equiploadMod = 0)
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
            this.equiploadMod = equiploadMod;

        }

        public override int vigorBonus()
        {
            return 0;
        }

        public override int attunementBonus()
        {
            return 0;
        }

        public override int enduranceBonus()
        {
            return 0;
        }

        public override int vitalityBonus()
        {
            return 0;
        }

        public override int strengthBonus()
        {
            return 0;
        }

        public override int dexterityBonus()
        {
            return 0;
        }

        public override int intelligenceBonus()
        {
            return 0;
        }

        public override int faithBonus()
        {
            return 0;
        }

        public override int luckBonus()
        {
            return 0;
        }

        public override int physicalBonus()
        {
            return 0;
        }

        public override int strikeBonus()
        {
            return 0;
        }

        public override int slashBonus()
        {
            return 0;
        }

        public override int thrustBonus()
        {
            return 0;
        }

        public override int magicBonus()
        {
            return 0;
        }

        public override int fireBonus()
        {
            return 0;
        }

        public override int lightningBonus()
        {
            return 0;
        }

        public override int darkBonus()
        {
            return 0;
        }

        public override int hpBonus( int hp )
        {
            double calc;

            calc = hpMod / 100.0;

            calc = hp * calc;

            int tmp = Convert.ToInt32(calc);

            return tmp;
        }

        public override int fpBonus( int fp )
        {
            double calc;

            calc = fpMod / 100.0;

            calc = fp * calc;

            int tmp = Convert.ToInt32(calc);

            return tmp;
        }

        public override int staminaBonus( int st )
        {
            double calc;
            calc = staminaMod / 100.0;
            calc = st * calc;
            int tmp = Convert.ToInt32(calc);
            return tmp;
        }

        public override double equiploadBonus( double eq )
        {
            double calc;

            calc = equiploadMod / 100.0;

            calc = eq * calc;

            return calc;
        }

    }
}
