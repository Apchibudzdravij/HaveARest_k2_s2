using DevExpress.Mvvm;
using OOP_Lab_6.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;

namespace OOP_Lab_6.Model
{
    public interface ITshirtable
    {
        void Serialize(string path);
        void Deserialize(string path);
    }
    [Serializable]
    public class TShirt : ITshirtable
    {
        public string modelName { get; set; }
        public string modelID { get; set; }
        public string shortDescription { get; set; }
        public string fullDescription { get; set; }
        public double price { get; set; }
        public bool availability { get; set; }
        public short sale { get; set; }
        public uint sold { get; set; }
        public uint inStock { get; set; }
        public string src { get; set; }
        public void Serialize(string path)
        {
            File.Delete(path);
            XmlSerializer XMLmatter = new XmlSerializer(typeof(TShirt));
            using (FileStream fx = new FileStream(path, FileMode.OpenOrCreate))
            {
                XMLmatter.Serialize(fx, this);
            }
        }
        public void Deserialize(string path)
        {
            XmlSerializer XMLmatter = new XmlSerializer(typeof(TShirt));
            using (FileStream fx = new FileStream(path, FileMode.OpenOrCreate))
            {
                TShirt tempTS = XMLmatter.Deserialize(fx) as TShirt;
                this.modelName = tempTS.modelName;
                this.modelID = tempTS.modelID;
                this.shortDescription = tempTS.shortDescription;
                this.fullDescription = tempTS.fullDescription;
                this.price = tempTS.price;
                this.availability = tempTS.availability;
                this.sale = tempTS.sale;
                this.sold = tempTS.sold;
                this.inStock = tempTS.inStock;
            }
        }

        private DelegateCommand openSpecs;
        public ICommand OpenSpecs
        {
            get
            {
                if (openSpecs == null)
                {
                    openSpecs = new DelegateCommand(OpenTShirt);
                }
                return openSpecs;
            }
        }
        private void OpenTShirt()
        {
            BuyTShirt window = new BuyTShirt(this);
            window.Show();
        }


        /*private TShirt _selectedItem;
        public TShirt SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem == value)
                {
                    return;
                }

                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        private void Remove()
        {
            if (SelectedItem == null)
            {
                return;
            }

            shirts.Remove(SelectedItem);
        }*/
    }
}
