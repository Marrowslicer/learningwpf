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

namespace P007_LearningCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDirty;

        public MainWindow()
        {
            InitializeComponent();
            isDirty = false;
        }

        private void CanExecuteNewCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExecuteNewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            // Код создания нового файла
        }

        private void CanExecuteOpenCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ExecuteOpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            // Код открытия существующего файла
        }

        private void CanExecuteSaveCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }

        private void ExecuteSaveCommand(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
        }

        private void CanExecuteCloseCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }

        private void ExecuteCloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            isDirty = true;
        }
    }
}
