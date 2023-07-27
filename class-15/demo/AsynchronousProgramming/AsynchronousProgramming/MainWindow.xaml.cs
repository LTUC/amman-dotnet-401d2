using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace AsynchronousProgramming
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

        private  async void Button_Click(object sender, RoutedEventArgs e)
        {
           await  DownloadHtmlAsync("https://learn.microsoft.com/en-us/dotnet/desktop/wpf/migration/?view=netdesktop-7.0");
        }

        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);

          
            using (var streamWriter = new StreamWriter(@"d:\projects\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"d:\projects\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
    }
}
