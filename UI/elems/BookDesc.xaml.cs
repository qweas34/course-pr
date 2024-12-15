using Controller;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using UI.windows;
using static UI.MainWindow;
namespace UI.elems
{
    /// <summary>
    /// Логика взаимодействия для BookDesc.xaml
    /// </summary>
    public partial class BookDesc : UserControl
    {
        public event EventHandler RemoveRequested;
        private Book book;
        controller controller = new controller();
        public BookDesc(Book book)
        {
            InitializeComponent();
            TextContent.Content = book.Title + "\n"+ book.Description;
            this.book = book;

        }
        private void Button_Click_Read(object sender, RoutedEventArgs e)
        {
            PDF_readWindow newPDF_ReadWindow = new PDF_readWindow(book.Path);
            newPDF_ReadWindow.Show();
        }

        private void Button_Click_Trash(object sender, RoutedEventArgs e)
        {
            controller.DeleteBook(book);
            RemoveRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
