using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Interfaces_AbstractClasses.Example5_Worksheet6_Question3
{
    //abstract class
    //is like a normal class but you cannot instantiate it

    //
    public abstract class Character : IAttack
    {
        public abstract void Attack(Character target);

        public int Mana { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        protected Character(int mana, int health, int damage) {
            Mana = mana;
            Health = health;
            Damage = damage;
        }
         
    }
}
