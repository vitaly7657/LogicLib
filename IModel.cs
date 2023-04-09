using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public interface IModel
    {
        string Result();
        void GetData(string TypeAnimal, string Genus, string AnimalName, string Breed, string Age);                
    }
}
