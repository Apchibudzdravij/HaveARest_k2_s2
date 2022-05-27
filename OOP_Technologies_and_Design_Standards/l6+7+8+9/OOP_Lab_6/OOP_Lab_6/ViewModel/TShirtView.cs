using DevExpress.Mvvm;
using OOP_Lab_6.Model;
using OOP_Lab_6.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace OOP_Lab_6.ViewModel
{
    public class TShirtView : ViewModelBase
    {
        public ObservableCollection<TShirt> shirts { get; set; }
        public string f_model { get; set; }
        public string f_description { get; set; }
        public string f_price { get; set; }
        public string f_amount { get; set; }
        public string f_src { get; set; }

        public TShirtView()
        {
            shirts = new ObservableCollection<TShirt>(StartSet.GetSet());
        }
        TShirt currentTShirt { get; set; }

        private DelegateCommand sortPrice;
        public ICommand SortPrice
        {
            get
            {
                if (sortPrice == null)
                {
                    sortPrice = new DelegateCommand(Sort_by_Price);
                }
                return sortPrice;
            }
        }
        private void Sort_by_Price()
        {
            this.shirts = new ObservableCollection<TShirt>(shirts.OrderByDescending(i => i.price));
        }

        private DelegateCommand sortModel;
        public ICommand SortModel
        {
            get
            {
                if (sortModel == null)
                {
                    sortModel = new DelegateCommand(Sort_by_Model);
                }
                return sortModel;
            }
        }
        private void Sort_by_Model()
        {
            this.shirts = new ObservableCollection<TShirt>(shirts.OrderByDescending(i => i.modelName));
        }

        private DelegateCommand sortStock;
        public ICommand SortStock
        {
            get
            {
                if (sortStock == null)
                {
                    sortStock = new DelegateCommand(Sort_by_Stock);
                }
                return sortStock;
            }
        }
        private void Sort_by_Stock()
        {
            this.shirts = new ObservableCollection<TShirt>(shirts.OrderByDescending(i => i.inStock));
        }
        private DelegateCommand newTS;
        public ICommand NewTS
        {
            get
            {
                if (newTS == null)
                {
                    newTS = new DelegateCommand(CreateTS);
                }
                return newTS;
            }
        }
        private void CreateTS()
        {
            TShirt additionable = new TShirt();
            additionable.modelName = f_model;
            additionable.shortDescription = "T-Shirt";
            additionable.fullDescription = f_description;
            additionable.price = Convert.ToDouble(f_price);
            additionable.sale = 0;
            additionable.sold = 0;
            additionable.inStock = Convert.ToUInt32(f_amount);
            if (additionable.inStock > 0)
                additionable.availability = true;
            else
                additionable.availability = false;
            additionable.src = f_src;
            TShirtViewState.SetState(this.shirts);
            this.shirts.Add(additionable);
        }

        private DelegateCommand redo;
        public ICommand Redo
        {
            get
            {
                if (redo == null)
                {
                    redo = new DelegateCommand(ReDo);
                }
                return redo;
            }
        }
        private void ReDo()
        {
            //this.shirts.Clear();
            this.shirts = new ObservableCollection<TShirt>(TShirtViewState.Redo(this.shirts));
        }
        private DelegateCommand undo;
        public ICommand Undo
        {
            get
            {
                if (undo == null)
                {
                    undo = new DelegateCommand(UnDo);
                }
                return undo;
            }
        }
        private void UnDo()
        {
            //this.shirts.Clear();
            this.shirts = new ObservableCollection<TShirt>(TShirtViewState.Undo(this.shirts));
        }
    }
}
