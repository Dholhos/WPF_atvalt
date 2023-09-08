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

namespace WpfApp1
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

        private void slAdatSeb_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           lbSlierSzam.Content = Math.Round(slAdatSeb.Value);
        }

        private void cbAdatAt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbAdatSebFajt_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
