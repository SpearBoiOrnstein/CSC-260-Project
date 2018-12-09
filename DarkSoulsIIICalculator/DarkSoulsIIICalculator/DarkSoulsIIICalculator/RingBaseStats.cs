using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class RingBaseStats : Ring
    {
        public RingBaseStats(string name, double WGT, int vigorMod = 0, int attunementMod = 0, int vitalityMod = 0, int enduranceMod = 0, int strengthMod = 0, int dexterityMod = 0, int intelligenceMod = 0, int faithMod = 0, int luckMod = 0,
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
            return vigorMod;
        }

        public override int attunementBonus()
        {
            return attunementMod;
        }

        public override int enduranceBonus()
        {
            return enduranceMod;
        }

        public override int vitalityBonus()
        {
            return vitalityMod;
        }

        public override int strengthBonus()
        {
            return strengthMod;
        }

        public override int dexterityBonus()
        {
            return dexterityMod;
        }

        public override int intelligenceBonus()
        {
            return intelligenceMod;
        }

        public override int faithBonus()
        {
            return faithMod;
        }

        public override int luckBonus()
        {
            return luckMod;
        }

        public override int physicalBonus()
        {
            return physicalMod;
        }

        public override int strikeBonus()
        {
            return strikeMod;
        }

        public override int slashBonus()
        {
            return slashMod;
        }

        public override int thrustBonus()
        {
            return thrustMod;
        }

        public override int magicBonus()
        {
            return magicMod;
        }

        public override int fireBonus()
        {
            return fireMod;
        }

        public override int lightningBonus()
        {
            return lightningMod;
        }

        public override int darkBonus()
        {
            return darkMod;
        }

        public override int hpBonus()
        {
            return hpMod;
        }

        public override int hpBonus( int hp )
        {
            return hpMod;
        }

        public override int fpBonus()
        {
            return fpMod;
        }

        public override int fpBonus( int fp )
        {
            return fpMod;
        }

        public override int staminaBonus()
        {
            return staminaMod;
        }

        public override int staminaBonus( int st )
        {
            return staminaMod;
        }

        public override double equiploadBonus()
        {
            return equiploadMod;
        }

        public override double equiploadBonus( double eq )
        {
            return equiploadMod;
        }
    }
}
