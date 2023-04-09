using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public interface IView
    {

        string _TypeAnimal { get; } //тип       
        string _Genus { get; } //род
        string _AnimalName { get; } //кличка
        string _Breed { get; } //порода
        string _Age { get; } //возраст
        string Result { set; }

    }
}
