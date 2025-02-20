using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleState_RPG.Characters
{
    internal class PlayerCharacter
    {
        //Core
        String name  = "" ;
        int hp       = 0  ;  
        int maxhp    = 10 ;
        int ca       = 10 ;//Armor Class define the difficult to hit you. It is embased on the armor that you use or your habilities as a warrior (10 + dexterity)
        int level    = 0  ; 
        int maxlevel = 100;

        //Attributes | They are Bonus that you gain to roll the dices. Help in situations according to the needs of it.
        int strength    = 0;
        int dexterity   = 0;
        int vitality    = 0;
        int inteligence = 0;
        int charism     = 0;

        //Habillities
        int wh = 1;         //Warrior Hability - Responsable for define the difficult level to dodge and block your attacks.
        int mh = 1;         //Mage Hability - Responsable for define the difficult level to dodge your magics.

        //Actions
        int damage      = 1;       //Damage is the extent that you hurts your oponent [WeaponDamage + strength].
        int ctrDamage   = 1;       //Critic Damage is your damage times two. You only get a Critical Damage when get natural 20 on dice roll.
        int accuracy    = 1;       //Accuracy action is the Bonus thath you have to hit your enemy with ranged weapons or guns [dexterity].
        int dodge       = 1;       //Dodge action is the Bonus that you have to avoid attacks and take no damage (10 + dexterity).
        int block       = 1;       //Block action is the Bonus that you have to decrease attacks damage (10 + strength) [Damage decreased = 2 + strength].

        //Geral
        int gold        = 100;


        //Private Functions
        private void CalculateStats()
        {
            this.hp = this.vitality + 5;
            this.ctrDamage = damage * 2;
            this.damage += strength;
            this.accuracy += dexterity;
            this.block = this.wh + this.strength;
            this.dodge = this.wh + this.dexterity;
        }


        public PlayerCharacter(String Name) 
        {
            CalculateStats();  
            this.name = Name;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
