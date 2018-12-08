using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkSoulsIIICalculator
{
    public partial class Calculator : Form
    {
        Character character = new Character();

        StartingClass[] startingClasses = {
            new StartingClass("Knight", 9, 12, 10, 11, 15, 13, 12, 9, 9, 7),
            new StartingClass("Mercenary", 8, 11, 12, 11, 10, 10, 16, 10, 8, 9),
            new StartingClass("Warrior", 7, 14, 6, 12, 11, 16, 9, 8, 9, 11),
            new StartingClass("Herald", 9, 12, 10, 9, 12, 12, 11, 8, 13, 11),
            new StartingClass("Thief", 5, 10, 11, 10, 9, 9, 13, 10, 8, 14),
            new StartingClass("Assassin", 10, 10, 14, 11, 10, 10, 14, 11, 9, 10),
            new StartingClass("Sorcerer", 6, 9, 16, 9, 7, 7, 12, 16, 7, 12),
            new StartingClass("Pyromancer", 8, 11, 12, 10, 8, 12, 9, 14, 14, 7),
            new StartingClass("Cleric", 7, 10, 14, 9, 7, 12, 8, 7, 16, 13),
            new StartingClass("Deprived", 1, 10, 10, 10, 10, 10, 10, 10, 10, 10) };

        Weapon[] weapons = {
            new Weapon("none", 0, 0, 0, 0)
        };

        Head[] heads = {
            new Head("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Head("test", 6.7,11,11,11,11,11,11,11,11)
        };

        Chest[] chests = {
            new Chest("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Chest("test", 18.5,0,5,0,5,0,5,0, 0)
        };

        Arms[] arms = {
            new Arms("none", 0, 0, 0, 0, 0, 0, 0, 0, 0)
        };

        Leggings[] leggings = {
            new Leggings("none", 0, 0, 0, 0, 0, 0, 0, 0, 0)
        };

        Ring[] rings = {
            new Ring("none", 0),
            new Ring("Prisoner's Chain", 1, vigorBonus : 5, enduranceBonus : 5, vitalityBonus : 5)
        };
        

        public Calculator()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vigorlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Vigorval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            for ( int k = 0; k < startingClasses.Count(); k++ )
            {
                StartingClasscmb.Items.Add(startingClasses[k].name);
            }

            for (int k = 0; k < weapons.Count(); k++)
            {
                R1cmb.Items.Add(weapons[k].name);
                R2cmb.Items.Add(weapons[k].name);
                R3cmb.Items.Add(weapons[k].name);
                L1cmb.Items.Add(weapons[k].name);
                L2cmb.Items.Add(weapons[k].name);
                L3cmb.Items.Add(weapons[k].name);
            }

            for (int k = 0; k < heads.Count(); k++)
            {
                Headcmb.Items.Add(heads[k].name);
            }

            for (int k = 0; k < chests.Count(); k++)
            {
                Chestcmb.Items.Add(chests[k].name);
            }

            for (int k = 0; k < arms.Count(); k++)
            {
                Armscmb.Items.Add(arms[k].name);
            }

            for (int k = 0; k < leggings.Count(); k++)
            {
                Leggingscmb.Items.Add(leggings[k].name);
            }

            for ( int k = 0; k < rings.Count(); k++ )
            {
                Ring1cmb.Items.Add(rings[k].name);
                Ring2cmb.Items.Add(rings[k].name);
                Ring3cmb.Items.Add(rings[k].name);
                Ring4cmb.Items.Add(rings[k].name);
            }

            StartingClasscmb.SelectedIndex = 0; //sets initial value to knight


            //set all combo box to none
            R1cmb.SelectedIndex = 0;
            R2cmb.SelectedIndex = 0;
            R3cmb.SelectedIndex = 0;
            L1cmb.SelectedIndex = 0;
            L2cmb.SelectedIndex = 0;
            L3cmb.SelectedIndex = 0;

            Headcmb.SelectedIndex = 0;
            Chestcmb.SelectedIndex = 0;
            Armscmb.SelectedIndex = 0;
            Leggingscmb.SelectedIndex = 0;

            Ring1cmb.SelectedIndex = 0;
            Ring2cmb.SelectedIndex = 0;
            Ring3cmb.SelectedIndex = 0;
            Ring4cmb.SelectedIndex = 0;

            refresh();

        }

        private void StartingClasscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            StartingClass stclass = new StartingClass();

            if (Ring1cmb.SelectedIndex < 0)
            {
                Ring1cmb.SelectedIndex = 0;
            }
            if (Ring2cmb.SelectedIndex < 0)
            {
                Ring2cmb.SelectedIndex = 0;
            }
            if (Ring3cmb.SelectedIndex < 0)
            {
                Ring3cmb.SelectedIndex = 0;
            }
            if (Ring4cmb.SelectedIndex < 0)
            {
                Ring4cmb.SelectedIndex = 0;
            }

            if (Headcmb.SelectedIndex < 0)
            {
                Headcmb.SelectedIndex = 0;
            }
            if (Chestcmb.SelectedIndex < 0)
            {
                Chestcmb.SelectedIndex = 0;
            }
            if (Armscmb.SelectedIndex < 0)
            {
                Armscmb.SelectedIndex = 0;
            }
            if (Leggingscmb.SelectedIndex < 0)
            {
                Leggingscmb.SelectedIndex = 0;
            }


            if (R1cmb.SelectedIndex < 0)
            {
                R1cmb.SelectedIndex = 0;
            }
            if (R2cmb.SelectedIndex < 0)
            {
                R2cmb.SelectedIndex = 0;
            }
            if (R3cmb.SelectedIndex < 0)
            {
                R3cmb.SelectedIndex = 0;
            }
            if (L1cmb.SelectedIndex < 0)
            {
                L1cmb.SelectedIndex = 0;
            }
            if (L2cmb.SelectedIndex < 0)
            {
                L2cmb.SelectedIndex = 0;
            }
            if (L3cmb.SelectedIndex < 0)
            {
                L3cmb.SelectedIndex = 0;
            }

            Ring ring1 = rings[Ring1cmb.SelectedIndex];
            Ring ring2 = rings[Ring2cmb.SelectedIndex];
            Ring ring3 = rings[Ring3cmb.SelectedIndex];
            Ring ring4 = rings[Ring4cmb.SelectedIndex];



            stclass = startingClasses[StartingClasscmb.SelectedIndex]; //this sets starting class to the correct object


            //This section sets all of the level values appropriately==============================================================================

            int level, vigor, attunement, endurance, vitality, strength, dexterity, intelligence, faith, luck;

            level = stclass.soulLevelBase + character.soulLevelModifier;
            SoulLeveltxt.Text = level.ToString();

            vigor = stclass.vigorBase + character.vigorModifier + ring1.vigorBonus + ring2.vigorBonus + ring3.vigorBonus + ring4.vigorBonus;
            Vigortxt.Text = vigor.ToString();

            attunement = stclass.attunementBase + character.attunementModifier + ring1.attunementBonus + ring2.attunementBonus + ring3.attunementBonus + ring4.attunementBonus;
            Attunementtxt.Text = attunement.ToString();

            endurance = stclass.enduranceBase + character.enduranceModifier + ring1.enduranceBonus + ring2.enduranceBonus + ring3.enduranceBonus + ring4.enduranceBonus;
            Endurancetxt.Text = endurance.ToString();

            vitality = stclass.vitalityBase + character.vitalityModifier + ring1.vitalityBonus + ring2.vitalityBonus + ring3.vitalityBonus + ring4.vitalityBonus;
            Vitalitytxt.Text = vitality.ToString();

            strength = stclass.strengthBase + character.strengthModifier + ring1.strengthBonus + ring2.strengthBonus + ring3.strengthBonus + ring4.strengthBonus;
            Strengthtxt.Text = strength.ToString();

            dexterity = stclass.dexterityBase + character.dexterityModifier + ring1.dexterityBonus + ring2.dexterityBonus + ring3.dexterityBonus + ring4.dexterityBonus;
            Dexteritytxt.Text = dexterity.ToString();

            intelligence = stclass.intelligenceBase + character.intelligenceModifier + ring1.intelligenceBonus + ring2.intelligenceBonus + ring3.intelligenceBonus + ring4.intelligenceBonus;
            Intelligencetxt.Text = intelligence.ToString();

            faith = stclass.faithBase + character.faithModifier + ring1.faithBonus + ring2.faithBonus + ring3.faithBonus + ring4.faithBonus;
            Faithtxt.Text = faith.ToString();

            luck = stclass.luckBase + character.luckModifier + ring1.luckBonus + ring2.luckBonus + ring3.luckBonus + ring4.luckBonus;
            Lucktxt.Text = luck.ToString();


            //This section sets all of the defense values=======================================================
            //yes this really goofy equation is actually what the game uses

            double physical, strike, slash, thrust, magic, fire, lightning, dark;

            physical = heads[Headcmb.SelectedIndex].physical + ring1.physicalBonus + ring2.physicalBonus + ring3.physicalBonus + ring4.physicalBonus;
            physical += (100 - physical) * (chests[Chestcmb.SelectedIndex].physical / 100);
            physical += (100 - physical) * (arms[Armscmb.SelectedIndex].physical / 100);
            physical += (100 - physical) * (leggings[Leggingscmb.SelectedIndex].physical / 100);
            Physicaltxt.Text = physical.ToString();

            strike = heads[Headcmb.SelectedIndex].strike + ring1.strikeBonus + ring2.strikeBonus + ring3.strikeBonus + ring4.strikeBonus;
            strike += (100 - strike) * (chests[Chestcmb.SelectedIndex].strike / 100);
            strike += (100 - strike) * (arms[Armscmb.SelectedIndex].strike / 100);
            strike += (100 - strike) * (leggings[Leggingscmb.SelectedIndex].strike / 100);
            VSstriketxt.Text = strike.ToString();

            slash = heads[Headcmb.SelectedIndex].slash + ring1.slashBonus + ring2.slashBonus + ring3.slashBonus + ring4.slashBonus;
            slash += (100 - slash) * (chests[Chestcmb.SelectedIndex].slash / 100);
            slash += (100 - slash) * (arms[Armscmb.SelectedIndex].slash / 100);
            slash += (100 - slash) * (leggings[Leggingscmb.SelectedIndex].slash / 100);
            VSslashtxt.Text = slash.ToString();

            thrust = heads[Headcmb.SelectedIndex].thrust + ring1.thrustBonus + ring2.thrustBonus + ring3.thrustBonus + ring4.thrustBonus;
            thrust += (100 - thrust) * (chests[Chestcmb.SelectedIndex].thrust / 100);
            thrust += (100 - thrust) * (arms[Armscmb.SelectedIndex].thrust / 100);
            thrust += (100 - thrust) * (leggings[Leggingscmb.SelectedIndex].thrust / 100);
            VSthrusttxt.Text = thrust.ToString();

            magic = heads[Headcmb.SelectedIndex].magic + ring1.magicBonus + ring2.magicBonus + ring3.magicBonus + ring4.magicBonus;
            magic += (100 - magic) * (chests[Chestcmb.SelectedIndex].magic / 100);
            magic += (100 - magic) * (arms[Armscmb.SelectedIndex].magic / 100);
            magic += (100 - magic) * (leggings[Leggingscmb.SelectedIndex].magic / 100);
            Magictxt.Text = magic.ToString();

            fire = heads[Headcmb.SelectedIndex].fire + ring1.fireBonus + ring2.fireBonus + ring3.fireBonus + ring4.fireBonus;
            fire += (100 - fire) * (chests[Chestcmb.SelectedIndex].fire / 100);
            fire += (100 - fire) * (arms[Armscmb.SelectedIndex].fire / 100);
            fire += (100 - fire) * (leggings[Leggingscmb.SelectedIndex].fire / 100);
            Firetxt.Text = fire.ToString();

            lightning = heads[Headcmb.SelectedIndex].lightning + ring1.lightningBonus + ring2.lightningBonus + ring3.lightningBonus + ring4.lightningBonus;
            lightning += (100 - lightning) * (chests[Chestcmb.SelectedIndex].lightning / 100);
            lightning += (100 - lightning) * (arms[Armscmb.SelectedIndex].lightning / 100);
            lightning += (100 - lightning) * (leggings[Leggingscmb.SelectedIndex].lightning / 100);
            Lightningtxt.Text = lightning.ToString();

            dark = heads[Headcmb.SelectedIndex].dark + ring1.darkBonus + ring2.darkBonus + ring3.darkBonus + ring4.darkBonus;
            dark += (100 - dark) * (chests[Chestcmb.SelectedIndex].dark / 100);
            dark += (100 - dark) * (arms[Armscmb.SelectedIndex].dark / 100);
            dark += (100 - dark) * (leggings[Leggingscmb.SelectedIndex].dark / 100);
            Darktxt.Text = dark.ToString();


            //this section sets character stats
            double hp, fp, stamina;
            double equipLoad, equipLoadUsed, equipLoadPercent;

            if (vigor <= 50)
                hp = (-.559 * Math.Pow(vigor, 2)) + (56.547 * vigor) - 142.56;
            else
                hp = (-0.01 * Math.Pow(vigor, 2)) + (3.5805 * vigor) + 1144.9;

            HPtxt.Text = String.Format("{0:0}", hp);

            fp = (.1147 * Math.Pow(attunement, 2)) + (2.3654 * attunement) + 57.773;
            FPtxt.Text = String.Format("{0:0}", fp);

            stamina = (.019 * Math.Pow(endurance, 2)) + (1.2616 * endurance) + 78.992;
            Staminatxt.Text = String.Format("{0:0}", stamina);

            equipLoad = 40 + vitality;
            EquipLoadtxt.Text = String.Format("{0:0.0}", equipLoad);

            equipLoadUsed = weapons[R1cmb.SelectedIndex].WGT + weapons[R2cmb.SelectedIndex].WGT + weapons[R3cmb.SelectedIndex].WGT + weapons[L1cmb.SelectedIndex].WGT + weapons[L2cmb.SelectedIndex].WGT + weapons[L3cmb.SelectedIndex].WGT + rings[Ring1cmb.SelectedIndex].WGT + rings[Ring2cmb.SelectedIndex].WGT + rings[Ring3cmb.SelectedIndex].WGT + rings[Ring4cmb.SelectedIndex].WGT + heads[Headcmb.SelectedIndex].WGT + chests[Chestcmb.SelectedIndex].WGT + arms[Armscmb.SelectedIndex].WGT + leggings[Leggingscmb.SelectedIndex].WGT;
            ELUsedtxt.Text = String.Format("{0:0.0}", equipLoadUsed);

            equipLoadPercent = (equipLoadUsed / equipLoad) * 100;
            PercentELtxt.Text = String.Format("{0:0.0}", equipLoadPercent) + "%";

            //refresh weapon table

                // min str
                    R1RequiredSTRtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].minSTR);
                    R2RequiredSTRtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].minSTR);
                    R3RequiredSTRtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].minSTR);
                    L1RequiredSTRtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].minSTR);
                    L2RequiredSTRtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].minSTR);
                    L3RequiredSTRtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].minSTR);
                // min dex
                    R1RequiredDEXtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].minDEX);
                    R2RequiredDEXtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].minDEX);
                    R3RequiredDEXtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].minDEX);
                    L1RequiredDEXtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].minDEX);
                    L2RequiredDEXtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].minDEX);
                    L3RequiredDEXtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].minDEX);
                // min int
                    R1RequiredINTtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].minINT);
                    R2RequiredINTtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].minINT);
                    R3RequiredINTtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].minINT);
                    L1RequiredINTtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].minINT);
                    L2RequiredINTtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].minINT);
                    L3RequiredINTtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].minINT);
                 // min fth
                    R1RequiredFTHtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].minFTH);
                    R2RequiredFTHtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].minFTH);
                    R3RequiredFTHtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].minFTH);
                    L1RequiredFTHtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].minFTH);
                    L2RequiredFTHtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].minFTH);
                    L3RequiredFTHtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].minFTH);
                // str rating
                    R1ScalingSTRtxt.Text = weapons[R1cmb.SelectedIndex].rateSTR.ToString();
                    R2ScalingSTRtxt.Text = weapons[R2cmb.SelectedIndex].rateSTR.ToString();
                    R3ScalingSTRtxt.Text = weapons[R3cmb.SelectedIndex].rateSTR.ToString();
                    L1ScalingSTRtxt.Text = weapons[L1cmb.SelectedIndex].rateSTR.ToString();
                    L2ScalingSTRtxt.Text = weapons[L2cmb.SelectedIndex].rateSTR.ToString();
                    L3ScalingSTRtxt.Text = weapons[L3cmb.SelectedIndex].rateSTR.ToString();
                // dex rating
                    R1ScalingDEXtxt.Text = weapons[R1cmb.SelectedIndex].rateDEX.ToString();
                    R2ScalingDEXtxt.Text = weapons[R2cmb.SelectedIndex].rateDEX.ToString();
                    R3ScalingDEXtxt.Text = weapons[R3cmb.SelectedIndex].rateDEX.ToString();
                    L1ScalingDEXtxt.Text = weapons[L1cmb.SelectedIndex].rateDEX.ToString();
                    L2ScalingDEXtxt.Text = weapons[L2cmb.SelectedIndex].rateDEX.ToString();
                    L3ScalingDEXtxt.Text = weapons[L3cmb.SelectedIndex].rateDEX.ToString();
                // int rating
                    R1ScalingINTtxt.Text = weapons[R1cmb.SelectedIndex].rateINT.ToString();
                    R2ScalingINTtxt.Text = weapons[R2cmb.SelectedIndex].rateINT.ToString();
                    R3ScalingINTtxt.Text = weapons[R3cmb.SelectedIndex].rateINT.ToString();
                    L1ScalingINTtxt.Text = weapons[L1cmb.SelectedIndex].rateINT.ToString();
                    L2ScalingINTtxt.Text = weapons[L2cmb.SelectedIndex].rateINT.ToString();
                    L3ScalingINTtxt.Text = weapons[L3cmb.SelectedIndex].rateINT.ToString();
                // fth rating
                    R1ScalingFTHtxt.Text = weapons[R1cmb.SelectedIndex].rateFTH.ToString();
                    R2ScalingFTHtxt.Text = weapons[R2cmb.SelectedIndex].rateFTH.ToString();
                    R3ScalingFTHtxt.Text = weapons[R3cmb.SelectedIndex].rateFTH.ToString();
                    L1ScalingFTHtxt.Text = weapons[L1cmb.SelectedIndex].rateFTH.ToString();
                    L2ScalingFTHtxt.Text = weapons[L2cmb.SelectedIndex].rateFTH.ToString();
                    L3ScalingFTHtxt.Text = weapons[L3cmb.SelectedIndex].rateFTH.ToString();
                 // wgt
                    R1WGTtxt.Text = String.Format("{0:0.0}", weapons[R1cmb.SelectedIndex].WGT);
                    R2WGTtxt.Text = String.Format("{0:0.0}", weapons[R2cmb.SelectedIndex].WGT);
                    R3WGTtxt.Text = String.Format("{0:0.0}", weapons[R3cmb.SelectedIndex].WGT);
                    L1WGTtxt.Text = String.Format("{0:0.0}", weapons[L1cmb.SelectedIndex].WGT);
                    L2WGTtxt.Text = String.Format("{0:0.0}", weapons[L2cmb.SelectedIndex].WGT);
                    L3WGTtxt.Text = String.Format("{0:0.0}", weapons[L3cmb.SelectedIndex].WGT);
                 // stb
                    R1STBtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].STB);
                    R2STBtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].STB);
                    R3STBtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].STB);
                    L1STBtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].STB);
                    L2STBtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].STB);
                    L3STBtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].STB);
                 // dur
                    R1DURtxt.Text = String.Format("{0:0}", weapons[R1cmb.SelectedIndex].DUR);
                    R2DURtxt.Text = String.Format("{0:0}", weapons[R2cmb.SelectedIndex].DUR);
                    R3DURtxt.Text = String.Format("{0:0}", weapons[R3cmb.SelectedIndex].DUR);
                    L1DURtxt.Text = String.Format("{0:0}", weapons[L1cmb.SelectedIndex].DUR);
                    L2DURtxt.Text = String.Format("{0:0}", weapons[L2cmb.SelectedIndex].DUR);
                    L3DURtxt.Text = String.Format("{0:0}", weapons[L3cmb.SelectedIndex].DUR);
        }


        private void Ring1cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( Ring1cmb.SelectedIndex == Ring2cmb.SelectedIndex || Ring1cmb.SelectedIndex == Ring3cmb.SelectedIndex || Ring1cmb.SelectedIndex == Ring4cmb.SelectedIndex)
            {
                Ring1cmb.SelectedIndex = 0;
            }
            refresh();
        }

        private void Ring2cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ring2cmb.SelectedIndex == Ring1cmb.SelectedIndex || Ring2cmb.SelectedIndex == Ring3cmb.SelectedIndex || Ring2cmb.SelectedIndex == Ring4cmb.SelectedIndex)
            {
                Ring2cmb.SelectedIndex = 0;
            }
            refresh();
        }

        private void Ring3cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ring3cmb.SelectedIndex == Ring1cmb.SelectedIndex || Ring3cmb.SelectedIndex == Ring2cmb.SelectedIndex || Ring3cmb.SelectedIndex == Ring4cmb.SelectedIndex)
            {
                Ring3cmb.SelectedIndex = 0;
            }
            refresh();
        }

        private void Ring4cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ring4cmb.SelectedIndex == Ring1cmb.SelectedIndex || Ring4cmb.SelectedIndex == Ring2cmb.SelectedIndex || Ring4cmb.SelectedIndex == Ring3cmb.SelectedIndex)
            {
                Ring4cmb.SelectedIndex = 0;
            }
            refresh();
        }

        private void R1cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void R2cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void R3cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void L1cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void L2cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void L3cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Headcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Chestcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Armscmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Vigortxt_TextChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void VigorMinusbtn_Click(object sender, EventArgs e)
        {
            character.vigorModifier--;

            if (character.vigorModifier < 0)
                character.vigorModifier = 0;
            else
            {
                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void VigorPlusbtn_Click(object sender, EventArgs e)
        {
            character.vigorModifier++;

            if (character.vigorModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].vigorBase))
                character.vigorModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].vigorBase);
            else
            {
                character.soulLevelModifier++;

                refresh();
            }

        }

        private void AttunementMinusbtn_Click(object sender, EventArgs e)
        {
            character.attunementModifier--;

            if (character.attunementModifier < 0)
                character.attunementModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void AttunementPlusbtn_Click(object sender, EventArgs e)
        {
            character.attunementModifier++;

            if (character.attunementModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].attunementBase))
                character.attunementModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].attunementBase);
            else
            {

                character.soulLevelModifier++;

                refresh();
            }
        }

        private void EnduranceMinusbtn_Click(object sender, EventArgs e)
        {
            character.enduranceModifier--;

            if (character.enduranceModifier < 0)
                character.enduranceModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void EndurancePlusbtn_Click(object sender, EventArgs e)
        {
            character.enduranceModifier++;

            if (character.enduranceModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].enduranceBase))
                character.enduranceModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].enduranceBase);
            else
            {

                character.soulLevelModifier++;

                refresh();
            }
        }

        private void VitalityMinusbtn_Click(object sender, EventArgs e)
        {
            character.vitalityModifier--;

            if (character.vitalityModifier < 0)
                character.vitalityModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void VitalityPlusbtn_Click(object sender, EventArgs e)
        {
            character.vitalityModifier++;

            if (character.vitalityModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].vitalityBase))
                character.vitalityModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].vitalityBase);
            else
            {
                character.soulLevelModifier++;

                refresh();
            }
        }

        private void StrengthMinusbtn_Click(object sender, EventArgs e)
        {
            character.strengthModifier--;

            if (character.strengthModifier < 0)
                character.strengthModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void StrengthPlusbtn_Click(object sender, EventArgs e)
        {
            character.strengthModifier++;

            if (character.strengthModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].strengthBase))
                character.strengthModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].strengthBase);
            else
            {

                character.soulLevelModifier++;


                refresh();
            }
        }

        private void DexterityMinusbtn_Click(object sender, EventArgs e)
        {
            character.dexterityModifier--;

            if (character.dexterityModifier < 0)
                character.dexterityModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void DexterityPlusbtn_Click(object sender, EventArgs e)
        {
            character.dexterityModifier++;

            if (character.dexterityModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].dexterityBase))
                character.dexterityModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].dexterityBase);
            else
            {

                character.soulLevelModifier++;

                refresh();
            }
        }

        private void IntelligenceMinusbtn_Click(object sender, EventArgs e)
        {
            character.intelligenceModifier--;

            if (character.intelligenceModifier < 0)
                character.intelligenceModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void IntelligencePlusbtn_Click(object sender, EventArgs e)
        {
            character.intelligenceModifier++;

            if (character.intelligenceModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].intelligenceBase))
                character.intelligenceModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].intelligenceBase);
            else
            {

                character.soulLevelModifier++;

                refresh();
            }
        }

        private void FaithMinusbtn_Click(object sender, EventArgs e)
        {
            character.faithModifier--;

            if (character.faithModifier < 0)
                character.faithModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;

                refresh();
            }
        }

        private void FaithPlusbtn_Click(object sender, EventArgs e)
        {
            character.faithModifier++;

            if (character.faithModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].faithBase))
                character.faithModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].faithBase);
            else
            {

                character.soulLevelModifier++;


                refresh();
            }
        }

        private void LuckMinusbtn_Click(object sender, EventArgs e)
        {
            character.luckModifier--;

            if (character.luckModifier < 0)
                character.luckModifier = 0;
            else
            {

                character.soulLevelModifier--;

                if (character.soulLevelModifier < 0)
                    character.soulLevelModifier = 0;


                refresh();
            }
        }

        private void LuckPlusbtn_Click(object sender, EventArgs e)
        {
            character.luckModifier++;

            if (character.luckModifier > (99 - startingClasses[StartingClasscmb.SelectedIndex].luckBase))
                character.luckModifier = (99 - startingClasses[StartingClasscmb.SelectedIndex].luckBase);
            else
            {

                character.soulLevelModifier++;

                refresh();
            }
        }
    }
}
