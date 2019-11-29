using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Train
    {
        //TODO public list private maken
        private List<Wagon> Wagons { get; set; } = new List<Wagon> { };

        public Train(List<Wagon> wagons)
        {
            Wagons = wagons;
        }


        //TODO: foreach in foreach
        public void DivideAnimalsOverWagons(List<Animal> animalList)
        {
            if (animalList != null)
            {
                foreach (Wagon wagon in Wagons.ToList())
                {
                    foreach (Animal animal in animalList)
                    {
                        if (wagon.CheckIfAnimalsAreCompatible(animal, wagon) && wagon.CheckIfRoomForAnimal(animal))
                        {
                            wagon.PutAnimalInWagon(animal);
                        }
                        else
                        {
                            Wagon newWagon = new Wagon();
                            newWagon.PutAnimalInWagon(animal);
                            Wagons.Add(newWagon);
                        }
                    }
                }
            }
        }
    }
}
