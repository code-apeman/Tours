using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow(){
            InitializeComponent();
            #if DEBUG
                if (AskYN("Импортировать туры?")) ImportTours();
            #endif
            MainFrame.Navigate(new HomePage(MainFrame));
        }
        private bool AskYN(string message) => MessageBox.Show(message, "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        private void SuccessMessage(string message) => MessageBox.Show(message, "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        private void ErrorMessage(string message) => MessageBox.Show(message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

        private void ImportTours() {
            var ofdText = new System.Windows.Forms.OpenFileDialog { Title = "Выберите файл с данными об отелях...", Multiselect = false, Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*" };
            var fbdImageDir = new System.Windows.Forms.FolderBrowserDialog { ShowNewFolderButton = false };
            ofdText.ShowDialog(); fbdImageDir.ShowDialog();

            var fileData = File.ReadAllLines(ofdText.FileName);
            var images = Directory.GetFiles(fbdImageDir.SelectedPath);
            int ID = 1;

            foreach ( var line in fileData ){

                var data = line.Split('\t');
                var tempTour = new Tour {
                    id = ID,
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsAvailable = !(data[4] == "0")
                };

                foreach (var tourType in data[5].Split(new string[] { ".", ". " }, StringSplitOptions.RemoveEmptyEntries)){
                    var currentType = ToursEntities.Context.Type.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currentType != null) tempTour.Type.Add(currentType);
                }

                try { tempTour.ImagePreview = File.ReadAllBytes(images.FirstOrDefault(p => p.ToLower().Contains(tempTour.Name.ToLower()))); }
                catch (Exception ex) { ErrorMessage(ex.ToString()); }

                ToursEntities.Context.Tour.Add(tempTour);
                ToursEntities.Context.SaveChanges();
                ID++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e){
            switch ((sender as Button).Name) {
                case "BackButton": MainFrame.GoBack(); break;
                case "ForwardButton": MainFrame.GoForward(); break;
                default: MessageBox.Show("Неизвестная кнопка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); break;
            }
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e){
            PageTitle.Text = (MainFrame.Content as Page).Title;
            BackButton.Visibility = MainFrame.CanGoBack? Visibility.Visible: Visibility.Collapsed;
        }
    }
}
