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
            new StartingClass("Herald", 9, 12, 10, 9, 12, 12, 11, 8, 13, 11) };

        Ring[] rings = {
            new Ring("none", 0),
            new Ring("Prisoner's Chain", 1, vigorBonus : 5, enduranceBonus : 5, vitalityBonus : 5) };

        const int knight = 0;
        const int mercenary = 1;
        const int warrior = 2;
        const int herald = 3;

        const int numRings = 1;


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

        }

        private void Vigorval_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            StartingClasscmb.Items.Add(startingClasses[knight].name);
            StartingClasscmb.Items.Add(startingClasses[mercenary].name);
            StartingClasscmb.Items.Add(startingClasses[warrior].name);
            StartingClasscmb.Items.Add(startingClasses[herald].name);

            for ( int k = 0; k <= numRings; k++ )
            {
                Ring1cmb.Items.Add(rings[k].name);
                Ring2cmb.Items.Add(rings[k].name);
                Ring3cmb.Items.Add(rings[k].name);
                Ring4cmb.Items.Add(rings[k].name);
            }

            StartingClasscmb.SelectedIndex = 0; //sets initial value to knight
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

            if ( Ring1cmb.SelectedIndex < 0 )
            {
                Ring1cmb.SelectedIndex = 0;
            }
            if ( Ring2cmb.SelectedIndex < 0 )
            {
                Ring2cmb.SelectedIndex = 0;
            }
            if ( Ring3cmb.SelectedIndex < 0 )
            {
                Ring3cmb.SelectedIndex = 0;
            }
            if (Ring4cmb.SelectedIndex < 0 )
            {
                Ring4cmb.SelectedIndex = 0;
            }

            Ring ring1 = rings[Ring1cmb.SelectedIndex];
            Ring ring2 = rings[Ring2cmb.SelectedIndex];
            Ring ring3 = rings[Ring3cmb.SelectedIndex];
            Ring ring4 = rings[Ring4cmb.SelectedIndex];

            int vigor, attunement, endurance, vitality, strength, dexterity, intelligence, faith, luck;
            
            switch ( StartingClasscmb.SelectedIndex )
            {
                case knight:
                    stclass = startingClasses[knight];
                    break;
                case mercenary:
                    stclass = startingClasses[mercenary];
                    break;
                case warrior:
                    stclass = startingClasses[warrior];
                    break;
                case herald:
                    stclass = startingClasses[herald];
                    break;
                default:
                    break;
            }

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
    }
}
