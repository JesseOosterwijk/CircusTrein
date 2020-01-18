using System.Collections.Generic;

namespace Models
{
    public class Train
    {

        private List<Wagon> Wagons { get; } = new List<Wagon>();
        private int AnimalsInWagons;
        private readonly List<Animal> animalList;

        public void DivideAnimalsOverWagons(List<Animal> animalList, List<Wagon> Wagons)
        {
            foreach (Animal animal in animalList)
            {
                AddAnimalToWagons(animal, Wagons);
            }
        }

        public void AddAnimalToWagons(Animal animal, List<Wagon> Wagons)
        {
            if (Wagons.Count == 0)
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                AnimalsInWagons++;
                Wagons.Add(newWagon);
            }
            else
            {
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.AddAnimal(animal) == true)
                    {
                        AnimalsInWagons++;
                        return;
                    }
                }
                Wagon newWagon = new Wagon();
                Wagons.Add(newWagon);
                newWagon.AddAnimal(animal);
                AnimalsInWagons++;
                return;
            }
        }
    }
}