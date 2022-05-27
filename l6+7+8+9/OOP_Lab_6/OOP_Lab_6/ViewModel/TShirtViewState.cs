using OOP_Lab_6.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_6.ViewModel
{
    public static class TShirtViewState
    {
        static ArrayList states = new ArrayList();
        static int counter = 0;
        public static void SetState(ObservableCollection<TShirt> tsv)
        {
            ObservableCollection<TShirt> obj = new ObservableCollection<TShirt>(tsv);
            states.Add(obj);
            ++counter;
        }
        public static ObservableCollection<TShirt> Undo(ObservableCollection<TShirt> tsv)
        {
            TShirtViewState.SetState(tsv);
            if (counter-2 >= 0)
            {
                counter -= 2;
                return (ObservableCollection<TShirt>)states[counter];
            }
            else
                return tsv;
        }
        public static ObservableCollection<TShirt> Redo(ObservableCollection<TShirt> tsv)
        {
            if (counter+1 < states.Count)
            {
                ++counter;
                return (ObservableCollection<TShirt>)states[counter];
            }
            else
                return tsv;
        }
    }
}
