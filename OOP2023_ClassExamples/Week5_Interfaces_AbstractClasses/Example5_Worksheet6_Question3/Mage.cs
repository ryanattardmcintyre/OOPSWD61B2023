using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example5_Worksheet6_Question3
{
    public class Mage: Character
    {
        //health of 100, initial mana of 300 and damage of 75. 
        public Mage() : base(300, 100, 75) { }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= (Damage * 2);
        }
    }
}
