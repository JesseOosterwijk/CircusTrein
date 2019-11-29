using System;
using System.Collections.Generic;

namespace Models
{
    public class Animal
    {
        public enum Size:int { Small = 1, Medium = 3, Large = 5 }
        public enum Diet { Herbivore, Carnivore }
        public Diet AnimalDiet { get; }
        public Size AnimalSize { get; }
        public string Name;

        public Animal(Diet animalDiet, Size animalSize, string name)
        {
            AnimalDiet = animalDiet;
            AnimalSize = animalSize;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
