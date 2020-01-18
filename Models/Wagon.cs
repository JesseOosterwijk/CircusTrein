using System.Collections.Generic;

namespace Models
{
    public class Wagon
    {
        public int WagonSize { get; private set; }
        private List<Animal> AnimalsInWagon = new List<Animal>();

        public Wagon(int wagonSize = 10)
        {
            WagonSize = wagonSize;
        }

        public bool IsThereRoomForAnimal(Animal newAnimal)
        {
            if ((int)newAnimal.AnimalSize <= WagonSize)
            {
                return true;
            }
            return false;
        }

        public bool AddAnimal(Animal newAnimal)
        {
            if (AnimalsInWagon.Count == 0)
            {
                WagonSize -= (int)newAnimal.AnimalSize;
                AnimalsInWagon.Add(newAnimal);
                return true;
            }
            else
            {
                if (IsThereRoomForAnimal(newAnimal))
                {
                    foreach (Animal animal in AnimalsInWagon)
                    {
                        if ((int)animal.AnimalSize >= (int)newAnimal.AnimalSize && animal.AnimalDiet == Animal.Diet.Carnivore)
                        {
                            return false;
                        }
                        else if ((int)animal.AnimalSize <= (int)newAnimal.AnimalSize && newAnimal.AnimalDiet == Animal.Diet.Carnivore)
                        {
                            return false;
                        }
                        else
                        {
                            WagonSize -= (int)newAnimal.AnimalSize;
                            AnimalsInWagon.Add(newAnimal);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Wagon, Remaining Size:{WagonSize} Animals in wagon: {AnimalsInWagon}" ;
        }

    }
}
