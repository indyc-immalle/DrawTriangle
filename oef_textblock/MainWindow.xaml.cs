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

namespace oef_DrawTriangle
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            int margin_y = Convert.ToInt32(TextBox_Y.Text);
            int margin_x = Convert.ToInt32(TextBox_X.Text);

            DrawTriangle(Canvas, brush, margin_x, margin_y, 20, 60);
          

        }
        
        private static void DrawTriangle(Canvas drawingArea, SolidColorBrush brushToUse, 
                                         double xPlace, double yPlace, double width, double height)
        {
            DrawLine(drawingArea, brushToUse, xPlace, yPlace,
                                              xPlace, yPlace + height);
            DrawLine(drawingArea, brushToUse, xPlace, yPlace + height, 
                                              xPlace + width, yPlace + height );
            DrawLine(drawingArea, brushToUse, xPlace, yPlace,
                                              xPlace + width, yPlace + height);
        }

        private static void DrawLine(Canvas drawingArea, SolidColorBrush brushToUse,  
                                     double startX, double startY, double endX, double endY)
        {
            Line first = new Line();
            first.X1 = startX;
            first.Y1 = startY;
            first.X2 = endX;
            first.Y2 = endY;
            first.Stroke = brushToUse;
            drawingArea.Children.Add(first);
        }

    }
}
