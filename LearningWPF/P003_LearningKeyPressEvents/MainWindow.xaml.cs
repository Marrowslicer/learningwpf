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

namespace P003_LearningKeyPressEvents
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

        private void OnKeyEvent(object sender, KeyEventArgs e)
        {
            if ((bool)IgnoreCheckBox.IsChecked && e.IsRepeat)
            {
                return;
            }

            var message = $"Event: {e.RoutedEvent} Key: {e.Key}";
            OutputListBox.Items.Add(message);
        }

        private void OnTextInput(object sender, TextCompositionEventArgs e)
        {
            var message = $"Event: {e.RoutedEvent} Text: {e.Text}";
            OutputListBox.Items.Add(message);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var message = $"Event: {e.RoutedEvent}";
            OutputListBox.Items.Add(message);
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            OutputListBox.Items.Clear();
        }
    }
}
