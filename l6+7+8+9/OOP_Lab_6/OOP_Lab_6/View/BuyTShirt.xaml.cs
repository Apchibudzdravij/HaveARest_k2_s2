using OOP_Lab_6.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OOP_Lab_6.View
{
    /// <summary>
    /// Логика взаимодействия для BuyTShirt.xaml
    /// </summary>
    public partial class BuyTShirt : Window
    {
        private ObservableCollection<TShirt> shirt;
        public BuyTShirt(TShirt ts)
        {
            InitializeComponent();
            this.shirt = new ObservableCollection<TShirt>();
            TShish.ItemsSource = this.shirt;
            this.shirt.Add(ts);

        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("EXECUTED!");
        }
    }
}
