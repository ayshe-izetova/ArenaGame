using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Archer:Hero
    {

        public Archer(string name, Weapon weapon) : base(name, weapon) { }

        public override int Attack()
        {
            int baseAttack = Strength * new Random().Next(70, 101) / 100;
            int totalAttack = baseAttack + EquippedWeapon.AttackBonus;
            return totalAttack;
        }

        public void StealthAttack(Hero target)
        {
            int damage = Attack() * 2;
            target.TakeDamage(damage);
            Console.WriteLine($"{Name} performs a stealth attack on {target.Name} for {damage} damage!");
        }

    }
}
