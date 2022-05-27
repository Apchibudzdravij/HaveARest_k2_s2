using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OOP_Lab_6.ViewModel
{
    class LetterTun : DependencyObject, INotifyPropertyChanged
    {
        public static DependencyProperty LetterProperty;
        public static string resVal;
        private static bool islet;
        public event PropertyChangedEventHandler PropertyChanged;

        static LetterTun()
        {
            resVal = "";
            islet = true;
            FrameworkPropertyMetadata metadata1 = new FrameworkPropertyMetadata();
            LetterProperty = DependencyProperty.Register("Letter",
                                typeof(string),
                                typeof(LetterTun), metadata1,
                                new ValidateValueCallback(ValidateValueLetter));
        }
        public string Letter
        {
            get { return (string)GetValue(LetterProperty); }
            set { SetValue(LetterProperty, value); }
        }
        public string ResVal
        {
            get { return resVal; }
            set { resVal = value; OnPropertyChanged(); }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private static bool ValidateValueLetter(object value)
        {
            string currentValue = (string)value;
            if ((value == null) || Regex.IsMatch(value.ToString(), "^[a-zA-Z]{1}$")) // если
            {
                islet = true;
                return true;
            }
            islet = false;
            return false;
        }
        private DelegateCommand valCurrent;
        public ICommand ValCurrent
        {
            get
            {
                if (valCurrent == null)
                {
                    valCurrent = new DelegateCommand(ValidationCur);
                }
                return valCurrent;
            }
        }
        private void ValidationCur()
        {
            if (islet)
            {
                ResVal = Letter;
            }
            else
            {
                ResVal = "Error";
            }
        }
    }
    class NumberTun : DependencyObject, INotifyPropertyChanged
    {
        public static DependencyProperty NumberProperty;
        public static string resVal;
        private static bool isnum;
        public event PropertyChangedEventHandler PropertyChanged;

        static NumberTun()
        {
            resVal = "";
            isnum = true;
            FrameworkPropertyMetadata metadata1 = new FrameworkPropertyMetadata();
            NumberProperty = DependencyProperty.Register("Number",
                                typeof(string),
                                typeof(NumberTun), metadata1,
                                new ValidateValueCallback(ValidateValueNumber));
        }

        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }
        public string ResVal
        {
            get { return resVal; }
            set { resVal = value; OnPropertyChanged(); }
        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private static bool ValidateValueNumber(object value)
        {
            string currentValue = (string)value;
            if ((value == null) || Regex.IsMatch(value.ToString(), "^[0-9]{1}$")) // если
            {
                isnum = true;
                return true;
            }
            isnum = false;
            return false;
        }
        private DelegateCommand valCurrent;
        public ICommand ValCurrent
        {
            get
            {
                if (valCurrent == null)
                {
                    valCurrent = new DelegateCommand(ValidationCur);
                }
                return valCurrent;
            }
        }
        private void ValidationCur()
        {
            if (isnum)
            {
                ResVal = Number;
            }
            else
            {
                ResVal = "Error";
            }
        }
    }
}
