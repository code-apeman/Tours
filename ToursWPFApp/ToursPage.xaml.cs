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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToursWPFApp {
    /// <summary>
    /// Логика взаимодействия для ToursPage.xaml
    /// </summary>
    public partial class ToursPage : Page {
        Frame _container;
        public ToursPage(Frame container){
            InitializeComponent();

            var TypesForFiltering = ToursEntities.Context.Type.ToList();
            TypesForFiltering.Insert(0, new Type { Name = "Все типы" });
            cbType.ItemsSource = TypesForFiltering;
            cbType.SelectedIndex = 0;
            cbAvailable.IsChecked = true;
            _container = container;

            UpdateTours();
        }

        private void UpdateTours(){
            var CurrentTours = ToursEntities.Context.Tour.ToList();

            if (cbType.SelectedIndex > 0) CurrentTours = CurrentTours.Where(p => p.Type.Contains(cbType.SelectedItem as Type)).ToList();
            CurrentTours = CurrentTours.Where(p => p.Name.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
            if (cbAvailable.IsChecked ?? false) CurrentTours = CurrentTours.Where(p => p.IsAvailable).ToList();

            lvTours.ItemsSource= CurrentTours.OrderBy(p => p.TicketCount).ToList();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e) => UpdateTours();
        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateTours();
        private void cbAvailable_Checked(object sender, RoutedEventArgs e) => UpdateTours();
    }
}
