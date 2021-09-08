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

namespace WpfApp2
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
            
        }

        private void Textbox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox1.Text))
            {
                Textbox1.Visibility = System.Windows.Visibility.Collapsed;
                Textbox2.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void Textbox2_GotFocus(object sender, RoutedEventArgs e)
        {
            Textbox2.Visibility = System.Windows.Visibility.Collapsed;
            Textbox1.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void Textbox4_GotFocus(object sender, RoutedEventArgs e)
        {
            Textbox4.Visibility = System.Windows.Visibility.Collapsed;
            Textbox3.Visibility = System.Windows.Visibility.Visible;
        }

        private void Textbox3_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Textbox1.Text))
            {
                Textbox3.Visibility = System.Windows.Visibility.Collapsed;
                Textbox4.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
