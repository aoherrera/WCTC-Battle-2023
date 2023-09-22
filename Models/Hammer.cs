using System;
using Class05.Interfaces;

namespace Class05.Models
{
    public class Hammer : IWeapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Hammer(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
