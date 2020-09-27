using Microsoft.WindowsAPICodePack.Dialogs;
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

namespace P008_LearningFileSystem
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

        private void OnBrowseButtonClick(object sender, RoutedEventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };

            var result = dialog.ShowDialog();

            if (result == CommonFileDialogResult.Ok)
            {
                if(((Button)sender).Tag.ToString() == "Source")
                {
                    SourceTextBox.Text = dialog.FileName;
                }
                else
                {
                    TargetTextBox.Text = dialog.FileName;
                }
            }
        }

        private void OnMergeButtonClick(object sender, RoutedEventArgs e)
        {
            var srcPath = SourceTextBox.Text;
            var dstPath = TargetTextBox.Text;

            if (!string.IsNullOrEmpty(srcPath) && !string.IsNullOrEmpty(dstPath))
            {
                FileSystem fs = new FileSystem();

                try
                {
                    fs.MergeDirectories(srcPath, dstPath);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
