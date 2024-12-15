using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace UI.windows
{
    /// <summary>
    /// Логика взаимодействия для PDF_readWindow.xaml
    /// </summary>
    public partial class PDF_readWindow : Window
    {
       string path;
        public PDF_readWindow(string path)
        {
            InitializeComponent();
            this.path = path;
        
        }
        private void ChromiumWebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Address=path;
        }
    }

}
