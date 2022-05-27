 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OOP_Lab_6.Resources
{
    public class MyCommand
    {
        private static RoutedUICommand query;
        static MyCommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.CapsLock, ModifierKeys.Control, "Ctrl+CapsLock"));
            query = new RoutedUICommand("Query", "Query", typeof(MyCommand), inputs);
        }
        public static RoutedUICommand Query
        {
            get { return query; }
        }
    }
}
