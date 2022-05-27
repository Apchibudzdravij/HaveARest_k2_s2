using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Lab_6.Resources
{
    /// <summary>
    /// Логика взаимодействия для UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void Result_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string text = "Sender: " + sender.ToString() + '\n';
            text += "Src:    " + e.Source.ToString() + '\n';
            MessageBox.Show(text);
        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            string text = "Sender: " + sender.ToString() + '\n';
            text += "Src:    " + e.Source.ToString() + '\n';
            MessageBox.Show(text);
        }
    }
}
