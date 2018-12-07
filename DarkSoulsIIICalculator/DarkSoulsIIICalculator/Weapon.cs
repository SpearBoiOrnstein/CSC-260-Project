using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkSoulsIIICalculator
{
    class Weapon
    {
        private string _name;
        private int _baseAttack;
        private int _minSTR;
        private int _minDEX;
        private int _minINT;
        private int _minFTH;
        private int _scaleSTR;
        private int _scaleDEX;
        private int _scaleINT;
        private int _scaleFTH;
        private char _rateSTR;
        private char _rateDEX;
        private char _rateINT;
        private char _rateFTH;
        private int _WGT;
        private int _STB;
        private int _DUR;

        public string name { get; private set; }
        public int baseAttack { get; private set; }
        public int minSTR { get; private set; }
        public int minDEX { get; private set; }
        public int minINT { get; private set; }
        public int minFTH { get; private set; }
        public int scaleSTR { get; private set; }
        public int scaleDEX { get; private set; }
        public int scaleINT { get; private set; }
        public int scaleFTH { get; private set; }
        public char rateSTR { get; private set; }
        public char rateDEX { get; private set; }
        public char rateINT { get; private set; }
        public char rateFTH { get; private set; }
        public int WGT { get; private set; }
        public int STB { get; private set; }
        public int DUR { get; private set; }

        public Weapon( string name, int baseAttack, int WGT, int STB, int DUR, int minSTR = 0, int minDEX = 0, int minINT = 0, int minFTH = 0, int scaleSTR = 0, int scaleDEX = 0, int scaleINT = 0, int scaleFTH = 0, char rateSTR = 'F', char rateDEX = 'F', char rateINT = 'F', char rateFTH = 'F')
        {
            this.name = name;
            this.baseAttack = baseAttack;
            this.minSTR = minSTR;
            this.minDEX = minDEX;
            this.minINT = minINT;
            this.minFTH = minFTH;
            this.scaleSTR = scaleSTR;
            this.scaleDEX = scaleDEX;
            this.scaleINT = scaleINT;
            this.scaleFTH = scaleFTH;
            this.rateSTR = rateSTR;
            this.rateDEX = rateDEX;
            this.rateINT = rateINT;
            this.rateFTH = rateFTH;
            this.WGT = WGT;
            this.STB = STB;
            this.DUR = DUR;
        }

        int weaponAR( int STR, int DEX, int INT, int FTH )
        {
            return 0;
        }
    }
}
