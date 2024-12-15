using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controller;
using Microsoft.Win32;
using Models;
using UI.elems;
namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        controller BooksController = new controller();
        public MainWindow()
        {
            InitializeComponent();
            LoadBooksIcons();
        }

        async public void LoadBooksIcons()
        {
            var books =  BooksController.getBooksList();
            foreach (var book in books)
            {
                 BookDesc bookDesc = new BookDesc(book);
                 bookDesc.RemoveRequested += bookDesc_RemoveRequested;
                 bookIconsStack.Children.Add(bookDesc);
            }
        }
        private void bookDesc_RemoveRequested(object sender, System.EventArgs e)
        {
            // Удаляем элемент из контейнера
           
                bookIconsStack.Children.Remove((BookDesc)sender);
            
        }

        private void addBook_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string name = openFileDialog.SafeFileName.Replace(".pdf", string.Empty); ;
                string path = openFileDialog.FileName;
                Book book = BooksController.addBook(name, "", path);
                bookIconsStack.Children.Add(new BookDesc(book));
            }
        }
    }
}