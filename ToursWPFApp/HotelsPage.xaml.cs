using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class HotelsPage : Page {
        private Frame _container;
        public HotelsPage(Frame container){
            InitializeComponent();
            _container = container;
            dgHotels.ItemsSource = ToursEntities.Context.Hotel.ToList();

            //ImportTours();
        }

        private bool AskYN(string message) => MessageBox.Show(message, "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        private void SuccessMessage(string message) => MessageBox.Show(message, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        private void ErrorMessage(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        private void bEdit_Click(object sender, RoutedEventArgs e) => _container.Navigate(new ElementPage(_container, (sender as Button).DataContext as Hotel));

        private void bAdd_Click(object sender, RoutedEventArgs e) => _container.Navigate(new ElementPage(_container));

        private void bRemove_Click(object sender, RoutedEventArgs e){
            var SelectedHotels = dgHotels.SelectedItems.Cast<Hotel>().ToList();

            if (AskYN($"Вы точно хотите удалить эти {SelectedHotels.Count} элементов?")) try {
                    ToursEntities.Context.Hotel.RemoveRange(SelectedHotels);
                    ToursEntities.Context.SaveChanges();
                    SuccessMessage("Данные удалены.");

                    Page_IsVisibleChanged(sender, new DependencyPropertyChangedEventArgs());
                } catch (Exception ex) { ErrorMessage(ex.ToString()); }

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e){
            if (Visibility == Visibility.Visible){
                ToursEntities.Context.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dgHotels.ItemsSource = ToursEntities.Context.Hotel.ToList();
            }
        }
    }
}
