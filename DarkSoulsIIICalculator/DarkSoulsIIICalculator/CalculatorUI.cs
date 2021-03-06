﻿using System;
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
            new Weapon("Arbalest", 273, 6, 0, 0, 18, 8, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Greataxe", 376, 16, 0, 0, 32, 8, 0, 0, 64.4, 19.6, 0, 0, 'C' , 'E' , '-', '-', 0),
            new Weapon("Caestus", 182, 0.5, 0, 0, 5, 8, 0, 0, 56, 56, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Black Knight Sword", 302, 10, 0, 0, 20, 18, 0, 0, 57.4, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Farron Greatsword", 258, 12.5, 0, 0, 18, 20, 0, 0, 57.4, 102.2, 0, 0, 'C' , 'A' , '-', '-', 0),
            new Weapon("Sellsword Twinblades", 198, 5.5, 0, 0, 10, 16, 0, 0, 21, 81.2, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Scimitar", 180, 2.5, 0, 0, 7, 13, 0, 0, 7, 112, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Mace", 230, 5, 0, 0, 12, 7, 0, 0, 77, 21, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Claymore", 276, 9, 0, 0, 16, 13, 0, 0, 56, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Dark Sword", 230, 4.5, 0, 0, 16, 15, 0, 0, 36.4, 49, 50.4, 50.4, 'C' , 'D' , '-', '-', 0),
            new Weapon("Gundyr's Halberd", 264, 13, 0, 0, 30, 15, 0, 0, 93.8, 14, 0, 0, 'B' , 'E' , '-', '-', 0),
            new Weapon("Smough's Great Hammer", 358, 24, 0, 0, 45, 0, 0, 0, 86.8, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Estoc", 210, 3.5, 0, 0, 10, 12, 0, 0, 35, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Glaive", 282, 11, 0, 0, 17, 11, 0, 0, 57.4, 21, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Great Scythe", 210, 7, 0, 0, 14, 14, 0, 0, 28, 84, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Onikiri and Ubadachi", 208, 8.5, 0, 0, 13, 25, 0, 0, 56, 71.4, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Exile Greatsword", 296, 17, 0, 0, 24, 16, 0, 0, 56, 63, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Lothric Knight Sword", 206, 4, 0, 0, 11, 18, 0, 0, 57.4, 70, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Bloodlust", 184, 5, 0, 0, 11, 24, 0, 0, 8.4, 110.6, 0, 0, 'E' , 'A' , '-', '-', 0)
            /*,
            //new Weapon("Farron Greatsword", 258, 12.5, 45, 90, minSTR : 18, minDEX : 20, rateSTR : 'D', rateDEX : 'C', saturation : 0, scaleDEX : 102.2, scaleSTR : 57.4),
            //new Weapon("Farron Greatsword", 266, 12.5, 0, 0, 18, 20, 0, 0, 57.4, 102.2, 0, 0, 'C' , 'A' , '-', '-', 0),
            //new Weapon("Test Falchion", 112, 0,0,0, minSTR : 15, minDEX : 17, scaleSTR : 30, scaleDEX : 54, saturation : 0 ),
            new Weapon("Anri's Straight Sword", 204, 3, 0, 0, 10, 10, 0, 0, 21, 19.6, 0, 11.2, 'D' , 'D' , '-', 'E', 0),
            new Weapon("Arbalest", 273, 6, 0, 0, 18, 8, 0, 0, 0, 0, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Archdecon Great Staff", 156, 2.5, 0, 0, 8, 0, 12, 12, 29.4, 0, 0, 156.8, 'D' , '-' , '-', 'S', 0),
            new Weapon("Arstor's Spear", 216, 6.5, 0, 0, 11, 19, 0, 0, 29.4, 82.6, 0, 0, 'D' , 'B' , '-', '-', 0),
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
            new Weapon("Black Knight Sword", 302, 10, 0, 0, 20, 18, 0, 0, 57.4, 49, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Blacksmith Hammer", 210, 5, 0, 0, 13, 13, 0, 0, 82.6, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Bloodlust", 184, 5, 0, 0, 11, 24, 0, 0, 8.4, 110.6, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Brigand Axe", 248, 3, 0, 0, 14, 8, 0, 0, 63, 36.4, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Brigand Twindaggers", 110, 2.5, 0, 0, 10, 18, 0, 0, 49, 49, 0, 0, 'D' , 'D' , '-', '-', 9),
            new Weapon("Broadsword", 234, 3, 0, 0, 10, 10, 0, 0, 71.4, 42, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Broken Straight Sword", 140, 1, 0, 0, 8, 8, 0, 0, 53.2, 44.8, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Butcher Knife", 190, 7, 0, 0, 24, 0, 0, 0, 145.6, 0, 0, 0, 'S' , '-' , '-', '-', 0),
            new Weapon("Caestus", 182, 0.5, 0, 0, 5, 8, 0, 0, 56, 56, 0, 0, 'C' , 'C' , '-', '-', 0),
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
            new Weapon("Dagger", 120, 1.5, 0, 0, 5, 9, 0, 0, 14, 98, 0, 0, 'E' , 'B' , '-', '-', 9),
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
            new Weapon("Drang Hammers", 220, 9, 0, 0, 18, 16, 0, 0, 77, 14, 0, 0, 'C' , 'E' , '-', '-', 0),
            new Weapon("Drang Twinspears", 200, 8, 0, 0, 14, 20, 0, 0, 42, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Eleonora", 284, 6.5, 0, 0, 20, 8, 0, 0, 43.4, 21, 0, 0, 'D' , 'D' , '-', '-', 0),
            new Weapon("Estoc", 210, 3.5, 0, 0, 10, 12, 0, 0, 35, 70, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Executioner's Greatsword", 262, 9, 0, 0, 19, 13, 0, 0, 85.4, 28, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Exile Greatsword", 296, 17, 0, 0, 24, 16, 0, 0, 56, 63, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Falchion", 234, 4, 0, 0, 9, 13, 0, 0, 35, 63, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Farron Greatsword", 258, 12.5, 0, 0, 18, 20, 0, 0, 57.4, 102.2, 0, 0, 'C' , 'A' , '-', '-', 0),
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
            new Weapon("Great Scythe", 210, 7, 0, 0, 14, 14, 0, 0, 28, 84, 0, 0, 'D' , 'B' , '-', '-', 0),
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
            new Weapon("Murakumo", 264, 11, 0, 0, 20, 18, 0, 0, 58.8, 74.2, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Notched Whip", 223, 2, 0, 0, 6, 19, 0, 0, 0, 63, 0, 0, '-' , 'C' , '-', '-', 0),
            new Weapon("Old King's Great Hammer", 454, 18.5, 0, 0, 30, 0, 10, 10, 58.8, 0, 50.4, 50.4, 'C' , '-' , 'D', 'D', 0),
            new Weapon("Old Wolf Curved Sword", 280, 13, 0, 0, 19, 25, 0, 0, 29.4, 100.8, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Onikiri and Ubadachi", 208, 8.5, 0, 0, 13, 25, 0, 0, 56, 71.4, 0, 0, 'C' , 'C' , '-', '-', 0),
            new Weapon("Onislayer Greatbow", 194, 7.5, 0, 0, 18, 24, 0, 0, 21, 85.4, 0, 0, 'D' , 'B' , '-', '-', 0),
            new Weapon("Painting Guardian's Curved Sword", 211, 1.5, 0, 0, 7, 19, 0, 0, 7, 113.4, 0, 0, 'E' , 'A' , '-', '-', 0),
            new Weapon("Parrying Dagger", 120, 1, 0, 0, 5, 14, 0, 0, 12.6, 95.2, 0, 0, 'E' , 'B' , '-', '-', 9),
            new Weapon("Partizan", 216, 6.5, 0, 0, 14, 12, 0, 0, 49, 64.4, 0, 0, 'D' , 'C' , '-', '-', 0),
            new Weapon("Pickaxe", 280, 8, 0, 0, 18, 9, 0, 0, 82.6, 0, 0, 0, 'B' , '-' , '-', '-', 0),
            new Weapon("Pike", 210, 7.5, 0, 0, 18, 14, 0, 0, 40.6, 72.8, 0, 0, '-' , '-' , '-', '-', 0),
            new Weapon("Pontiff Knight Curved Sword", 214, 3.5, 0, 0, 12, 18, 10, 0, 43.4, 68.6, 0, 0, 'C' , 'D' , '-', '-', 0),
            new Weapon("Pontiff Knight Great Scythe", 174, 7.5, 0, 0, 14, 19, 0, 0, 15.4, 15.6, 0, 0, '-' , 'S' , '-', '-', 0),
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
        */
            };

        Head[] heads = {
            new Head("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Head("Alva Helm", 4.2, 4.2, 3.4, 4.2, 4, 3.1, 3.8, 3.1, 3.6),
            new Head("Archdeacon White Crown", 1.8, 1.6, 2.7, 1.9, 1.9, 5, 4.6, 5, 5.4),
            new Head("Aristocrat's Mask", 5.9, 5.3, 2.2, 5, 4.9, 3.9, 4.1, 2.1, 3.6),
            new Head("Assassin Hood", 1.8, 1.9, 2.7, 1.9, 2.2, 3.3, 4.3, 3.3, 2.5),
            new Head("Black Hand Hat", 2.5, 2.6, 2.1, 3.8, 2.9, 4.2, 4.4, 3.3, 2.7),
            new Head("Black Iron Helm", 6.8, 5.1, 4.3, 5.4, 5.3, 4.6, 5.7, 4.2, 4.6),
            new Head("Black Knight Helm", 5.6, 4.7, 3.8, 3.3, 4.2, 3.2, 4.5, 3, 3.6),
            new Head("Brass Helm", 4.7, 4.5, 3.5, 4.4, 4.1, 4.6, 3.4, 2.3, 3.4),
            new Head("Brigand Hood", 2.7, 3.5, 3.2, 3.5, 3.5, 2.7, 3, 3.3, 2.7),
            new Head("Catarina Helm", 7.7, 5.4, 4.6, 5.6, 5, 4.3, 4.7, 5.5, 5),
            new Head("Cathedral Knight Helm", 7.6, 4.9, 4.9, 4.4, 5, 4.7, 4.3, 4.6, 3.9),
            new Head("Chain Helm", 3.9, 3.8, 2.2, 4.3, 3.4, 2.6, 2, 1.1, 2.9),
            new Head("Cleric Hat", 1.4, 1.4, 1.9, 1.4, 1.6, 5, 3.8, 4.9, 5),
            new Head("Conjurator Hood", 1.8, 1.5, 1.5, 1.5, 1.3, 4.4, 5.1, 5, 4.6),
            new Head("Court Sorcerer Hood", 1.5, 0.9, 1.1, 0.9, 1.1, 4.1, 3.7, 4.5, 4.4),
            new Head("Creighton's Steel Mask", 5.9, 4.3, 3.7, 4.7, 3.9, 3.7, 4.1, 2.2, 3.9),
            new Head("Crown of Dusk", 1, 0.8, 0, 0.2, 0, -30, 4, 3, 3.2),
            new Head("Dancer's Crown", 2.8, 3.3, 1.8, 4.4, 4, 2.7, 2.2, 2.5, 2.8),
            new Head("Dark Mask", 4, 4.3, 3.1, 3.9, 3.7, 3.1, 2.5, 1.3, 3.1),
            new Head("Dragonslayer Helm", 5.8, 4.6, 3.8, 4.6, 4.6, 3.5, 4.1, 4.1, 2.6),
            new Head("Drakeblood Helm", 6.3, 4.8, 4.7, 5.1, 4.6, 4.8, 4.4, 4, 4),
            new Head("Eastern Helm", 3.9, 4.1, 2.5, 4.8, 3.7, 1.6, 3.4, 1.2, 1.6),
            new Head("Elite Knight Helm", 5.3, 4.5, 4.5, 4.5, 4.5, 3.7, 4.1, 3.1, 3.5),
            new Head("Evangelist Hat", 3.2, 3.7, 4.5, 3.1, 3.1, 4.3, 4.8, 4.8, 3.1),
            new Head("Executioner Helm", 7.2, 5.3, 4.2, 5.3, 4.9, 4.8, 4.9, 3.8, 4.6),
            new Head("Exile Mask", 7.5, 5.1, 5, 6, 4.8, 4.3, 4.8, 3.4, 4.4),
            new Head("Fallen Knight Helm", 4.6, 4.4, 4.2, 3.6, 4, 2.9, 4.2, 3.5, 2.6),
            new Head("Faraam Helm", 6.6, 4.9, 4.7, 4.7, 4.5, 4, 4.4, 4.2, 4.2),
            new Head("Fire Witch Helm", 3.9, 4.7, 2.3, 3.7, 3.7, 4.1, 4.5, 2.8, 3.9),
            new Head("Firelink Helm", 4.1, 4.7, 2.5, 4.6, 4.4, 2.6, 4.4, 1.8, 1.4),
            new Head("Golden Crown", 3.5, 4, 4.2, 3.4, 3.2, 4.2, 4.8, 4.2, 4.2),
            new Head("Grave Warden Hood", 1.5, 1.5, 1.2, 2.9, 1.8, 3.3, 3.3, 4, 1.4),
            new Head("Havel's Helm", 11.2, 5.8, 5.2, 5.5, 5.2, 5, 5.9, 4.6, 5),
            new Head("Helm of Favor", 5.9, 4.3, 3.9, 4.2, 4.3, 3.5, 3.7, 2.5, 3.7),
            new Head("Helm of Thorns", 3.8, 3.7, 2.6, 4.5, 3.9, 2.3, 2.3, 2.3, 1.8),
            new Head("Herald Helm", 3.7, 4.2, 2.5, 4.2, 4, 3.5, 3.2, 1.6, 3.2),
            new Head("Hood of Prayer", 1.3, 0.8, 0.8, 0.8, 0.8, 3.9, 3.5, 3.7, 4.4),
            new Head("Iron Helm", 6, 4.7, 4.9, 4.5, 4.5, 4.7, 4.7, 4.5, 4.7),
            new Head("Karla's Pointed Hat", 1.7, 1.6, 1.4, 1.4, 1.2, 5, 4.7, 4.9, 4.9),
            new Head("Knight Helm", 5.2, 4.5, 3.8, 4.7, 4.2, 2.7, 3.8, 2.4, 3),
            new Head("Lorian's Helm", 5.6, 5, 3.2, 4.8, 3.5, 4.7, 3.3, 3.3, 4.8),
            new Head("Lothric Knight Helm", 6, 4.8, 3.8, 5, 4.6, 4, 4.6, 2.8, 3.6),
            new Head("Lucatiel's Mask", 3.3, 3.9, 3.6, 3, 2.8, 4, 3.8, 4.8, 3.8),
            new Head("Maiden Hood", 1.4, 1, 1.2, 1, 0.9, 4.6, 4.3, 4.4, 4.6),
            new Head("Morne's Helm", 8.1, 5.5, 5, 5.5, 5.3, 5.4, 5.2, 5.1, 3.8),
            new Head("Nameless Knight Helm", 3.8, 3.8, 3.1, 4.2, 3.6, 2.1, 3.4, 2.4, 2.1),
            new Head("Northern Helm", 4.8, 4.7, 4.6, 4.6, 4.4, 2.6, 4.2, 1.8, 2.6),
            new Head("Old Sage's Blindfold", 1, 0.8, 0.8, 0.8, 0.8, 4, 4.4, 3.8, 4.2),
            new Head("Old Sorcerer Hat", 1.2, 1.5, 1.3, 1.3, 1.5, 4.9, 4.3, 4.5, 4.9),
            new Head("Outrider Knight Helm", 3.8, 4.3, 2.8, 4.2, 4.2, 2.3, 3.1, 2.3, 1.1),
            new Head("Painting Guardian Hood", 1.4, 1.9, 1.5, 1.9, 1.9, 4.3, 1.9, 2.3, 1.9),
            new Head("Pharis's Hat", 2.3, 3, 2.5, 3, 3, 3.6, 3.9, 4.1, 3.6),
            new Head("Pontiff Knight Crown", 2.7, 2.8, 1.4, 2.8, 2.5, 4.7, 3.3, 4.3, 5),
            new Head("Pyromancer Crown", 1.1, 0.5, 0.5, 0.9, 0.5, 4.2, 4.8, 3.6, 4),
            new Head("Ragged Mask", 0.7, 1.1, 1.1, 1.1, 1.1, 3.8, 3.2, 3.5, 3.8),
            new Head("Sellsword Helm", 3.1, 3.1, 3.3, 3.6, 3.9, 2.7, 2.7, 2.7, 2.7),
            new Head("Shadow Mask", 1.5, 2.5, 2.2, 1.7, 2.5, 2, 1.5, 2, 1.1),
            new Head("Silver Knight Helm", 6.1, 4.8, 4.5, 5.1, 5, 4.7, 4.5, 4.1, 4.1),
            new Head("Silver Mask", 3.3, 3.3, 3.9, 3.3, 3.3, 3.5, 4.2, 3.3, 2.8),
            new Head("Smough's Helm", 12.2, 6.2, 6.7, 5.3, 4.9, 4.7, 4.6, 4.9, 4.9),
            new Head("Sneering Mask", 2.1, 1.2, 1.6, 1.2, 1, 3.6, 4.1, 2.4, 1.6),
            new Head("Sorcerer Hood", 1.4, 1, 1, 1, 0.9, 4.4, 4, 4.2, 4.5),
            new Head("Standard Helm", 3.7, 3.7, 3.7, 3.7, 3.7, 3, 3.3, 2.4, 3),
            new Head("Steel Soldier Helm", 4.6, 4.3, 3.6, 4.2, 4.2, 2.6, 2.9, 2, 3.7),
            new Head("Sunless Veil", 1.8, 1.7, 1.2, 1.2, 1.3, 5.2, 4.7, 4.8, 5.3),
            new Head("Sunset Helm", 5.5, 4.9, 4.3, 4.7, 4.7, 2.9, 3.5, 2.1, 3.5),
            new Head("Symbol of Avarice", 11, 4.6, 4.6, 4.6, 4, 4.1, 3.4, 4.8, 3.8),
            new Head("Thief Mask", 2.1, 2.2, 2.5, 2.2, 2.2, 2.2, 2.5, 2.8, 2.2),
            new Head("Thrall Hood", 1.5, 2, 1.4, 1.6, 1.2, 4.2, 3.8, 4, 4.2),
            new Head("Undead Legion Helm", 4, 3.8, 4, 2.6, 3.5, 4.7, 4.8, 4.9, 4.2),
            new Head("Winged Knight Helm", 7.4, 5.3, 4.7, 5.2, 5, 4.2, 4.8, 4.5, 5.4),
            new Head("Wolf Knight Helm", 4.2, 4.4, 3.8, 4.4, 4.4, 3, 4.2, 2.2, 3.8),
            new Head("Wolnir's Crown", 3.4, 3.1, 3.1, 3.1, 2.8, 3.9, 4.3, 4.5, 4.9),
            new Head("Worker Hat", 2.3, 1.9, 2.7, 2.2, 2.2, 3, 2.5, 2.5, 4.5),
            new Head("Xanthous Crown", 3, 2.1, 2.6, 2.6, 2.1, 4.6, 2.2, 4.8, 4.6)
        };

        Chest[] chests = {
            new Chest("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Chest("Alva Armor", 9, 11.9, 9.5, 11.9, 11.4, 8.8, 10.9, 8.8, 10.2),
            new Chest("Antiquated Dress", 3.1, 3.2, 3.6, 3.2, 3.2, 12.3, 13.9, 11.8, 13.2),
            new Chest("Archdeacon Holy Garb", 4.2, 3.7, 6.8, 4.4, 4.4, 12.4, 11.5, 12.4, 13.7),
            new Chest("Armor of the Sun", 8.6, 11.2, 8.3, 10.9, 11.2, 10.5, 10.5, 9.8, 10.5),
            new Chest("Armor of Thorns", 8.5, 11, 8.1, 13.1, 11.5, 7.3, 7.3, 7.3, 5.9),
            new Chest("Assassin Armor", 6.9, 8.6, 10, 8.6, 9.3, 10.4, 11.4, 10.4, 9),
            new Chest("Black Dress", 6.5, 7.7, 7.7, 10, 6.8, 9.7, 12.5, 10.9, 12.1),
            new Chest("Black Hand Armor", 7.8, 9, 8.1, 11.5, 9.7, 12.6, 12.8, 10.4, 9),
            new Chest("Black Iron Armor", 16.6, 14.6, 11.7, 14.6, 14, 12, 15.1, 11, 12),
            new Chest("Black Knight Armor", 13.9, 13.8, 11.7, 12.7, 12.6, 10.5, 13.7, 9.8, 11.5),
            new Chest("Black Leather Armor", 5.9, 8.7, 7.8, 9.4, 6.9, 8.6, 7.8, 10.4, 8.2),
            new Chest("Brass Armor", 10.7, 13, 10.1, 12.7, 11.8, 13.3, 10, 6.9, 10),
            new Chest("Brigand Armor", 4.8, 9, 8.1, 9, 9, 5.9, 7.3, 8.2, 5.9),
            new Chest("Catarina Armor", 17.9, 14.7, 12.8, 15.4, 14.1, 11.4, 12.4, 14.6, 13.1),
            new Chest("Cathedral Knight Armor", 17.8, 14.8, 14.8, 13.6, 15.7, 14.4, 13.3, 14.1, 12.2),
            new Chest("Chain Armor", 8.8, 11.1, 6.8, 12.6, 10, 8.3, 6.6, 4.2, 9),
            new Chest("Clandestine Coat", 3, 4.2, 4.2, 4.2, 3.6, 13.5, 12.9, 13.1, 13.5),
            new Chest("Cleric Blue Robe", 6, 4.9, 7.3, 6, 4.2, 12.8, 12.3, 13.2, 13.2),
            new Chest("Conjurator Robe", 4.2, 3.8, 3.8, 3.8, 3.2, 11.7, 13.6, 13.3, 12.2),
            new Chest("Cornyx's Garb", 4.1, 4.1, 4.1, 4.8, 3.5, 13, 13.7, 12.8, 13.2),
            new Chest("Court Sorcerer Robe", 4.2, 3.6, 4.4, 3.6, 4.4, 12.3, 11.6, 13.5, 13.2),
            new Chest("Dancer's Armor", 7.3, 10.5, 7.4, 12.2, 11.7, 8.3, 6, 9.1, 9.8),
            new Chest("Dark Armor", 9.1, 12.5, 9.2, 11.6, 11.1, 9.2, 7.7, 4.4, 9.2),
            new Chest("Deacon Robe", 3.5, 3.6, 3.6, 4.4, 3.6, 12.5, 12.7, 11.6, 13.2),
            new Chest("Deserter Armor", 8.6, 11.7, 9.3, 11.7, 11.1, 6.6, 7.5, 4.2, 10.4),
            new Chest("Dragonscale Armor", 12.7, 13.7, 12.2, 13.1, 12.2, 9.9, 13.4, 6.1, 9.9),
            new Chest("Dragonslayer Armor", 14.4, 14, 12.2, 14.1, 14.1, 12.4, 13.5, 13.5, 10),
            new Chest("Drakeblood Armor", 13.9, 14.2, 14.1, 16.9, 13.6, 13.2, 12.6, 11.6, 11.6),
            new Chest("Drang Armor", 5.1, 9.3, 8.6, 7.7, 5.5, 9.7, 7.5, 10.9, 9.7),
            new Chest("Eastern Armor", 11, 12.6, 8.6, 14.2, 11.5, 6.7, 11.5, 5.3, 6.7),
            new Chest("Elite Knight Armor", 8.9, 12.1, 9.2, 12.1, 11.1, 9.2, 10.6, 6.8, 8.5),
            new Chest("Enhanced Armor of Favor", 13.2, 12.5, 11.6, 12.3, 12.5, 10.6, 11.1, 7.7, 11.1),
            new Chest("Evangelist Robe", 12.2, 12.8, 12.3, 12.3, 11.6, 10.6, 12.3, 9.9, 6.8),
            new Chest("Executioner Armor", 16.8, 14.7, 11.9, 14.1, 14.5, 13.3, 14.1, 10.9, 13),
            new Chest("Exile Armor", 18.1, 14.7, 14.3, 13.7, 13.3, 12.2, 13.9, 12.4, 12.8),
            new Chest("Fallen Knight Armor", 9.2, 12.6, 12.2, 10, 11.1, 8.3, 12.4, 10.4, 9),
            new Chest("Faraam Armor", 13.1, 13, 12.7, 12.7, 12.3, 10, 11.7, 10.7, 10.7),
            new Chest("Fire Keeper Robe", 5.1, 5.7, 7.1, 7.1, 8, 7.1, 11.9, 8.8, 12.4),
            new Chest("Fire Witch Armor", 11.1, 12.8, 7.7, 10.6, 10.6, 11.6, 12.3, 8.5, 11.1),
            new Chest("Firelink Armor", 8.6, 11.9, 8, 12.6, 10.2, 6.9, 10.7, 5.5, 5.5),
            new Chest("Grave Warden Robe", 3.6, 4.1, 3.1, 8.1, 4.8, 9, 9, 9, 3.6),
            new Chest("Gundyr's Armor", 18, 14.4, 13, 17.2, 13.6, 13, 13.5, 12.8, 13),
            new Chest("Hard Leather Armor", 8.3, 10.3, 10.8, 10.3, 10.3, 8.7, 9.4, 7, 8.7),
            new Chest("Havel's Armor", 22.4, 16.2, 14.5, 15.4, 14.5, 14.1, 16.3, 12.8, 14.1),
            new Chest("Herald Armor", 8.6, 12.4, 8, 12.6, 11.9, 9.2, 8.4, 3.8, 8.4),
            new Chest("Jailer Robe", 4.8, 8.2, 4.2, 8.2, 6, 13.5, 13.1, 11.4, 13.5),
            new Chest("Karla's Coat", 3.6, 3.9, 3.9, 3.9, 2.9, 14.1, 13.3, 13.8, 13.8),
            new Chest("Knight Armor", 10.8, 13.1, 11, 13, 12.4, 7.6, 11, 6.7, 8.4),
            new Chest("Leather Armor", 5.4, 6.8, 6.8, 6.8, 6.8, 8.3, 9, 9.7, 8.3),
            new Chest("Leonhard's Garb", 6.9, 9.8, 9.8, 9.1, 9.8, 12.2, 12.7, 9.8, 8.3),
            new Chest("Lorian's Armor", 15.3, 14.1, 9.4, 13.7, 13.3, 13.1, 10.7, 10.7, 13.3),
            new Chest("Lothric Knight Armor", 15.7, 14, 11.9, 14.9, 13.3, 12.4, 13.5, 9.5, 9.5),
            new Chest("Maiden Robe", 3.5, 3.5, 4.1, 3.5, 3.1, 13.7, 12.8, 13, 13.7),
            new Chest("Master's Attire", 2, 2.7, 2.7, 2.7, 2.1, 9.1, 7.6, 8.4, 9.1),
            new Chest("Mirrah Chain Mail", 10.6, 12.7, 9.8, 13.6, 10.5, 11.2, 11.2, 7.4, 9.1),
            new Chest("Mirrah Vest", 7, 10.5, 10.5, 8.2, 8.2, 10.6, 9.9, 12.8, 9.9),
            new Chest("Morne's Armor", 16.3, 14.3, 12.8, 13.9, 13.7, 13.6, 13.3, 13.1, 8.6),
            new Chest("Nameless Knight Armor", 9.3, 11.7, 10, 12.3, 11.1, 7.6, 11, 8.4, 7.6),
            new Chest("Northern Armor", 10.8, 12.5, 12.1, 12.1, 11.6, 6.8, 11.1, 4.4, 6.8),
            new Chest("Old Sorcerer Coat", 3.7, 3.6, 3.1, 3.1, 3.6, 12.7, 11.6, 12.1, 12.7),
            new Chest("Outrider Knight Armor", 12.3, 13.2, 10, 12.6, 12.7, 9, 10.9, 9, 6.6),
            new Chest("Painting Guardian Gown", 3.5, 4.4, 3.1, 4.4, 4.4, 11.1, 4.4, 5.4, 4.4),
            new Chest("Pale Shade Robe", 3.6, 4.3, 4.3, 4.3, 3.3, 13.4, 12.8, 11.8, 12.3),
            new Chest("Pontiff Knight Armor", 7.3, 9.3, 5.5, 9.3, 8.6, 12.9, 9.3, 11.9, 13.3),
            new Chest("Pyromancer Garb", 4.2, 4.3, 3.5, 3.9, 3.5, 12, 13.1, 12, 14.1),
            new Chest("Robe of Prayer", 3.4, 3.6, 3.2, 3.6, 3.2, 13.5, 13.1, 13.1, 14.6),
            new Chest("Scholar's Robe", 4.2, 6.9, 2.8, 4.5, 5.6, 13.3, 11.2, 12.8, 12.6),
            new Chest("Sellsword Armor", 10.8, 12.2, 12.2, 12.2, 12.2, 10.5, 9.1, 7.3, 10.5),
            new Chest("Shadow Garb", 3.7, 6.8, 5.5, 4.4, 6.8, 4.2, 5.2, 6.6, 4.2),
            new Chest("Silver Knight Armor", 15, 13.4, 12.7, 14.1, 13.7, 12.9, 12.4, 11.4, 11.4),
            new Chest("Smough's Armor", 23.8, 17.1, 18.5, 14.9, 13.8, 13.3, 13, 13.8, 13.1),
            new Chest("Sorcerer Robe", 4.1, 4.5, 4.5, 4.5, 3.8, 13.1, 12.4, 12.6, 13.1),
            new Chest("Sunless Armor", 9.2, 11.7, 9.1, 12.2, 11.7, 11.2, 9.8, 6, 11.7),
            new Chest("Sunset Armor", 14, 13.4, 11.2, 13.6, 13.1, 9.1, 11.2, 8.3, 10.5),
            new Chest("Undead Legion Armor", 7.6, 10.4, 10.4, 5.9, 9, 12.6, 13, 13.2, 10.4),
            new Chest("Winged Knight Armor", 19, 14.5, 13, 14.1, 13.8, 14, 13.8, 14.6, 16),
            new Chest("Wolf Knight Armor", 9, 11.7, 10, 11.9, 11.7, 7.8, 11.2, 5.5, 10),
            new Chest("Worker Garb", 4.2, 4.4, 6.8, 5.5, 5.5, 6.6, 5.2, 5.2, 10.9),
            new Chest("Xanthous Overcoat", 8.6, 10.1, 6.9, 10.7, 9.4, 11.7, 5.5, 10, 11.7)
        };

        Arms[] arms = {
            new Arms("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Arms("Alva Gauntlets", 3.3, 2.9, 2.3, 2.9, 2.8, 2.1, 2.7, 2.1, 2.5),
            new Arms("Antiquated Gloves", 1.1, 1.1, 1.2, 1.1, 1.1, 3.3, 3.7, 3.2, 3.6),
            new Arms("Assassin Gloves", 2, 2, 1.2, 2.3, 1.8, 2.6, 2.7, 1.9, 1.5),
            new Arms("Black Gauntlets", 3.5, 3.2, 2.4, 3.4, 2.9, 2.1, 3.2, 2.2, 3.4),
            new Arms("Black Iron Gauntlets", 5.3, 3.7, 2.8, 3.7, 3.5, 2.7, 3.7, 2.7, 2.9),
            new Arms("Black Knight Gauntlets", 4, 3.4, 2.9, 3.3, 3.1, 2.5, 3.4, 2.3, 2.8),
            new Arms("Black Leather Gloves", 2, 2.2, 2, 2.3, 1.8, 2.1, 1.9, 2.9, 2.3),
            new Arms("Black Leather Gloves", 2.3, 2.2, 2, 2.3, 1.8, 2.1, 1.9, 2.9, 2.3),
            new Arms("Brass Gauntlets", 3.5, 3.4, 2.6, 3.3, 3.1, 3.5, 2.7, 1.9, 2.7),
            new Arms("Brigand gauntlets", 2.4, 2.5, 2.3, 2.5, 2.5, 1.9, 2.1, 2.3, 1.9),
            new Arms("Catarina Gauntlets", 6, 3.8, 3.4, 4.2, 3.7, 3, 3.3, 3.8, 3.4),
            new Arms("Cathedral Knight Gauntlets", 5.5, 3.8, 3.7, 3.5, 3.9, 3.6, 3.4, 3.6, 3),
            new Arms("Cleric Gloves", 1.5, 1.1, 0.7, 0.7, 0.9, 2.8, 2.1, 2.8, 2.9),
            new Arms("Conjurator Manchettes", 1.4, 0.8, 0.8, 0.8, 0.6, 2.7, 3.2, 3.1, 2.9),
            new Arms("Cornyx's Wrap", 1.3, 0.9, 0.9, 1.1, 0.8, 3.6, 3.4, 3.3, 3.4),
            new Arms("Court Sorcerer Gloves", 1, 1, 1.1, 1, 1.1, 3.2, 3, 3.6, 3.5),
            new Arms("Dancer's Gauntlets", 2.4, 2.8, 2, 3.2, 3.1, 2.2, 1.7, 2.4, 2.6),
            new Arms("Dark Gauntlets", 3.2, 3.5, 2.6, 3.2, 3.1, 2.6, 2.2, 1.4, 2.6),
            new Arms("Deserter Trousers", 3.1, 4.2, 4.7, 4.2, 4.2, 5, 5, 5.9, 7),
            new Arms("Dragonslayer Gauntlets", 4.2, 3.5, 2.9, 3.5, 3.5, 3.2, 3.6, 3.6, 2.4),
            new Arms("Drakeblood Gauntlets", 4.6, 3.5, 3.4, 4.3, 3.3, 3.1, 2.9, 2.7, 2.7),
            new Arms("Drang Gauntlets", 1.7, 2.1, 1.9, 1.7, 1.1, 2, 1.4, 2.3, 2),
            new Arms("Eastern Gauntlets", 2.9, 2.8, 2.2, 3.3, 2.5, 1.8, 3.1, 1.5, 1.8),
            new Arms("Elite Knight Gauntlets", 3.4, 3.4, 2.8, 3.4, 3.4, 2.6, 3, 2, 2.4),
            new Arms("Evangelist Gloves", 2.4, 1.8, 2.5, 1.6, 1.4, 2.6, 2.8, 2.8, 1.4),
            new Arms("Executioner gauntlets", 5.6, 3.7, 2.9, 3.7, 3.4, 3.3, 3.5, 2.7, 3.2),
            new Arms("Exile Gauntlets", 5.8, 3.8, 3.6, 3.5, 3.4, 3.1, 3.6, 3.3, 3.4),
            new Arms("Fallen Knight Gauntlets", 3.1, 3.3, 3.2, 2.6, 2.9, 2.4, 3.7, 3, 2.2),
            new Arms("Faraam Gauntlets", 4.8, 3.3, 3.4, 3.2, 3.1, 2.9, 3.3, 3, 3),
            new Arms("Fire Keeper Gloves", 1.3, 0.8, 0.9, 1.1, 0.7, 3.1, 3.3, 2.9, 3.6),
            new Arms("Fire Witch Gauntlets", 2.6, 2.8, 1.4, 2.4, 2.2, 2.4, 2.6, 1.4, 2.2),
            new Arms("Firelink Gauntlets", 2.7, 2.3, 2.1, 2.7, 1.9, 3, 3.3, 3.1, 2.5),
            new Arms("Gauntlets of Favor", 4.1, 4.4, 3.1, 3.4, 3.4, 2.8, 3, 2, 3),
            new Arms("Gauntlets of Thorns", 2.8, 2.8, 2.1, 3.4, 2.9, 1.9, 1.9, 1.9, 1.6),
            new Arms("Golden Bracelets", 1.5, 1.7, 1.9, 1.5, 0.9, 1.7, 2.3, 1.7, 1.7),
            new Arms("Grave Warden Robe", 3.6, 4.1, 3.1, 8.1, 4.8, 9, 9, 9, 3.6),
            new Arms("Hard Leather Gauntlets", 2, 2.1, 2.2, 2.1, 2.1, 1.5, 1.7, 1, 2),
            new Arms("Havel's Gauntlets", 9.4, 4, 3.6, 3.8, 3.6, 3.5, 4.1, 3.2, 3.5),
            new Arms("Herald Gloves", 2.9, 3.1, 2.1, 3.1, 2.9, 1.7, 2.1, 0.7, 1.5),
            new Arms("Iron Bracelets", 2.9, 2.4, 1.6, 2.4, 2.4, 2.2, 2.2, 2, 2.2),
            new Arms("Jailer Gloves", 1.6, 1.7, 0.7, 1.7, 1.1, 2.7, 2.6, 2.2, 2.7),
            new Arms("Karla's Gloves", 2.4, 3.2, 2.4, 3.4, 2.9, 2.1, 3.2, 2.2, 3.4),
            new Arms("Knight Gauntlets", 3.6, 3.6, 3, 3.5, 3.4, 2.3, 2.9, 2.1, 2.5),
            new Arms("Leather gauntlets", 2.5, 2.2, 2, 2.9, 2, 3.2, 2.6, 3.2, 3.3),
            new Arms("Leather Gloves", 1.5, 1.4, 1.4, 1.4, 1.4, 1.9, 2.1, 2.3, 1.9),
            new Arms("Leonhard's Gauntlets", 2.8, 2.6, 3, 2.8, 2.6, 3.4, 3.4, 2.8, 2.4),
            new Arms("Lothric Knight Gauntlets", 5, 3.4, 2.8, 3.6, 3.2, 2.9, 3.3, 2.1, 2.7),
            new Arms("Maiden Gloves", 1.3, 0.9, 1.1, 0.9, 0.8, 3.5, 3.3, 3.4, 3.5),
            new Arms("Master's Gloves", 0.3, 0.4, 0.4, 0.4, 0.3, 1.9, 1.5, 1.7, 1.9),
            new Arms("Mirrah Chain Gloves", 3.3, 3.2, 2.4, 3.5, 2.6, 2.8, 2.8, 1.7, 2.2),
            new Arms("Mirrah Gloves", 2.1, 2.1, 2.1, 1.5, 1.5, 1.9, 1.7, 2.5, 1.7),
            new Arms("Morne's Gauntlets", 5, 3.3, 3, 3.2, 3.1, 3.1, 3, 3, 1.5),
            new Arms("Nameless Knight Gauntlets", 2.8, 3, 2.6, 3.3, 2.9, 2.1, 3.1, 2.3, 2.1),
            new Arms("Northern Gloves", 2.3, 2.2, 2.8, 2.2, 2.2, 0.8, 2.5, 2, 0.8),
            new Arms("Old Sorcerer Gauntlets", 1.3, 0.9, 0.8, 0.8, 0.9, 3.2, 2.9, 3.1, 3.2),
            new Arms("Outrider Knight Gauntlets", 2.9, 3.4, 2.4, 3.3, 3.4, 2.4, 3, 2.4, 1.6),
            new Arms("Painting Guardian Gloves", 1.3, 0.8, 0.5, 0.8, 0.8, 2.5, 0.8, 1.1, 0.8),
            new Arms("Pale Shade Gloves", 1, 1.2, 1.2, 1.2, 1.1, 3.6, 3.3, 3.1, 3.2),
            new Arms("Pontiff Knight Gauntlets", 2.2, 2.1, 1.1, 2.1, 1.9, 3.6, 2.6, 3.3, 3.7),
            new Arms("Pyromancer Wrap", 1.5, 1.5, 1.5, 0.9, 1.3, 3.5, 3.6, 3.5, 3.6),
            new Arms("Sellsword Gauntlet", 1.4, 1.4, 1.4, 0.8, 1.6, 0.6, 0.8, 0.8, 0.6),
            new Arms("Shadow Gauntlets", 1.3, 1.6, 1.4, 1.6, 1.6, 1.6, 1.9, 2.2, 1.6),
            new Arms("Silver Knight Gauntlets", 4.7, 3.5, 2.9, 3.6, 3.6, 2.9, 2.8, 2.5, 2.5),
            new Arms("Smough's Gauntlets", 9.7, 4.3, 4.7, 3.7, 3.4, 3.3, 3.2, 3.4, 3.5),
            new Arms("Sorcerer Gloves", 1.3, 1.3, 1.3, 1.3, 1.1, 3.5, 3.3, 3.4, 3.5),
            new Arms("Sunset Gauntlets", 4.9, 3.7, 3.4, 3.6, 3.5, 2.4, 3, 2.2, 2.8),
            new Arms("Undead Legion Gauntlet", 2.4, 2.3, 2.3, 1.2, 2, 2.9, 3, 3, 2.3),
            new Arms("Winged Knight Gauntlets", 5.5, 3.8, 3.3, 3.7, 3.5, 3.5, 3.9, 3.7, 4.3),
            new Arms("Wolf Knight Gauntlets", 3.3, 2.7, 2.3, 2.9, 2.7, 1.7, 2.6, 1.2, 2.7),
            new Arms("Worker Gloves", 1.4, 0.9, 1.5, 1.1, 1.1, 1.2, 0.9, 0.9, 2.3),
            new Arms("Xanthous Gloves", 2, 1.8, 2, 1.2, 1.8, 2.7, 1.2, 2.9, 2.6)
        };

        Leggings[] leggings = {
            new Leggings("none", 0, 0, 0, 0, 0, 0, 0, 0, 0),
            new Leggings("Alva Leggings", 5.5, 6.8, 5.4, 6.8, 6.5, 5, 6.2, 5, 5.8),
            new Leggings("Archdeacon Skirt", 2.6, 2.4, 4.2, 2.9, 2.9, 7.7, 7.2, 7.7, 8.5),
            new Leggings("Antiquated Skirt", 2.1, 1.5, 1.8, 1.5, 1.2, 6.7, 7.5, 6.4, 7),
            new Leggings("Assassin Trousers", 4.3, 5.2, 3.8, 6, 4.8, 6.6, 6.9, 5.2, 4.3),
            new Leggings("Black Iron Leggings", 9.9, 8.7, 6.7, 8.5, 8.3, 7.2, 8.9, 6.6, 7.2),
            new Leggings("Black Knight Leggings", 8.5, 8.1, 6.7, 7.6, 7.4, 6.2, 8.3, 5.8, 6.9),
            new Leggings("Black Leather Boots", 3.6, 4.8, 4.3, 5.2, 3.8, 4.8, 4.3, 5.6, 4.3),
            new Leggings("Black Leather Boots", 3.6, 4.8, 4.3, 5.2, 3.8, 4.8, 4.3, 5.6, 4.3),
            new Leggings("Black Leggins", 4.5, 5.2, 5.2, 6.4, 4.7, 6.7, 8.1, 7.3, 7.8),
            new Leggings("Brass Leggings", 6.8, 7.9, 5.9, 7.5, 6.9, 7.9, 6, 4.2, 60),
            new Leggings("Brigand Trousers", 5, 6, 5.6, 6, 6, 4.8, 5.2, 5.6, 4.8),
            new Leggings("Catarina Leggins", 11.1, 8.5, 7.4, 9.3, 8.3, 6, 6.6, 7.8, 6.8),
            new Leggings("Cathedral Knight Leggings", 10.2, 7.7, 7.6, 7, 8, 7.4, 6.9, 7.3, 5.9),
            new Leggings("Chain Leggings", 5.1, 6.7, 4.2, 7.6, 6, 5.5, 4.5, 3.1, 5.9),
            new Leggings("Cleric Trousers", 2.1, 2.4, 1.6, 1.6, 1.9, 6.9, 5, 6.8, 7),
            new Leggings("Conjurator Boots", 2.6, 2.3, 2.3, 2.3, 2, 7, 8.1, 7.9, 7.3),
            new Leggings("Cornyx's Skirt", 2, 1.7, 1.7, 1.7, 1.5, 6.9, 7.1, 6.6, 7),
            new Leggings("Court Sorcerer Trouser", 2.2, 2.2, 2.5, 2.2, 2.5, 7.4, 6.8, 8, 7.9),
            new Leggings("Dancer's Leggings", 4.4, 6, 4.2, 7, 6.7, 4.7, 3.4, 4.7, 5.1),
            new Leggings("Dark Leggings", 6.1, 7.8, 5.7, 7.1, 6.8, 6.1, 5.3, 2.9, 6.1),
            new Leggings("Deacon Skirt", 2.3, 1.1, 1.7, 2.1, 1.7, 6.8, 6.9, 6.3, 7.2),
            new Leggings("Deserter Trousers", 3.1, 4.2, 4.7, 4.2, 4.2, 5, 5, 5.9, 7),
            new Leggings("Dragonscale WaistCloth", 6.3, 6.9, 5.8, 7.1, 5.8, 4.1, 6.8, 1.8, 4.1),
            new Leggings("Dragonslayer Leggings", 8.4, 7.4, 6.2, 7.4, 7.4, 6, 6.8, 6.8, 4.5),
            new Leggings("Drakeblood Leggings", 8.3, 7.9, 7.8, 9.5, 7.5, 7.2, 6.9, 6.3, 6.3),
            new Leggings("Drang Shoes", 4.2, 4.7, 5.2, 5.2, 5.2, 6.3, 5, 7, 6.3),
            new Leggings("Eastern Leggings", 5, 5.1, 4.7, 7.3, 4.6, 5.4, 7.2, 6.6, 5.4),
            new Leggings("Elite Knight Leggings", 6.9, 7.8, 6.5, 7.6, 7.4, 6.5, 7.1, 5.3, 6.1),
            new Leggings("Evangelist Trousers", 4.6, 5.5, 6.9, 5.1, 4.6, 6.6, 7.3, 7.3, 4.6),
            new Leggings("Executioner Leggings", 10.4, 8.4, 6.8, 8.1, 8.3, 7.7, 7.9, 6.2, 7.4),
            new Leggings("Exile Leggings", 10.9, 8.7, 8.4, 8, 7.5, 7.3, 8.3, 7.4, 7.6),
            new Leggings("Fallen Knight Trousers", 5.3, 7.3, 7, 5.6, 6.4, 5, 7.8, 6.3, 5.5),
            new Leggings("Faraam Boots", 6.8, 7.2, 7.2, 7.2, 6.6, 5.2, 6.4, 5.6, 5.6),
            new Leggings("Fire Keeper Skirt", 2.1, 1.9, 2.6, 1.9, 1.9, 7.1, 7.6, 6.8, 8.3),
            new Leggings("Fire Witch Leggings", 5.5, 7.4, 3.5, 5.7, 5.7, 6.5, 7.1, 4.3, 6.1),
            new Leggings("Firelink Leggings", 4.8, 5.4, 5, 6.2, 4.5, 6, 7.3, 7, 5.6),
            new Leggings("Grave Warden Skirt", 2.2, 2, 1.5, 4.3, 2.5, 4.8, 4.8, 6, 1.7),
            new Leggings("Hard Leather Boots", 4.7, 5.1, 5.5, 5.1, 5.1, 4.1, 4.3, 2.8, 4.1),
            new Leggings("Havel's Leggings", 15.9, 9.3, 8.3, 8.9, 8.3, 8.1, 9.4, 7.3, 8.1),
            new Leggings("Herald Trousers", 5.3, 7.1, 6.5, 6.8, 6.5, 4.6, 4.6, 1.8, 4.1),
            new Leggings("Iron Leggings", 5, 5.9, 4.2, 5.9, 5.9, 5.5, 5.5, 5.1, 5.5),
            new Leggings("Jailer Trousers", 2.8, 4.2, 1.9, 4.2, 3, 6.9, 6.7, 5.7, 6.9),
            new Leggings("Karla's Trousers", 2.6, 2.6, 2.6, 2.6, 1.9, 8.3, 7.7, 8.1, 8.1),
            new Leggings("Knight Leggins", 6.7, 8.1, 6.9, 7.34, 7.7, 4.9, 6.2, 4.4, 5.4),
            new Leggings("Leather Boots", 3.3, 4.2, 4.2, 4.2, 4.2, 5.5, 5.9, 6.3, 5.5),
            new Leggings("Leggings of Favor", 7.7, 7.4, 6.8, 7.4, 7.5, 6.1, 6.5, 4.3, 6.5),
            new Leggings("Leggins of Thorns", 5.4, 6, 4.3, 7.3, 6.3, 3.8, 3.8, 3.8, 3),
            new Leggings("Leonhard's Trousers", 3.6, 4.2, 5.1, 4.2, 4.7, 6.2, 6.5, 4.7, 3.7),
            new Leggings("Lothric Knight Leggins", 9.3, 7.9, 6.5, 8.3, 7.4, 6.8, 7.6, 5, 6.2),
            new Leggings("Maiden Skirt", 2.3, 1.7, 2, 1.7, 1.5, 7.5, 7, 7.1, 7.5),
            new Leggings("Mirrah Chain Leggins", 5.9, 6.5, 4.7, 7.1, 5.1, 5.5, 5.5, 2.9, 4.2),
            new Leggings("Mirrah Trousers", 3.5, 5.1, 5.1, 3.7, 3.7, 5, 4.6, 6.4, 4.6),
            new Leggings("Morne's Leggings", 9.7, 8.3, 7.5, 8, 7.8, 7.9, 7.8, 7.6, 4.7),
            new Leggings("Nameless Knight Leggins", 5.6, 7, 6, 7.4, 6.7, 4.9, 6.9, 5.4, 4.9),
            new Leggings("Northern Trousers", 4.3, 6.1, 7.5, 6.1, 6.1, 2.9, 6.8, 5.7, 2.9),
            new Leggings("Old Sorcerer Boots", 2.3, 2.1, 1.8, 1.8, 2.1, 7.3, 6.7, 7, 7.3),
            new Leggings("Outrider Knight Leggins", 6.9, 7.7, 5.6, 7.4, 7.6, 5.5, 6.7, 5.5, 3.7),
            new Leggings("Painting Guardian Waistcloth", 4.4, 3.5, 2.9, 3.5, 4.8, 6.5, 5.3, 2.9, 2.9),
            new Leggings("Pale Shade Trousers", 2.2, 1.8, 1.8, 1.8, 1.2, 7, 6.7, 6.1, 6.4),
            new Leggings("Pontiff Knight Leggins", 4.3, 5.1, 3, 5.1, 4.7, 7.6, 5.5, 7, 7.8),
            new Leggings("Pyromancer Trousers", 2.6, 3, 2.6, 2.2, 2.6, 7.5, 8.1, 7.5, 7.8),
            new Leggings("Sellsword Trousers", 3.6, 4.7, 5.1, 4.2, 4.7, 2.3, 3.7, 2.3, 2.3),
            new Leggings("Shadow Leggings", 2.3, 4.2, 3.5, 2.9, 4.2, 3.1, 3.7, 4.5, 3.1),
            new Leggings("Silver Knight Leggins", 9.1, 7.6, 7, 7.9, 7.9, 7.3, 7, 6.3, 6.3),
            new Leggings("Skirt of Prayer", 2, 1.6, 1.9, 1.6, 1.4, 6.9, 6.7, 6.7, 7.6),
            new Leggings("Smough's Leggings", 16.3, 9.9, 10.7, 8.5, 7.9, 7.6, 7.4, 7.9, 7.6),
            new Leggings("Sorcerer Trousers", 3.2, 3.4, 4.1, 3.4, 3.4, 6, 7.5, 7.6, 6.7),
            new Leggings("Sunset Leggings", 7.7, 7.2, 5.5, 7.4, 7.2, 4.1, 5.5, 3.3, 5.1),
            new Leggings("Undead Legion Leggings", 4.6, 5.6, 5.6, 3.1, 4.8, 6.9, 7.1, 7.2, 5.6),
            new Leggings("Winged Knight Leggings", 11, 8.3, 7.4, 8.1, 7.9, 7.1, 6.9, 7.4, 8),
            new Leggings("Wolf Knight Leggings", 5.1, 6.7, 5.6, 6.5, 6.7, 4.2, 6.4, 2.8, 5.6),
            new Leggings("Worker Trousers", 2.9, 2.9, 4.2, 3.5, 3.5, 4.5, 3.7, 3.7, 7),
            new Leggings("Xanthous trousers", 3.9, 4.6, 5.1, 3.4, 4.6, 7, 3.4, 7.4, 6.7)
        };


        Ring[] rings = {
            new RingBaseStats("none", 0),
            new RingByPercentage("Life Ring", .3, vigorMod : 7),
            new RingByPercentage("Ring of Favor", 1.5, hpMod : 3, staminaMod : 9, equiploadMod : 5),
            new RingBaseStats("Prisoner's Chain", .8, vigorMod : 5, enduranceMod : 5, vitalityMod : 5, physicalMod : -4, strikeMod : -4, slashMod : -4, thrustMod : -4, magicMod : -4, fireMod : -4, lightningMod : -4, darkMod : -4),
            new RingByPercentage("Havel's Ring", 1.5, equiploadMod : 15),
            new RingBaseStats("Ring of Steel Protection", .8, physicalMod : 10, strikeMod : 10, slashMod : 10, thrustMod : 10),
            new RingBaseStats("Magic Stoneplate Ring", .6, magicMod : 13),
            new RingBaseStats("Fire Stoneplate Ring", .6, fireMod : 13),
            new RingBaseStats("Thunder Stoneplate Ring", .6, lightningMod : 13),
            new RingBaseStats("Dark Stoneplate Ring", .6, darkMod : 13),
            new RingBaseStats("Speckled Stoneplate Ring", .9, magicMod : 5, fireMod : 5, lightningMod : 5, darkMod : 5),
            new RingByPercentage("Dusk Crown Ring", .6, hpMod : -20),
            new RingBaseStats("Knight's Ring", 0.8, strengthMod : 5),
            new RingBaseStats("Hunter's Ring", 0.8, dexterityMod : 5),
            new RingBaseStats("Scholar Ring", .6, intelligenceMod : 5),
            new RingBaseStats("Priestess Ring", 0.6, faithMod : 5),
            new RingBaseStats("Saint's Ring", 0.5, attunementMod : 1),
            new RingBaseStats("Deep Ring", 0.5, attunementMod : 1),
            new RingBaseStats("Darkmoon Ring", 0.8, attunementMod : 2),
            new RingBaseStats("Magic Cluth Ring", 0.8, magicMod : -10),
            new RingBaseStats("Lightning Cluth Ring", 0.8, lightningMod : -10),
            new RingBaseStats("Fire Cluth Ring", 0.8, fireMod : -10),
            new RingBaseStats("Dark Cluth Ring", 0.8, darkMod : -10),
            new RingBaseStats("Carthus Milkring", 0.8, dexterityMod : 3),
            new RingBaseStats("Carthus Bloodring", 0.8, physicalMod : -15, strikeMod : -15, slashMod : -15, thrustMod : -15, magicMod : -15, fireMod : -15, lightningMod : -15, darkMod : -15),
            new RingBaseStats("Young Dragon Ring", 0.7),
            new RingBaseStats("Bellowing Dragoncrest Ring", 1),
            new RingBaseStats("Great Swamp Ring", 0.7),
            new RingBaseStats("Witch's Ring", 1),
            new RingBaseStats("Morne's Ring", .7),
            new RingBaseStats("Ring of the Sun's First Born", 1),
            new RingBaseStats("Lingering Dragoncrest Ring", .5),
            new RingBaseStats("Sage Ring", .7),
            new RingBaseStats("Leo Ring", 0.5),
            new RingBaseStats("Wolf Ring", 0.5),
            new RingBaseStats("Hawk Ring", 0.7),
            new RingBaseStats("Hornet Ring", 1.1),
            new RingBaseStats("Knight Slayer's Ring", 0.9),
            new RingBaseStats("Ring of the Evil Eye", 1),
            new RingBaseStats("Farron Ring", 0.8),
            new RingBaseStats("Dragonscale Ring", 1.1),
            new RingBaseStats("Horsehoof Ring", 0.6),
            new RingBaseStats("Wood Grain Ring", 0.5),
            new RingBaseStats("Flynn's Ring", 0.9),
            new RingBaseStats("Covetous Gold Serpent Ring", 1.2),
            new RingBaseStats("Covetous Silver Serpent Ring", 1.2),
            new RingBaseStats("Bloodbite Ring", 0.6),
            new RingBaseStats("Poisonbite Ring", 0.6),
            new RingBaseStats("Cursebite Ring", 0.6),
            new RingBaseStats("Fleshbite Ring", 0.9),
            new RingBaseStats("Sun Princess Ring", .6),
            new RingBaseStats("Estus Ring", .8),
            new RingBaseStats("Ashen Estus Ring", 0.8),
            new RingBaseStats("Chloranthy Ring", 0.7)

                //   new Ring("Prisoner's Chain", 1, vigorBonus() : 5, enduranceBonus() : 5, vitalityBonus() : 5)
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

            vigor = stclass.vigorBase + character.vigorModifier + ring1.vigorBonus() + ring2.vigorBonus() + ring3.vigorBonus() + ring4.vigorBonus();
            Vigortxt.Text = vigor.ToString();

            attunement = stclass.attunementBase + character.attunementModifier + ring1.attunementBonus() + ring2.attunementBonus() + ring3.attunementBonus() + ring4.attunementBonus();
            Attunementtxt.Text = attunement.ToString();

            endurance = stclass.enduranceBase + character.enduranceModifier + ring1.enduranceBonus() + ring2.enduranceBonus() + ring3.enduranceBonus() + ring4.enduranceBonus();
            Endurancetxt.Text = endurance.ToString();

            vitality = stclass.vitalityBase + character.vitalityModifier + ring1.vitalityBonus() + ring2.vitalityBonus() + ring3.vitalityBonus() + ring4.vitalityBonus();
            Vitalitytxt.Text = vitality.ToString();

            strength = stclass.strengthBase + character.strengthModifier + ring1.strengthBonus() + ring2.strengthBonus() + ring3.strengthBonus() + ring4.strengthBonus();
            Strengthtxt.Text = strength.ToString();

            dexterity = stclass.dexterityBase + character.dexterityModifier + ring1.dexterityBonus() + ring2.dexterityBonus() + ring3.dexterityBonus() + ring4.dexterityBonus();
            Dexteritytxt.Text = dexterity.ToString();

            intelligence = stclass.intelligenceBase + character.intelligenceModifier + ring1.intelligenceBonus() + ring2.intelligenceBonus() + ring3.intelligenceBonus() + ring4.intelligenceBonus();
            Intelligencetxt.Text = intelligence.ToString();

            faith = stclass.faithBase + character.faithModifier + ring1.faithBonus() + ring2.faithBonus() + ring3.faithBonus() + ring4.faithBonus();
            Faithtxt.Text = faith.ToString();

            luck = stclass.luckBase + character.luckModifier + ring1.luckBonus() + ring2.luckBonus() + ring3.luckBonus() + ring4.luckBonus();
            Lucktxt.Text = luck.ToString();


            //This section sets all of the defense values=======================================================
            //yes this really goofy equation is actually what the game uses

            double physical, strike, slash, thrust, magic, fire, lightning, dark;

            physical = heads[Headcmb.SelectedIndex].physical + ring1.physicalBonus() + ring2.physicalBonus() + ring3.physicalBonus() + ring4.physicalBonus();
            physical += (100 - physical) * (chests[Chestcmb.SelectedIndex].physical / 100);
            physical += (100 - physical) * (arms[Armscmb.SelectedIndex].physical / 100);
            physical += (100 - physical) * (leggings[Leggingscmb.SelectedIndex].physical / 100);
            Physicaltxt.Text = physical.ToString();

            strike = heads[Headcmb.SelectedIndex].strike + ring1.strikeBonus() + ring2.strikeBonus() + ring3.strikeBonus() + ring4.strikeBonus();
            strike += (100 - strike) * (chests[Chestcmb.SelectedIndex].strike / 100);
            strike += (100 - strike) * (arms[Armscmb.SelectedIndex].strike / 100);
            strike += (100 - strike) * (leggings[Leggingscmb.SelectedIndex].strike / 100);
            VSstriketxt.Text = strike.ToString();

            slash = heads[Headcmb.SelectedIndex].slash + ring1.slashBonus() + ring2.slashBonus() + ring3.slashBonus() + ring4.slashBonus();
            slash += (100 - slash) * (chests[Chestcmb.SelectedIndex].slash / 100);
            slash += (100 - slash) * (arms[Armscmb.SelectedIndex].slash / 100);
            slash += (100 - slash) * (leggings[Leggingscmb.SelectedIndex].slash / 100);
            VSslashtxt.Text = slash.ToString();

            thrust = heads[Headcmb.SelectedIndex].thrust + ring1.thrustBonus() + ring2.thrustBonus() + ring3.thrustBonus() + ring4.thrustBonus();
            thrust += (100 - thrust) * (chests[Chestcmb.SelectedIndex].thrust / 100);
            thrust += (100 - thrust) * (arms[Armscmb.SelectedIndex].thrust / 100);
            thrust += (100 - thrust) * (leggings[Leggingscmb.SelectedIndex].thrust / 100);
            VSthrusttxt.Text = thrust.ToString();

            magic = heads[Headcmb.SelectedIndex].magic + ring1.magicBonus() + ring2.magicBonus() + ring3.magicBonus() + ring4.magicBonus();
            magic += (100 - magic) * (chests[Chestcmb.SelectedIndex].magic / 100);
            magic += (100 - magic) * (arms[Armscmb.SelectedIndex].magic / 100);
            magic += (100 - magic) * (leggings[Leggingscmb.SelectedIndex].magic / 100);
            Magictxt.Text = magic.ToString();

            fire = heads[Headcmb.SelectedIndex].fire + ring1.fireBonus() + ring2.fireBonus() + ring3.fireBonus() + ring4.fireBonus();
            fire += (100 - fire) * (chests[Chestcmb.SelectedIndex].fire / 100);
            fire += (100 - fire) * (arms[Armscmb.SelectedIndex].fire / 100);
            fire += (100 - fire) * (leggings[Leggingscmb.SelectedIndex].fire / 100);
            Firetxt.Text = fire.ToString();

            lightning = heads[Headcmb.SelectedIndex].lightning + ring1.lightningBonus() + ring2.lightningBonus() + ring3.lightningBonus() + ring4.lightningBonus();
            lightning += (100 - lightning) * (chests[Chestcmb.SelectedIndex].lightning / 100);
            lightning += (100 - lightning) * (arms[Armscmb.SelectedIndex].lightning / 100);
            lightning += (100 - lightning) * (leggings[Leggingscmb.SelectedIndex].lightning / 100);
            Lightningtxt.Text = lightning.ToString();

            dark = heads[Headcmb.SelectedIndex].dark + ring1.darkBonus() + ring2.darkBonus() + ring3.darkBonus() + ring4.darkBonus();
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

            hp = hp + rings[Ring1cmb.SelectedIndex].hpBonus(Convert.ToInt32(hp));
            hp = hp + rings[Ring2cmb.SelectedIndex].hpBonus(Convert.ToInt32(hp));
            hp = hp + rings[Ring3cmb.SelectedIndex].hpBonus(Convert.ToInt32(hp));
            hp = hp + rings[Ring4cmb.SelectedIndex].hpBonus(Convert.ToInt32(hp));

            HPtxt.Text = String.Format("{0:0}", hp);

            fp = (.1147 * Math.Pow(attunement, 2)) + (2.3654 * attunement) + 57.773;

            fp = fp + rings[Ring1cmb.SelectedIndex].fpBonus(Convert.ToInt32(fp));
            fp = fp + rings[Ring2cmb.SelectedIndex].fpBonus(Convert.ToInt32(fp));
            fp = fp + rings[Ring3cmb.SelectedIndex].fpBonus(Convert.ToInt32(fp));
            fp = fp + rings[Ring4cmb.SelectedIndex].fpBonus(Convert.ToInt32(fp));

            FPtxt.Text = String.Format("{0:0}", fp);


            stamina = (.019 * Math.Pow(endurance, 2)) + (1.2616 * endurance) + 78.992;

            stamina = stamina + rings[Ring1cmb.SelectedIndex].staminaBonus(Convert.ToInt32(stamina));
            stamina = stamina + rings[Ring2cmb.SelectedIndex].staminaBonus(Convert.ToInt32(stamina));
            stamina = stamina + rings[Ring3cmb.SelectedIndex].staminaBonus(Convert.ToInt32(stamina));
            stamina = stamina + rings[Ring4cmb.SelectedIndex].staminaBonus(Convert.ToInt32(stamina));

            if (stamina > 160)
                stamina = 160;

            Staminatxt.Text = String.Format("{0:0}", stamina);


            equipLoad = 40 + vitality;

            equipLoad = equipLoad + rings[Ring1cmb.SelectedIndex].equiploadBonus(equipLoad);
            equipLoad = equipLoad + rings[Ring2cmb.SelectedIndex].equiploadBonus(equipLoad);
            equipLoad = equipLoad + rings[Ring3cmb.SelectedIndex].equiploadBonus(equipLoad);
            equipLoad = equipLoad + rings[Ring4cmb.SelectedIndex].equiploadBonus(equipLoad);

            EquipLoadtxt.Text = String.Format("{0:0.0}", equipLoad);

            equipLoadUsed = weapons[R1cmb.SelectedIndex].WGT + weapons[R2cmb.SelectedIndex].WGT + weapons[R3cmb.SelectedIndex].WGT + weapons[L1cmb.SelectedIndex].WGT + weapons[L2cmb.SelectedIndex].WGT + weapons[L3cmb.SelectedIndex].WGT + rings[Ring1cmb.SelectedIndex].WGT + rings[Ring2cmb.SelectedIndex].WGT + rings[Ring3cmb.SelectedIndex].WGT + rings[Ring4cmb.SelectedIndex].WGT + heads[Headcmb.SelectedIndex].WGT + chests[Chestcmb.SelectedIndex].WGT + arms[Armscmb.SelectedIndex].WGT + leggings[Leggingscmb.SelectedIndex].WGT;
            ELUsedtxt.Text = String.Format("{0:0.0}", equipLoadUsed);


            equipLoadPercent = (equipLoadUsed / equipLoad) * 100;
            PercentELtxt.Text = String.Format("{0:0.0}", equipLoadPercent) + "%";

            if (attunement == 99)
                attuneSlots = 10 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 80 )
                attuneSlots = 9 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 60 )
                attuneSlots = 8 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 50)
                attuneSlots = 7 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 40)
                attuneSlots = 6 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 30)
                attuneSlots = 5 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 24)
                attuneSlots = 4 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 18)
                attuneSlots = 3 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else if (attunement >= 14)
                attuneSlots = 2 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;
            else
                attuneSlots = 1 + rings[Ring1cmb.SelectedIndex].attunementBonus() + rings[Ring2cmb.SelectedIndex].attunementBonus() + rings[Ring3cmb.SelectedIndex].attunementBonus() + rings[Ring4cmb.SelectedIndex].attunementBonus() - character.attuneSlotModifier;

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

                Spellslb.Items.Add(spells[AddSpellcmb.SelectedIndex].getSpellString());
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
