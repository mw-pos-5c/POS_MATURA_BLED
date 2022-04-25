using MVVMLib;
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

namespace WpfVorbereitung
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = new MainWindowViewModel();
        }

        private void ListBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var content = e.Source.ToString();

            DragDrop.DoDragDrop(sender as DependencyObject, content, DragDropEffects.Copy);

        }

        private void Label_DragOver(object sender, DragEventArgs e)
        {
            var valid = e.Data.GetDataPresent(typeof(string));

            if (valid)
            {
                e.Effects = DragDropEffects.Copy;
                e.Handled = true;
            }
            
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            (sender as Label).Content = "Value: "+e.Data.GetData(typeof(string));
        }

        private void UserControl1_SomeEvent(object sender, EventArgs e)
        {

        }
    }
}
