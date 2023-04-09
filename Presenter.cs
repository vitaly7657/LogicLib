using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLib
{
    public class Presenter
    {
        IView view;
        IModel model;
        public Presenter(IView Viev)
        {
            this.view = Viev;
            model = new AnimalModel();
        }
        public void Result()
        {
            model.GetData(view._TypeAnimal, view._Genus, view._AnimalName, view._Breed, view._Age);
            string result = model.Result();
            view.Result = result;
        }
    }
}
