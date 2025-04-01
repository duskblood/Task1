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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            this.KeyDown += Window_KeyDown;
            this.Focus(); 
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.N && Keyboard.Modifiers == ModifierKeys.Control)
                ((MainViewModel)DataContext).AddProductCommand.Execute(null);
            else if (e.Key == Key.E && Keyboard.Modifiers == ModifierKeys.Control)
                ((MainViewModel)DataContext).EditProductCommand.Execute(null);
            else if (e.Key == Key.D && Keyboard.Modifiers == ModifierKeys.Control)
                ((MainViewModel)DataContext).DeleteProductCommand.Execute(null);
        }
    }
}