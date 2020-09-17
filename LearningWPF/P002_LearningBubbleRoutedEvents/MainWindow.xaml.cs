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

namespace P002_LearningBubbleRoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _counter;

        public MainWindow()
        {
            InitializeComponent();
            _counter = 0;
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _counter++;

            string message = $"# {_counter}:\nSender: {sender}\nSource: {e.Source}\nOriginal Source: {e.OriginalSource}";
            MessagesListBox.Items.Add(message);
            e.Handled = (bool)HandleCheckBox.IsChecked;
        }

        private void OnCommandButtonClick(object sender, RoutedEventArgs e)
        {
            _counter = 0;

            MessagesListBox.Items.Clear();
        }
    }
}
