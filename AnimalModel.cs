using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public class AnimalModel : IModel
    {
       
        public string typeAnimal;
        public string genus;
        public string animalName;
        public string breed;
        public string age;

        public AnimalModel()
        {

        }
        public void GetData (string TypeAnimal, string Genus, string AnimalName, string Breed, string Age)
        {
        
            this.typeAnimal = TypeAnimal;
            this.genus=Genus;
            this.animalName = AnimalName;
            this.breed=Breed;
            this.age=Age;
        }        
        public string Result() //вывод данных в строку с разделителя
        {
            return $"{typeAnimal}#{genus}#{animalName}#{breed}#{age}";
        }
    }
    
}
