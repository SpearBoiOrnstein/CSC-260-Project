using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Character
    {
        private int _soulLevelModifier;
        private int _vigorModifier;
        private int _attunementModifier;
        private int _attuneSlotModifier;
        private int _enduranceModifier;
        private int _vitalityModifier;
        private int _strengthModifier;
        private int _dexterityModifier;
        private int _intelligenceModifier;
        private int _faithModifier;
        private int _luckModifier;

        public int soulLevelModifier { get; set; }
        public int vigorModifier { get; set; }
        public int attunementModifier { get; set; }
        public int attuneSlotModifier { get; set; }
        public int vitalityModifier { get; set; }
        public int enduranceModifier { get; set; }
        public int strengthModifier { get; set; }
        public int dexterityModifier { get; set; }
        public int intelligenceModifier { get; set; }
        public int faithModifier { get; set; }
        public int luckModifier { get; set; }
 
        public Character()
        {
            this.soulLevelModifier = 0;
            this.vigorModifier = 0;
            this.attunementModifier = 0;
            this.attuneSlotModifier = 0;
            this.enduranceModifier = 0;
            this.vitalityModifier = 0;
            this.strengthModifier = 0;
            this.dexterityModifier = 0;
            this.intelligenceModifier = 0;
            this.faithModifier = 0;
            this.luckModifier = 0;
        }

    }
}
