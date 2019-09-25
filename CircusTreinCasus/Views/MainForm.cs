using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTreinCasus
{
    public partial class MainForm : Form
    {
        readonly Train train = new Train();

        public MainForm()
        {
            InitializeComponent();
        }

        List<Animal> animalList = new List<Animal>();

        private void btnAddAnimalToList_Click(object sender, EventArgs e)
        {
            Animal.Diet animalDiet;
            Animal.Size animalSize;
            string animalName = txtName.Text;

            if (rbtnMeat.Checked)
            {
                animalDiet = Animal.Diet.Carnivore;
            }
            else
            {
                animalDiet = Animal.Diet.Herbivore;
            }

            if(rbtnSmall.Checked)
            {
                animalSize = Animal.Size.Small;
            }
            else if(rbtnMiddle.Checked)
            {
                animalSize = Animal.Size.Medium;
            }
            else
            {
                animalSize = Animal.Size.Large;
            }
            Animal newAnimal = new Animal(animalDiet, animalSize, animalName);
            newAnimal.AddAnimalToWagonList(newAnimal, animalList);
            lbAnimals.Items.Add(newAnimal);
        }

        private void btnDivideAnimals_Click(object sender, EventArgs e)
        {
            train.wagons.Clear();
            train.wagons.Add(new Wagon());
            Wagon firstWagon = new Wagon();
            List<Wagon> wagonList = new List<Wagon>
            {
                firstWagon
            };

            train.DivideAnimalsOverWagons(animalList);

            lbTrain.Items.Clear();
            foreach (Wagon wagon in train.wagons)
            {
                lbTrain.Items.Add(wagon);
            }
            wagonList.Clear();
            wagonList.Add(new Wagon());
        }

        private void lbWagons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedWagonIndex = lbTrain.SelectedIndex;
            int selectedAnimalIndex = lbWagons.SelectedIndex;

            Animal selectedAnimal = train.wagons[selectedWagonIndex].AnimalsInWagon[selectedAnimalIndex];
        }

        private void lbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lbTrain.SelectedIndex;

            Wagon selectedWagon = train.wagons[selectedIndex];

            lbWagons.Items.Clear();

            foreach (Animal currentAnimal in selectedWagon.AnimalsInWagon)
            {
                lbWagons.Items.Add(currentAnimal);
            }
        }


    }
}
