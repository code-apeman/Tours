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

namespace ToursWPFApp
{
    /// <summary>
    /// Логика взаимодействия для ElementPage.xaml
    /// </summary>
    public partial class ElementPage : Page {
        private Frame _container;
        private Hotel _hotel;

        public ElementPage(Frame container, Hotel hotel = null) {
            InitializeComponent();
            _container = container;
            cbCountries.ItemsSource = ToursEntities.Context.Country.ToList();
            _hotel = hotel ?? new Hotel();
            Title = (hotel == null)? "Добавить элемент...": "Редактировать элемент...";
            DataContext = _hotel;
        }

        private void bSave_Click(object sender, RoutedEventArgs e){
            tbStarCount.Text = tbStarCount.Text.Trim();

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_hotel.Name)) errors.AppendLine("Не указано название отеля!");
            if (_hotel.StarCount < 1 || _hotel.StarCount > 5) errors.AppendLine("Количество звёзд должно быть числом от 1 до 5!");
            if (_hotel.Country == null) errors.AppendLine("Не указана страна!");

            if (errors.Length > 0) { MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); return; }

            if (_hotel.id == 0) ToursEntities.Context.Hotel.Add(_hotel);

            try {
                ToursEntities.Context.SaveChanges();
                MessageBox.Show("Информация сохранена.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                _container.GoBack();
            } catch(Exception ex) { MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void tbStarCount_PreviewTextInput(object sender, TextCompositionEventArgs e){
            e.Handled = !int.TryParse((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.Text), out int _);
        }

        private void tbStarCount_KeyDown(object sender, KeyEventArgs e) => tbStarCount.Text = tbStarCount.Text.Trim();
    }
}
