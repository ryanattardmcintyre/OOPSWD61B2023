using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example5_Worksheet6_Question3
{
    public class Warrior:Character
    {
        //health of 300, initial mana of 0 and damage of 120. 
        public Warrior():base(0,300,120)
        { }

        public override void Attack(Character target)
        {
            target.Health -= Damage;
        }
    }
}
