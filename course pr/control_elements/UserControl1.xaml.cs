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

namespace course_pr.control_elements
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {

        public UserControl1(string name, string description)
        {
            InitializeComponent();
            TextContent.ContentStringFormat = name + "\n" + description;
        }
        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Trash(object sender, RoutedEventArgs e)
        {

        }
    }
}
