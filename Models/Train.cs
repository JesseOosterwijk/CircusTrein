using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Train
    {
        public List<Wagon> wagons = new List<Wagon> { new Wagon() };

        private void PutAnimalInWagon(Animal newAnimal, Wagon currentWagon)
        {
            currentWagon.AnimalsInWagon.Add(newAnimal);
            currentWagon.WagonSize -= (int)newAnimal.AnimalSize;
        }

        public void DivideAnimalsOverWagons(List<Animal> animalList)
        {
            foreach (Wagon wagon in wagons.ToList())
            {
                foreach (Animal animal in animalList)
                {
                    if (wagon.CheckIfAnimalsAreCompatible(animal, wagon) && wagon.CheckIfRoomForAnimal(animal, wagon))
                    {
                        PutAnimalInWagon(animal, wagon);
                    }
                    else
                    {
                        Wagon newWagon = new Wagon();
                        PutAnimalInWagon(animal, newWagon);
                        wagons.Add(newWagon);
                    }
                }               
            }
        }

    }


}
