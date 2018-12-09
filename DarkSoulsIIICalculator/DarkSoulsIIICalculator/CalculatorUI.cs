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

        int attuneSlots;

        //double[][] curveIndex = new double[][]
  // {
    //new double[] {0, 0, 0.8344518907, 1.917067028, 3.118507614, 4.404263484, 5.756590123, 7.164449132, 8.620231934, 10.11834044, 11.65446426, 13.22517121, 14.8276568, 16.45958186, 18.11896248, 19.80409249, 21.51348727, 23.24584203, 25, 27.71472262, 30.40370474, 33.06592105, 35.70024948, 38.30545618, 40.88017724, 43.42289595, 45.93191442, 48.40531749, 50.84092608, 53.23623592, 55.58833502, 57.89379002, 60.14848454, 62.34738086, 64.4841523, 66.55058206, 68.53550242, 70.42271143, 72.186164, 73.77520674, 75, 75.5, 76, 76.5, 77, 77.5, 78, 78.5, 79, 79.5, 80, 80.5, 81, 81.5, 82, 82.5, 83, 83.5, 84, 84.5, 85, 85.06158775, 85.17419647, 85.32001934, 85.49270201, 85.68857199, 85.90515139, 86.14062112, 86.39357173, 86.66286929, 86.94757571, 87.2468981, 87.56015475, 87.88675135, 88.22616371, 88.57792504, 88.94161609, 89.31685768, 89.7033046, 90.10064091, 90.50857595, 90.92684119, 91.35518752, 91.79338304, 92.24121114, 92.69846893, 93.16496581, 93.64052229, 94.12496895, 94.61814556, 95.11990022, 95.63008872, 96.14857387, 96.67522499, 97.20991735, 97.7525318, 98.30295432, 98.86107568, 99.42679111, 100}
   //};



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
            new StartingClass("Deprived", 1, 10, 10, 10, 10, 10, 10, 10, 10, 10)
        };

        Weapon[] weapons = {
            new Weapon("none", 0, 0, 0, 0),
            new Weapon("Farron Greatsword", 258, 12.5, 45, 90, minSTR : 18, minDEX : 20, rateSTR : 'D', rateDEX : 'C', saturation : 0, scaleDEX : 102.2, scaleSTR : 57.4),
            new Weapon("Test Falchion", 112, 0,0,0, minSTR : 15, minDEX : 17, scaleSTR : 30, scaleDEX : 54, saturation : 0 ),
            new Weapon("Anri's Straight Sword", 204, 3, 0, 0, 10, 10, 0, 0, 21, 19.6, 0, 11.2, 'D' , 'D' , '-', 'E', 0),
            new Weapon("Arbalest", 156, 6, 0, 0, 18, 8, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Archdecon Great Staff", 156, 2.5, 0, 0, 8, 0, 12, 12, 29.4, 0, 0, 156.8, 'D' , '-' , '-', 'S', 0),
            new Weapon("Arstor's Spear", 249, 6.5, 0, 0, 11, 19, 0, 0, 29.4, 82.6, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Astora Greatsword", 264, 8, 0, 0, 16, 18, 0, 0, 63, 71.4, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Astora Straight Sword", 258, 3, 0, 0, 10, 10, 0, 12, 36.4, 28, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Avelyn", 128, 7.5, 0, 0, 16, 14, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Bandit's Knife", 165, 1.5, 0, 0, 6, 12, 0, 0, 35, 42, 0, 0, 'D' , 'D' , '-', '-', 9),
            new Weapon("Barbed Straight Sword", 263, 3, 0, 0, 11, 11, 0, 0, 63, 43.4, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Bastard Sword", 276, 8, 0, 0, 16, 10, 0, 0, 63, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Battle Axe", 250, 4, 0, 0, 12, 8, 0, 0, 63, 35, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Black Blade", 277, 6.5, 0, 0, 18, 18, 0, 0, 29.4, 68.6, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Black Bow of Pharis", 134, 3, 0, 0, 9, 18, 0, 0, 22.4, 89.6, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Black Knight Glaive", 278, 9, 0, 0, 28, 18, 0, 0, 50.4, 56, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Black Knight Greataxe", 376, 19.5, 0, 0, 36, 18, 0, 0, 71.4, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Black Knight Greatsword", 322, 16, 0, 0, 30, 18, 0, 0, 85.4, 35, 0, 0, 'B' , 'D' , '-', '-', 0),
            new Weapon("Black Knight Sword", 272, 10, 0, 0, 20, 18, 0, 0, 57.4, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Blacksmith Hammer", 210, 5, 0, 0, 13, 13, 0, 0, 82.6, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Bloodlust", 218, 5, 0, 0, 11, 24, 0, 0, 8.4, 110.6, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Brigand Axe", 248, 3, 0, 0, 14, 8, 0, 0, 63, 36.4, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Brigand Twindaggers", 110, 2.5, 0, 0, 10, 18, 0, 0, 49, 49, 0, 0, 'D' , 'D' , '-', '-', 9),
            new Weapon("Broadsword", 234, 3, 0, 0, 10, 10, 0, 0, 71.4, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Broken Straight Sword", 140, 1, 0, 0, 8, 8, 0, 0, 53.2, 44.8, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Butcher Knife", 190, 7, 0, 0, 24, 0, 0, 0, 145.6, 0, 0, 0, 'S' , '-' , '-', '-', 0),
            new Weapon("Caestus", 160, 0.5, 0, 0, 5, 8, 0, 0, 56, 56, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Caitha's Chime", 130, 0.5, 0, 0, 3, 0, 12, 12, 28, 0, 112, 124.6, 'D' , '-' , 'A', 'A', 0),
            new Weapon("Canvas Talisman", 117, 0.5, 0, 0, 4, 0, 0, 14, 29.4, 0, 0, 134.4, 'D' , '-' , '-', 'A', 0),
            new Weapon("Carthus Curved Greatsword", 282, 10.5, 0, 0, 18, 22, 0, 0, 57.4, 77, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Carthus Curved Sword", 265, 5.5, 0, 0, 15, 18, 0, 0, 43.4, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Carthus Shotel", 246, 3, 0, 0, 12, 19, 0, 0, 21, 81.2, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Cathedral Knight Greatsword", 298, 15, 0, 0, 26, 10, 0, 0, 78.4, 28, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Chaos Blade", 215, 6, 0, 0, 16, 14, 0, 0, 78.4, 28, 0, 0, 'E' , 'S' , '-', '-', 0),
            new Weapon("Claw", 183, 1.5, 0, 0, 6, 14, 0, 0, 22.4, 77, 0, 0, 'E' , 'C' , '-', '-', 0),
            new Weapon("Claymore", 276, 9, 0, 0, 16, 13, 0, 0, 56, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Cleric's Candlestick", 241, 2, 0, 0, 8, 12, 0, 12, 35, 29.4, 112, 0, 'D' , 'D' , 'A', '-', 0),
            new Weapon("Cleric's Sacred Chime", 118, 0.5, 0, 0, 3, 0, 0, 14, 29.4, 0, 0, 147, 'D' , '-' , '-', 'S', 0),
            new Weapon("Club", 216, 2.5, 0, 0, 10, 0, 0, 0, 91, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Composite Bow", 146, 3.5, 0, 0, 12, 12, 0, 0, 50.4, 42, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Corvian Greatknife", 166, 2.5, 0, 0, 12, 16, 0, 0, 25.2, 25.2, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Court Sorcerer's Staff", 135, 2, 0, 0, 6, 0, 14, 0, 28, 0, 154, 0, 'D' , '-' , 'S', '-', 0),
            new Weapon("Crescent Axe", 238, 6, 0, 0, 14, 12, 0, 0, 49, 57.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Crescent Moon Sword", 284, 2.5, 0, 0, 10, 16, 0, 0, 0, 77, 43.4, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Crystal Chime", 128, 0.5, 0, 0, 3, 0, 18, 18, 28, 0, 0, 0, 'D' , '-' , 'C', 'C', 0),
            new Weapon("Crystal Sage's Rapier", 250, 2.5, 0, 0, 13, 18, 0, 0, 28, 0, 0, 0, 'D' , 'D' , 'A', '-', 0),
            new Weapon("Dagger", 110, 1.5, 0, 0, 5, 9, 0, 0, 14, 98, 0, 0, 'E' , 'B' , '-', '-', 9),
            new Weapon("Dancer's Enchanted Swords", 432, 8.5, 0, 0, 12, 20, 9, 9, 36.4, 49, 50.4, 50.4, 'D' , 'D' , 'D', 'D', 0),
            new Weapon("Dark Hand", 227, 0, 0, 0, 0, 0, 0, 0, 36.4, 49, 50.4, 50.4, 'E' , 'E' , 'C', 'C', 0),
            new Weapon("Dark Sword", 230, 4.5, 0, 0, 16, 15, 0, 0, 36.4, 49, 50.4, 50.4, 'C' , 'D' , '-', '-', 0),
            new Weapon("Darkdrift", 259, 3.5, 0, 0, 10, 28, 0, 0, 36.4, 49, 50.4, 50.4, 'D' , 'C' , '-', '-', 0),
            new Weapon("Darkmoon Longbow", 146, 4.5, 0, 0, 7, 16, 10, 0, 36.4, 49, 50.4, 50.4, '-' , 'E' , 'B', '-', 0),
            new Weapon("Demon's Fist", 310, 8, 0, 0, 20, 8, 9, 9, 63, 0, 28, 28, 'C' , '-' , 'E', 'E', 0),
            new Weapon("Demon's Greataxe", 446, 14.5, 0, 0, 28, 0, 12, 12, 84, 19.6, 35, 35, 'B' , 'E' , 'D', 'D', 0),
            new Weapon("Dragon Tooth", 342, 21, 0, 0, 40, 0, 0, 0, 88.2, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Dragonrider Bow", 200, 6.5, 0, 0, 19, 15, 0, 0, 43.4, 21, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Dragonslayer Greataxe", 506, 20, 0, 0, 40, 0, 0, 0, 58.8, 18.2, 0, 50.4, 'C' , 'E' , '-', 'D', 0),
            new Weapon("Dragonslayer Greatbow", 220, 10, 0, 0, 20, 20, 0, 0, 49, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Dragonslayer Spear", 320, 9.5, 0, 0, 20, 20, 0, 0, 43.4, 84, 0, 36.4, 'D' , 'B' , '-', 'D', 0),
            new Weapon("Dragonslayer Swordspear", 296, 14.5, 0, 0, 16, 22, 0, 18, 43.4, 68.6, 0, 57.4, 'D' , 'C' , '-', 'C', 0),
            new Weapon("Dragonslayer's Axe", 360, 4, 0, 0, 18, 14, 0, 0, 36.4, 11.2, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Drakeblood Greatsword", 426, 6, 0, 0, 18, 16, 0, 0, 42, 42, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Drang Hammers", 220, 9, 0, 0, 18, 16, 0, 0, 77, 14, 0, 0, 'C' , 'E' , '-', '-', 0),
            new Weapon("Drang Twinspears", 200, 8, 0, 0, 14, 20, 0, 0, 42, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Eleonora", 284, 6.5, 0, 0, 20, 8, 0, 0, 43.4, 21, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Estoc", 210, 3.5, 0, 0, 10, 12, 0, 0, 35, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Executioner's Greatsword", 262, 9, 0, 0, 19, 13, 0, 0, 85.4, 28, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Exile Greatsword", 292, 17, 0, 0, 24, 16, 0, 0, 56, 63, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Falchion", 234, 4, 0, 0, 9, 13, 0, 0, 35, 63, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Farron Greatsword", 228, 12.5, 0, 0, 18, 20, 0, 0, 57.4, 102.2, 0, 0, 'C' , 'A' , '-', '-', 0),
            new Weapon("Firelink Greatsword", 364, 9, 0, 0, 20, 10, 10, 10, 57.4, 102.2, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Flamberge", 321, 8.5, 0, 0, 15, 14, 0, 0, 35, 29.4, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Four-Pronged Plow", 210, 8.5, 0, 0, 13, 11, 0, 0, 47.6, 65.8, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Fume Ultra Greatsword", 260, 25.5, 0, 0, 50, 10, 0, 0, 148.4, 7, 0, 0, 'S' , 'E' , '-', '-', 0),
            new Weapon("Gargoyle Flame Hammer", 444, 11, 0, 0, 22, 0, 9, 9, 70, 0, 28, 28, 'C' , '-' , 'D', 'D', 0),
            new Weapon("Gargoyle Flame Spear", 386, 9.5, 0, 0, 15, 18, 9, 9, 28, 49, 28, 28, 'D' , 'D' , 'D', 'D', 0),
            new Weapon("Glaive", 282, 11, 0, 0, 17, 11, 0, 0, 57.4, 21, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Golden Ritual Spear", 262, 3, 0, 0, 10, 10, 18, 14, 21, 51.8, 0, 134.4, '-' , '-' , '-', '-', 0),
            new Weapon("Gotthard Twinswords", 200, 6.5, 0, 0, 12, 18, 0, 0, 63, 56, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Great Club", 304, 12, 0, 0, 28, 0, 0, 0, 93.8, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Great Corvian Scythe", 230, 9, 0, 0, 16, 18, 0, 0, 56, 92.4, 0, 0, 'C' , 'B' , '-', '-', 0),
            new Weapon("Great Mace", 346, 18, 0, 0, 32, 0, 0, 0, 56, 0, 0, 0, 'C' , '-' , '-', '-', 0),
            new Weapon("Great Machete", 334, 14, 0, 0, 24, 12, 0, 0, 61.6, 22.4, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Great Scythe", 243, 7, 0, 0, 14, 14, 0, 0, 28, 84, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Great Wooden Hammer", 206, 6, 0, 0, 18, 0, 0, 0, 85.4, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Greataxe", 376, 16, 0, 0, 32, 8, 0, 0, 64.4, 19.6, 0, 0, 'C' , 'E' , '-', '-', 0),
            new Weapon("Greatlance", 258, 10.5, 0, 0, 21, 16, 0, 0, 57.4, 42, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Greatsword", 318, 20, 0, 0, 28, 10, 0, 0, 63, 56, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Greatsword of Judgement", 306, 9, 0, 0, 17, 15, 12, 0, 50.4, 49, 78.4, 0, 'D' , 'D' , 'D', '-', 0),
            new Weapon("Gundyr's Halberd", 264, 13, 0, 0, 30, 15, 0, 0, 93.8, 14, 0, 0, 'B' , 'E' , '-', '-', 0),
            new Weapon("Halberd", 250, 8, 0, 0, 16, 12, 0, 0, 42, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Hand Axe", 220, 2.5, 0, 0, 9, 8, 0, 0, 63, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Handmaid's Dagger", 144, 0.5, 0, 0, 4, 8, 0, 0, 21, 22.4, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Harpe", 104, 1.5, 0, 0, 8, 10, 0, 0, 12.6, 93.8, 0, 0, 'E' , 'B' , '-', '-', 9),
            new Weapon("Heavy Crossbow", 144, 4.5, 0, 0, 14, 8, 0, 0, 28, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Heretic's Staff", 142, 3, 0, 0, 8, 0, 16, 0, 29.4, 0, 134.4, 0, 'D' , '-' , 'A', '-', 0),
            new Weapon("Heysel Pick", 284, 4.5, 0, 0, 12, 10, 19, 0, 43.4, 14, 120.4, 0, 'D' , 'E' , 'B', '-', 0),
            new Weapon("Hollowslayer Greatsword", 264, 8.5, 0, 0, 14, 18, 0, 0, 49, 78.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Immolation Tinder", 338, 10, 0, 0, 18, 18, 12, 12, 50.4, 56, 134.4, 0, 'D' , 'C' , 'A', '-', 0),
            new Weapon("Irithyll Rapier", 237, 3, 0, 0, 10, 16, 0, 0, 57.4, 70, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Irithyll Straight Sword", 251, 4, 0, 0, 12, 14, 0, 0, 64.4, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Izalith Staff", 210, 3, 0, 0, 12, 0, 14, 10, 43.4, 42, 117.6, 71.4, 'D' , 'D' , 'A', 'C', 0),
            new Weapon("Knight's Crossbow", 160, 4, 0, 0, 12, 8, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Large Club", 296, 10, 0, 0, 22, 0, 0, 0, 81.2, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Light Crossbow", 128, 3, 0, 0, 10, 8, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Longbow", 164, 4, 0, 0, 9, 14, 0, 0, 14, 49, 0, 0, 'E' , 'D' , '-', '-', 0),
            new Weapon("Longsword", 220, 3, 0, 0, 10, 10, 0, 0, 70, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Lorian's Greatsword", 420, 14, 0, 0, 26, 10, 0, 0, 64.4, 42, 43.4, 43.4, 'C' , 'D' , 'D', 'D', 0),
            new Weapon("Lothric Knight Greatsword", 436, 16.5, 0, 0, 24, 16, 0, 0, 43.4, 63, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Lothric Knight Long Spear", 224, 8, 0, 0, 14, 20, 0, 0, 43.4, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Lothric Knight Sword", 206, 4, 0, 0, 11, 18, 0, 0, 57.4, 70, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Lothric's Holy Sword", 196, 4, 0, 0, 10, 18, 0, 14, 46.2, 63, 0, 18.2, 'D' , 'C' , '-', '-', 0),
            new Weapon("Lucerne", 252, 7.5, 0, 0, 15, 13, 0, 0, 49, 57.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Mace", 230, 5, 0, 0, 12, 7, 0, 0, 77, 21, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Mail Breaker", 150, 1.5, 0, 0, 7, 12, 0, 0, 14, 35, 0, 0, 'E' , 'D' , '-', '-', 0),
            new Weapon("Man Serpent Hatchet", 250, 4, 0, 0, 16, 13, 0, 0, 63, 35, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Man-Grub's Staff", 158, 3, 0, 0, 9, 0, 18, 0, 29.4, 0, 0, 0, 'D' , '-' , '-', '-', 0),
            new Weapon("Manikin Claws", 192, 2, 0, 0, 8, 18, 0, 0, 19.6, 81.2, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Mendicant's Staff", 135, 2.5, 0, 0, 7, 0, 18, 0, 29.4, 0, 120.4, 0, 'D' , '-' , 'A', '-', 0),
            new Weapon("Moonlight Greatsword", 344, 10.5, 0, 0, 16, 11, 26, 0, 18.2, 0, 100.8, 0, 'D' , 'E' , 'C', '-', 0),
            new Weapon("Morion Blade", 261, 4, 0, 0, 12, 17, 0, 0, 64.4, 35, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Morne's Great Hammer", 348, 24, 0, 0, 50, 0, 0, 30, 65.8, 0, 0, 30.8, 'B' , '-' , '-', '-', 0),
            new Weapon("Morning Star", 277, 5, 0, 0, 11, 9, 0, 0, 56, 15.4, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Murakumo", 270, 11, 0, 0, 20, 18, 0, 0, 58.8, 74.2, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Notched Whip", 223, 2, 0, 0, 6, 19, 0, 0, 0, 63, 0, 0, '-' , 'C' , '-', '-', 0),
            new Weapon("Old King's Great Hammer", 454, 18.5, 0, 0, 30, 0, 10, 10, 58.8, 0, 50.4, 50.4, 'C' , '-' , 'D', 'D', 0),
            new Weapon("Old Wolf Curved Sword", 280, 13, 0, 0, 19, 25, 0, 0, 29.4, 100.8, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Onikiri and Ubadachi", 243, 8.5, 0, 0, 13, 25, 0, 0, 56, 71.4, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Onislayer Greatbow", 194, 7.5, 0, 0, 18, 24, 0, 0, 21, 85.4, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Painting Guardian's Curved Sword", 211, 1.5, 0, 0, 7, 19, 0, 0, 7, 113.4, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Parrying Dagger", 100, 1, 0, 0, 5, 14, 0, 0, 12.6, 95.2, 0, 0, 'E' , 'B' , '-', '-', 9),
            new Weapon("Partizan", 216, 6.5, 0, 0, 14, 12, 0, 0, 49, 64.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Pickaxe", 280, 8, 0, 0, 18, 9, 0, 0, 82.6, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Pike", 210, 7.5, 0, 0, 18, 14, 0, 0, 40.6, 72.8, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Pontiff Knight Curved Sword", 214, 3.5, 0, 0, 12, 18, 10, 0, 43.4, 68.6, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Pontiff Knight Great Scythe", 174, 7.5, 0, 0, 14, 19, 0, 0, 15.4, 159.6, 0, 0, '-' , 'S' , '-', '-', 0),
            new Weapon("Priest's Chime", 117, 0.5, 0, 0, 3, 0, 0, 10, 28, 0, 0, 138.6, 'D' , '-' , '-', 'A', 0),
            new Weapon("Profaned Greatsword", 294, 13.5, 0, 0, 22, 10, 0, 0, 78.4, 63, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Rapier", 190, 2, 0, 0, 7, 12, 0, 0, 28, 84, 0, 0, '-' , 'B' , '-', '-', 0),
            new Weapon("Red Hilted Halberd", 260, 8, 0, 0, 14, 14, 0, 0, 49, 56, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Reinforced Club", 220, 5, 0, 0, 12, 0, 0, 0, 92.4, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Ricard's Rapier", 194, 2.5, 0, 0, 8, 20, 0, 0, 29.4, 84, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Rotten Ghru Curved Sword", 239, 2, 0, 0, 10, 13, 0, 0, 21, 81.2, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Rotten Ghru Dagger", 142, 2, 0, 0, 10, 8, 0, 0, 12.6, 92.4, 0, 0, '-' , '-' , '-', '-', 9),
            new Weapon("Rotten Ghru Spear", 242, 5.5, 0, 0, 10, 12, 0, 0, 47.6, 65.8, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Sage's Crystal Staff", 154, 2.5, 0, 0, 7, 0, 24, 0, 28, 0, 119, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Saint Bident", 196, 8.5, 0, 0, 12, 12, 0, 16, 21, 28, 0, 49, 'D' , 'D' , '-', 'D', 0),
            new Weapon("Saint-tree Bellvine", 117, 0.5, 0, 0, 3, 0, 0, 18, 28, 0, 0, 109.2, 'D' , '-' , '-', 'A', 0),
            new Weapon("Saint's Talisman", 120, 0.5, 0, 0, 4, 0, 0, 16, 29.4, 0, 0, 158.2, 'D' , '-' , '-', 'S', 0),
            new Weapon("Scholar's Candlestick", 116, 1.5, 0, 0, 7, 7, 0, 0, 14, 72.8, 0, 0, 'E' , 'C' , '-', '-', 0),
            new Weapon("Scimitar", 180, 2.5, 0, 0, 7, 13, 0, 0, 7, 112, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Sellsword Twinblades", 198, 5.5, 0, 0, 10, 16, 0, 0, 21, 81.2, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Short Bow", 154, 2, 0, 0, 7, 12, 0, 0, 14, 50.4, 0, 0, 'E' , 'D' , '-', '-', 0),
            new Weapon("Shortsword", 198, 2, 0, 0, 8, 10, 0, 0, 56, 71.4, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Shotel", 208, 2.5, 0, 0, 9, 14, 0, 0, 21, 81.2, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Smough's Great Hammer", 358, 24, 0, 0, 45, 0, 0, 0, 86.8, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Sniper Crossbow", 140, 7.5, 0, 0, 18, 16, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Soldering Iron", 270, 5, 0, 0, 10, 12, 0, 0, 33.6, 58.8, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Sorcerer's Staff", 135, 2, 0, 0, 6, 0, 10, 0, 28, 0, 140, 0, 'D' , '-' , 'A', '-', 0),
            new Weapon("Spear", 208, 4.5, 0, 0, 11, 10, 0, 0, 42, 71.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Spiked Mace", 331, 16, 0, 0, 21, 13, 0, 0, 84, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Spotted Whip", 237, 2.5, 0, 0, 9, 20, 0, 0, 0, 63, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Storm Curved Sword", 200, 5, 0, 0, 14, 20, 0, 0, 29.4, 84, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Storm Ruler", 260, 10, 0, 0, 0, 0, 0, 0, 56, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Storyteller's Staff", 136, 2.5, 0, 0, 6, 0, 12, 0, 28, 0, 131.6, 0, 'D' , '-' , 'A', '-', 0),
            new Weapon("Sunless Talisman", 130, 0.5, 0, 0, 4, 0, 0, 24, 28, 0, 112, 119, 'D' , '-' , 'A', 'A', 0),
            new Weapon("Sunlight Straight Sword", 196, 3, 0, 0, 12, 12, 0, 16, 84, 84, 0, 0, 'B' , 'B' , '-', '-', 0),
            new Weapon("Sunlight Talisman", 120, 0.5, 0, 0, 4, 0, 0, 14, 29.4, 0, 0, 114.8, 'D' , '-' , '-', 'A', 0),
            new Weapon("Tailbone Short Sword", 164, 2, 0, 0, 8, 14, 0, 0, 14, 28, 0, 0, 'E' , 'D' , '-', '-', 0),
            new Weapon("Tailbone Spear", 216, 4.5, 0, 0, 13, 15, 0, 0, 28, 57.4, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Talisman", 117, 0.5, 0, 0, 4, 0, 0, 10, 28, 0, 0, 140, 'D' , '-' , '-', 'A', 0),
            new Weapon("Thrall Axe", 208, 1.5, 0, 0, 8, 8, 0, 0, 60.2, 53.2, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Twin Princes' Greatsword", 350, 9.5, 0, 0, 22, 14, 0, 0, 43.4, 42, 36.4, 36.4, 'D' , 'D' , 'D', 'D', 0),
            new Weapon("Uchigatana", 264, 5.5, 0, 0, 11, 16, 0, 0, 28, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Vordt's Great Hammer", 320, 17, 0, 0, 30, 0, 0, 0, 85.4, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Warden Twinblades", 219, 6.5, 0, 0, 10, 18, 0, 0, 43.4, 63, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Warpick", 226, 4.5, 0, 0, 12, 10, 0, 0, 75.6, 22.4, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Washing Pole", 285, 8.5, 0, 0, 18, 20, 0, 0, 35, 63, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Whip", 180, 2, 0, 0, 6, 14, 0, 0, 0, 84, 0, 0, '-' , 'B' , '-', '-', 0),
            new Weapon("White Hair Talisman", 266, 0.5, 0, 0, 4, 0, 0, 16, 28, 0, 42, 70, 'D' , '-' , 'D', 'C', 0),
            new Weapon("Winged Knight Halberd", 290, 14, 0, 0, 26, 16, 0, 0, 57.4, 21, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Winged Knight Twinaxes", 244, 8.5, 0, 0, 20, 12, 0, 0, 63, 35, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Winged Spear", 190, 6, 0, 0, 12, 15, 0, 0, 56, 84, 0, 0, 'C' , 'B' , '-', '-', 0),
            new Weapon("Witch Tree Branch", 129, 2, 0, 0, 7, 0, 18, 0, 28, 0, 93.8, 0, 'D' , '-' , 'B', '-', 0),
            new Weapon("Witch's Locks", 274, 3, 0, 0, 9, 17, 12, 12, 0, 49, 84, 84, '-' , 'D' , 'B', 'B', 0),
            new Weapon("Wolf Knight's Greatsword", 230, 11.5, 0, 0, 24, 18, 0, 0, 79.8, 61.6, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Wolnir's Holy Sword", 250, 7.5, 0, 0, 13, 13, 0, 13, 51.8, 14, 0, 51.8, 'D' , 'C' , '-', '-', 0),
            new Weapon("Yhorm's Great Machete", 338, 19, 0, 0, 38, 10, 0, 0, 109.2, 0, 0, 0, 'A' , '-' , '-', '-', 14),
            new Weapon("Yorshka's Chime", 123, 0.5, 0, 0, 3, 0, 0, 30, 29.4, 0, 0, 163.8, 'D' , '-' , '-', 'S', 0),
            new Weapon("Yorshka's Spear", 172, 6.5, 0, 0, 18, 14, 0, 0, 56, 78.4, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Zweihander", 290, 10, 0, 0, 19, 11, 0, 0, 70, 49, 0, 0, 'C' , 'D' , '-', '-', 0)
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

        Spell[] spells =
        {
            //new Spell("Soul Arrow", 1, 10, 0),
            new Spell("Heal Aid", 1, 0, 8),
            new Spell("Heal", 1, 0, 12),
            new Spell("Med Heal", 1, 0, 15),
            new Spell("Great Heal", 1, 0, 25),
            new Spell("Soothing Sunlight", 1, 0, 45),
            new Spell("Replenishment", 1, 0, 15),
            new Spell("Bountiful Light", 1, 0, 25),
            new Spell("Bountiful Sunlight", 2, 0, 35),
            new Spell("Caressing Tears", 1, 0, 12),
            new Spell("Tears of Denial", 2, 0, 15),
            new Spell("Homeward", 1, 0, 18),
            new Spell("Seek Guidance", 1, 0, 12),
            new Spell("Sacred Oath", 2, 0, 28),
            new Spell("Force", 1, 0, 12),
            new Spell("Emit Force", 1, 0, 18),
            new Spell("Wrath of the Gods", 2, 0, 30),
            new Spell("Lightning Spear", 1, 0, 20),
            new Spell("Great Lightning Spear", 1, 0, 30),
            new Spell("Sunlight Spear", 1, 0, 40),
            new Spell("Lightning Stake", 1, 0, 35),
            new Spell("Lightning Storm", 2, 0, 45),
            new Spell("Divine Pillars of Light", 1, 0, 30),
            new Spell("Blessed Weapon", 1, 0, 15),
            new Spell("Lightning Blade", 1, 0, 30),
            new Spell("Darkmoon Blade", 1, 0, 30),
            new Spell("Magic Barrier", 1, 0, 15),
            new Spell("Great Magic Barrier", 2, 0, 25),
            new Spell("Dark Blade", 1, 0, 25),
            new Spell("Vow of Silence", 2, 0, 30),
            new Spell("Dead Again", 1, 15, 23),
            new Spell("Atonement", 1, 0, 18),
            new Spell("Deep Protection", 1, 0, 20),
            new Spell("Gnaw", 1, 0, 18),
            new Spell("Dorhys' Gnawing", 1, 0, 25),
            new Spell("Lifehunt Scythe", 1, 0, 22),
            new Spell("Way of White Corona", 1, 0, 18),
            new Spell("Projected Heal", 1, 0, 28),
            new Spell("Lightning Arrow", 1, 0, 35),
            new Spell("Soul Arrow", 1, 10, 0),
            new Spell("Great Soul Arrow", 1, 15, 0),
            new Spell("Heavy Soul Arrow", 1, 13, 0),
            new Spell("Great Heavy Soul Arrow", 1, 18, 0),
            new Spell("Farron Dart", 1, 8, 0),
            new Spell("Great Farron Dart", 1, 23, 0),
            new Spell("Farron Hail", 1, 28, 0),
            new Spell("Homing Soulmass", 1, 20, 0),
            new Spell("Homing Crystal Soulmass", 1, 30, 0),
            new Spell("Crystal Hail", 1, 18, 0),
            new Spell("Soul Spear", 1, 32, 0),
            new Spell("Crystal Soul Spear", 1, 48, 0),
            new Spell("White Dragon Breath", 1, 50, 0),
            new Spell("Soul Stream", 2, 45, 0),
            new Spell("Soul Greatsword", 1, 22, 0),
            new Spell("Farron Flashsword", 1, 23, 0),
            new Spell("Magic Weapon", 1, 10, 0),
            new Spell("Great Magic Weapon", 1, 15, 0),
            new Spell("Crystal Magic Weapon", 1, 30, 0),
            new Spell("Magic Shield", 1, 10, 0),
            new Spell("Great Magic Shield", 1, 18, 0),
            new Spell("Spook", 1, 10, 0),
            new Spell("Aural Decoy", 1, 18, 0),
            new Spell("Pestilent Mist", 1, 30, 0),
            new Spell("Cast Light", 1, 15, 0),
            new Spell("Repair", 1, 15, 0),
            new Spell("Hidden Weapon", 1, 12, 0),
            new Spell("Hidden Body", 1, 15, 0),
            new Spell("Chameleon", 1, 12, 0),
            new Spell("Twisted Wall of Light", 1, 27, 0),
            new Spell("Deep Soul", 1, 12, 0),
            new Spell("Great Deep Soul", 1, 20, 0),
            new Spell("Affinity", 1, 32, 0),
            new Spell("Dark Edge", 1, 30, 0),
            new Spell("Frozen Weapon", 1, 15, 0),
            new Spell("Snap Freeze", 1, 18, 0),
            new Spell("Great Soul Dregs", 1, 40, 0),
            new Spell("Old Moonlight", 1, 25, 0),
            new Spell("Fireball", 1, 6, 6),
            new Spell("Fire Orb", 1, 8, 8),
            new Spell("Bursting Fireball", 1, 18, 12),
            new Spell("Great Chaos Fire Orb", 2, 0, 0),
            new Spell("Chaos Bed Vestiges", 2, 20, 10),
            new Spell("Fire Surge", 1, 6, 0),
            new Spell("Fire Whip", 1, 13, 8),
            new Spell("Firestorm", 1, 18, 0),
            new Spell("Chaos Storm", 2, 0, 0),
            new Spell("Great Combustion", 1, 10, 10),
            new Spell("Sacred Flame", 1, 8, 8),
            new Spell("Profaned Flame", 1, 25, 0),
            new Spell("Poison Mist", 1, 0, 10),
            new Spell("Toxic Mist", 1, 0, 15),
            new Spell("Acid Surge", 1, 0, 13),
            new Spell("Flash Sweat", 1, 6, 6),
            new Spell("Profuse Sweat", 1, 6, 6),
            new Spell("Iron Flesh", 1, 8, 0),
            new Spell("Power Within", 1, 10, 10),
            new Spell("Carthus Beacon", 2, 12, 12),
            new Spell("Carthus Flame Arc", 1, 10, 10),
            new Spell("Warmth", 2, 0, 25),
            new Spell("Rapport", 1, 15, 0),
            new Spell("Boulder Heave", 1, 8, 12),
            new Spell("Black Flame", 1, 15, 15),
            new Spell("Black Fire Orb", 1, 20, 20),
            new Spell("Black Serpent", 1, 15, 15),
            new Spell("Floating Chaos", 1, 16, 16),
            new Spell("Seething Chaos", 1, 18, 18),
            new Spell("Flame Fan", 1, 15, 15)
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

            for ( int k = 0; k < spells.Count(); k++ )
            {
                AddSpellcmb.Items.Add(spells[k].name);
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

            if (attunement == 99)
                attuneSlots = 10 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 80 )
                attuneSlots = 9 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 60 )
                attuneSlots = 8 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 50)
                attuneSlots = 7 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 40)
                attuneSlots = 6 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 30)
                attuneSlots = 5 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 24)
                attuneSlots = 4 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 18)
                attuneSlots = 3 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else if (attunement >= 14)
                attuneSlots = 2 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;
            else
                attuneSlots = 1 + rings[Ring1cmb.SelectedIndex].attunementBonus + rings[Ring2cmb.SelectedIndex].attunementBonus + rings[Ring3cmb.SelectedIndex].attunementBonus + rings[Ring4cmb.SelectedIndex].attunementBonus - character.attuneSlotModifier;

            UnusedSlotstxt.Text = attuneSlots.ToString();

            //Attack stats
            RWeapon1txt.Text = String.Format("{0:0.00}", weapons[R1cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));
            RWeapon2txt.Text = String.Format("{0:0.00}", weapons[R2cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));
            RWeapon3txt.Text = String.Format("{0:0.00}", weapons[R3cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));
            LWeapon1txt.Text = String.Format("{0:0.00}", weapons[L1cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));
            LWeapon2txt.Text = String.Format("{0:0.00}", weapons[L2cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));
            LWeapon3txt.Text = String.Format("{0:0.00}", weapons[L3cmb.SelectedIndex].weaponAR(strength, dexterity, intelligence, faith));

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
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[R1cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R1cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                R1cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[R1cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R1cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                R1cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[R1cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R1cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                R1cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[R1cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R1cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                R1cmb.SelectedIndex = 0;
            }
            else{ }


            refresh();
        }

        private void R2cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[R2cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R2cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                R2cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[R2cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R2cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                R2cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[R2cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R2cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                R2cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[R2cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R2cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                R2cmb.SelectedIndex = 0;
            }
            else { }


            refresh();

            refresh();
        }

        private void R3cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[R3cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R3cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                R3cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[R3cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R3cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                R3cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[R3cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R3cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                R3cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[R3cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[R3cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                R3cmb.SelectedIndex = 0;
            }
            else { }

            refresh();
        }

        private void L1cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[L1cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L1cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                L1cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[L1cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L1cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                L1cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[L1cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L1cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                L1cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[L1cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L1cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                L1cmb.SelectedIndex = 0;
            }
            else { }


            refresh();
        }

        private void L2cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[L2cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L2cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                L2cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[L2cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L2cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                L2cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[L2cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L2cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                L2cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[L2cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L2cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                L2cmb.SelectedIndex = 0;
            }
            else { }


            refresh();
        }

        private void L3cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int strength = Convert.ToInt32(Strengthtxt.Text);
            int dexterity = Convert.ToInt32(Dexteritytxt.Text);
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (strength < weapons[L3cmb.SelectedIndex].minSTR)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L3cmb.SelectedIndex].minSTR - strength).ToString() + " more strength.", "Insufficient Strength:");
                L3cmb.SelectedIndex = 0;
            }
            else if (dexterity < weapons[L3cmb.SelectedIndex].minDEX)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L3cmb.SelectedIndex].minDEX - dexterity).ToString() + " more dexterity.", "Insufficient Dexterity:");
                L3cmb.SelectedIndex = 0;
            }
            else if (intelligence < weapons[L3cmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L3cmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
                L3cmb.SelectedIndex = 0;
            }
            else if (faith < weapons[L3cmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (weapons[L3cmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
                L3cmb.SelectedIndex = 0;
            }
            else { }


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

        private void AddSpellbtn_Click(object sender, EventArgs e)
        {
            int intelligence = Convert.ToInt32(Intelligencetxt.Text);
            int faith = Convert.ToInt32(Faithtxt.Text);

            if (AddSpellcmb.SelectedIndex < 0)
            {
                return;
            }

            if (attuneSlots < spells[AddSpellcmb.SelectedIndex].attunement)
            {
                System.Windows.Forms.MessageBox.Show("need " + (spells[AddSpellcmb.SelectedIndex].attunement - attuneSlots).ToString() + " more slot(s).", "Insufficient Attunement:");
            }
            else if (intelligence < spells[AddSpellcmb.SelectedIndex].minINT)
            {
                System.Windows.Forms.MessageBox.Show("need " + (spells[AddSpellcmb.SelectedIndex].minINT - intelligence).ToString() + " more intelligence.", "Insufficient Intelligence:");
            }
            else if (faith < spells[AddSpellcmb.SelectedIndex].minFTH)
            {
                System.Windows.Forms.MessageBox.Show("need " + (spells[AddSpellcmb.SelectedIndex].minFTH - faith).ToString() + " more faith.", "Insufficient Faith:");
            }
            else
            {
                character.attuneSlotModifier += spells[AddSpellcmb.SelectedIndex].attunement;

                string item = spells[AddSpellcmb.SelectedIndex].name + " slots: " + spells[AddSpellcmb.SelectedIndex].attunement.ToString() + "  minINT: " + spells[AddSpellcmb.SelectedIndex].minINT.ToString() + " minFTH: " + spells[AddSpellcmb.SelectedIndex].minFTH.ToString() + "\r\n";

                Spellslb.Items.Add(item);
            }

            refresh();
        }

        private void Spellslb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClearSpellsbtn_Click(object sender, EventArgs e)
        {
            Spellslb.Items.Clear();
            character.attuneSlotModifier = 0;
            refresh();
        }

        private void clearWeaponsbtn_Click(object sender, EventArgs e)
        {
            R1cmb.SelectedIndex = 0;
            R2cmb.SelectedIndex = 0;
            R3cmb.SelectedIndex = 0;
            L1cmb.SelectedIndex = 0;
            L2cmb.SelectedIndex = 0;
            L3cmb.SelectedIndex = 0;

            refresh();
        }

        private void ClearArmourbtn_Click(object sender, EventArgs e)
        {
            Headcmb.SelectedIndex = 0;
            Chestcmb.SelectedIndex = 0;
            Armscmb.SelectedIndex = 0;
            Leggingscmb.SelectedIndex = 0;

            refresh();
        }

        private void ClearRingsbtn_Click(object sender, EventArgs e)
        {
            Ring1cmb.SelectedIndex = 0;
            Ring2cmb.SelectedIndex = 0;
            Ring3cmb.SelectedIndex = 0;
            Ring4cmb.SelectedIndex = 0;

            refresh();
        }

        private void ResetLevelbtn_Click(object sender, EventArgs e)
        {
            character.soulLevelModifier = 0;
            character.vigorModifier = 0;
            character.attunementModifier = 0;
            character.attuneSlotModifier = 0;
            character.enduranceModifier = 0;
            character.vitalityModifier = 0;
            character.strengthModifier = 0;
            character.dexterityModifier = 0;
            character.intelligenceModifier = 0;
            character.faithModifier = 0;
            character.luckModifier = 0;

            Spellslb.Items.Clear();

            refresh();
        }

        private void ResetCalculatorbtn_Click(object sender, EventArgs e)
        {
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

            Spellslb.Items.Clear();

            character.soulLevelModifier = 0;
            character.vigorModifier = 0;
            character.attunementModifier = 0;
            character.attuneSlotModifier = 0;
            character.enduranceModifier = 0;
            character.vitalityModifier = 0;
            character.strengthModifier = 0;
            character.dexterityModifier = 0;
            character.intelligenceModifier = 0;
            character.faithModifier = 0;
            character.luckModifier = 0;

            refresh();
        }
    }
}
