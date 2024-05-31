using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    class Weapon
    {
        public string Name { get; private set; }
        public int AttackBonus { get; private set; }
        public string SpecialAbility { get; private set; }

        public Weapon(string name, int attackBonus, string specialAbility = "")
        {
            Name = name;
            AttackBonus = attackBonus;
            SpecialAbility = specialAbility;
        }
        public class Sword : Weapon
        {
            public Sword() : base("Sword", 20, "Counterattack Chance +15%") { }
        }

        public class Bow : Weapon
        {
            public Bow() : base("Bow", 15, "Piercing Shot") { }
        }

        public class Axe : Weapon
        {
            public Axe() : base("Axe", 25, "Bleeding Effect") { }
        }

    }
}
