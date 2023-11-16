using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example5_Worksheet6_Question3
{

    /*
     * 14.	When the Priest attacks, he deals damage to the opponent,
     * but also heals himself (life steal) – e.g. 
     * if he dealt 100 damage to the opponent, he restores 10% of that, or 10 health points.
15.	When the healer Heals, he reduces his mana by 100 and
    heals the target character by increasing his health with 150 health points.

     * 
     */
    public class Priest:Character, IHeal
    {
        //health of 125, initial mana of 200 and damage of 100.
        public Priest():base(200, 125, 100) { }

        public override void Attack(Character target)
        {
            target.Health -= Damage;
            this.Health += Convert.ToInt16((Damage * .1));
        }

        public void Heal(Character target)
        {
            Mana -= 100;
            target.Health += 150;
        }
    }
}
