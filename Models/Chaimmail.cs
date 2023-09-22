using System;
using Class05.Interfaces;

namespace Class05.Models
{
	public class Chainmail : IArmor
    {
		public string Name { get; set; }
		public int Defense { get; set; }

        public Chainmail(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }
    }
}
