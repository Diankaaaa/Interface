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
using Lib;

namespace Interface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Student s1 = new Student();
                s1.Name = "Вася";
                s1.CreditCardNumber = "123456789101112131415";
                s1.GroupNumber = 3;
                s1.Age = 21;
                
                Student s2 = new Student();
                s2.Name = "Володя";
                s2.CreditCardNumber = "123456789101112131417";
                s2.GroupNumber = 3;
                s2.Age = 21;

                OUTPUT.Text += s1.Print() + "\n" + s2.Print() + Environment.NewLine + "Результат вызова метода CompareTo (Сравнение по имени): " + s1.CompareTo(s2);
            }
            catch (Exception ex)
            {
                OUTPUT.Text += ex.Message;
            }
        }
    }
}
