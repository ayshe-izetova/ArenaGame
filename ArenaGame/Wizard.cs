using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Wizard:Hero
    {
        public Wizard(string name, Weapon weapon) : base(name, weapon) { }

        public override int Attack()
        {
            int baseAttack = Strength * new Random().Next(90, 121) / 100;
            int totalAttack = baseAttack + EquippedWeapon.AttackBonus;
            return totalAttack;
        }

        public void CastSpell(Hero target)
        {
            int damage = Attack() * 3;
            target.TakeDamage(damage);
            Console.WriteLine($"{Name} performs a stealth attack on {target.Name} for {damage} damage!");
        }

    }
}
