using Class05.Interfaces;
using Class05.Models;

namespace Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            IArmor mediumArmor = new Chainmail("Black Chainmail", 20);
            IWeapon mediumWeapon = new Hammer("Goblin Hammer", 50);

            IArmor armor = new Leather("Elven Leather Armor", 12);
            IWeapon sword = new Sword("Long sword", 5);

            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scary Monster", armor, sword);
            ICombatant bossEnemy = new Fighter("Scarier Monster", mediumArmor, mediumWeapon);

            fighter.Attack(badGuy);

        }

    }

}
