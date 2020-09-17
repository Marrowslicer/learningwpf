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

namespace P001_LearningLayout
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

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(sender is ComboBox cbx) || DrawInkCanvas == null)
            {
                return;
            }

            switch ((cbx.SelectedItem as ComboBoxItem).Content)
            {
                case "Ink":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                    break;
                case "GestureOnly":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.GestureOnly;
                    break;
                case "InkAndGesture":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.InkAndGesture;
                    break;
                case "EraseByStroke":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
                case "EraseByPoint":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;
                case "Select":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.Select;
                    break;
                case "None":
                    DrawInkCanvas.EditingMode = InkCanvasEditingMode.None;
                    break;
            }
        }
    }
}
