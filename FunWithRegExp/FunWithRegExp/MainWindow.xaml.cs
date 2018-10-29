using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace FunWithRegExp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Result.Content = "";
            if (!Regex.IsMatch(InputName.Text, @"^([A-Za-z]+\s*)+$"))
            {
                Result.Content += "Name not OK\n";
            }

            if (!Regex.IsMatch(InputPhone.Text, @"^\+[0-9-\s]{5,}$"))
            {
                Result.Content += "Phone is not okay\n";
            }

            if (!Regex.IsMatch(InputEmail.Text, @"^[\w-\.]+@(\w+\.)[a-z]{2,3}$"))
            {
                Result.Content += "E-mail is not okay\n";
            }
        }
    }
}
