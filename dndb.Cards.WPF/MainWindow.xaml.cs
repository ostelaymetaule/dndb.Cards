using dndb.Cards.Parser;
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

namespace dndb.Cards.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CharacterLoader _characterLoader;
        public MainWindow()
        {
            _characterLoader = new CharacterLoader("testCampaing");
            InitializeComponent();
            LoadUrlsFromFile();

        }

        private void LoadUrlsFromFile()
        {
            if (File.Exists("testCampaing.txt"))
            {
                var lines = File.ReadAllText("testCampaing.txt");
                UrlsTextBox.AppendText(lines);
                //lines.ForEach(x => UrlsTextBox.AppendText(x));
            }

        }

        private async void SaveCharUrl_ClickAsync(object sender, RoutedEventArgs e)
        {
            var values = UrlsTextBox.Document.Blocks.Select(x => x as System.Windows.Documents.Paragraph)
                .SelectMany(x => x.Inlines
                .Select(inline => ((System.Windows.Documents.Run)inline)
                        .Text))
                .Distinct()
                .Where(x=>!String.IsNullOrWhiteSpace(x))
                .ToList();
            File.WriteAllLines("testCampaing.txt", values);

            var tasks = values.Select(async x => await _characterLoader.LoadSingleCharacterAsync(x));

            await Task.WhenAll(tasks);

        }

        private void DownloadPreviews_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
