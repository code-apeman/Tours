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

namespace ToursWPFApp {
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page {
        private Frame _container;
        public HomePage(Frame container){
            InitializeComponent();
            _container = container;
        }

        private void bHotels_Click(object sender, RoutedEventArgs e) => _container.Navigate(new HotelsPage(_container));
        private void bTours_Click(object sender, RoutedEventArgs e) => _container.Navigate(new ToursPage(_container));
    }
}
