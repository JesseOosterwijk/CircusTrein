using System.Collections.Generic;

namespace Models
{
    public class Train
    {

        private List<Wagon> Wagons { get; } = new List<Wagon>();

        private readonly List<Animal> animalList;
        public Train()
        {
        }

        public void DivideAnimalsOverWagons()
        {
            foreach (Animal animal in animalList)
            {
                AddAnimalsToWagons(animal);
            }
        }

        public void AddAnimalsToWagons(Animal animal)
        {
            if (Wagons.Count == 0)
            {
                Wagon newWagon = new Wagon();
                newWagon.AddAnimal(animal);
                Wagons.Add(newWagon);
            }
            else
            {
                foreach (Wagon wagon in Wagons)
                {
                    if (wagon.AddAnimal(animal) == true)
                    {                        
                        wagon.AddAnimal(animal);
                        return;
                    }
                }
                Wagon newWagon = new Wagon();
                Wagons.Add(newWagon);
                newWagon.AddAnimal(animal);
                return;
            }
        }
    }
}