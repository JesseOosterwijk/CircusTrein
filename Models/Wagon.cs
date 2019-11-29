using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Models
{
    public class Wagon
    {
        public int WagonSize { get; private set; }
        private List<Animal> AnimalsInWagon { get; set; } = new List<Animal>();

        public Wagon(int wagonSize = 10)
        {
            WagonSize = wagonSize;
        }

        public Wagon(List<Animal> animals, int wagonSize = 10)
        {
            WagonSize = wagonSize;
            AnimalsInWagon = animals;
        }

        //TODO: Kan aanroepen zonder checks
        public void PutAnimalInWagon(Animal newAnimal)
        {
            if ((int)newAnimal.AnimalSize <= WagonSize)
            {
                AnimalsInWagon.Add(newAnimal);
                WagonSize -= (int)newAnimal.AnimalSize;
            }
        }

        public bool CheckIfRoomForAnimal(Animal animal)
        {
            int animalSize = (int)animal.AnimalSize;
            if (animalSize > WagonSize)
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
            return "Wagon";
        }

    }
}
