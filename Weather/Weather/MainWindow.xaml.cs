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
using System.IO;

namespace Weather
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Parser parser;
        private TownsNameConvector convector;
        private string url = "https://www.meteoservice.ru/weather/now/moskva_akademicheskiy";
        private string urlBase = "https://www.meteoservice.ru/weather/now/";

        public MainWindow()
        {
            InitializeComponent();
            parser = new Parser();
            convector = new TownsNameConvector();
            parser.responseGet += UpdateText;

            double screenHeight = SystemParameters.FullPrimaryScreenHeight;
            double screenWidth = SystemParameters.FullPrimaryScreenWidth;

            this.Top = (screenHeight - this.Height) ;
            this.Left = (screenWidth - this.Width) ;
        }

        private void Town_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            TextBlock item = (TextBlock)comboBox.SelectedItem;
            string town = convector.Convert(item.Text);
            url = urlBase + town;
            SendResponse(url);
        }
        
        private void SendResponse(string url)
        {
            weatherText.Text = "Загрузка...";
            parser.GetWeather(url);
        }

        private void UpdateText(string response)
        {
            weatherText.Text = response;
        }
    }
}
