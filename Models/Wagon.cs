using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Models
{
    public class Wagon
    {
        public int WagonSize { get; set; } = 10;
        public List<Animal> AnimalsInWagon { get; set; } = new List<Animal>();

        public bool CheckIfRoomForAnimal(Animal animal, Wagon wagon)
        {
            int animalSize = (int)animal.AnimalSize;
            if (animalSize > wagon.WagonSize)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckIfAnimalsAreCompatible(Animal newAnimal, Wagon wagon)
        {
            bool CompatibleOrNot = true;
            foreach (Animal animal in wagon.AnimalsInWagon)
            {
                if ((int)animal.AnimalSize >= (int)newAnimal.AnimalSize && animal.AnimalDiet == Animal.Diet.Carnivore)
                {
                    CompatibleOrNot = false;
                }
                else if ((int)animal.AnimalSize <= (int)newAnimal.AnimalSize && newAnimal.AnimalDiet == Animal.Diet.Carnivore)
                {
                    CompatibleOrNot = false;
                }
                else
                {
                    CompatibleOrNot = true;
                }
            }
            return CompatibleOrNot;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
