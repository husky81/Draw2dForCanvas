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

namespace Draw2dForCanvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            BckDraw2D draw = new BckDraw2D(grd1);

            Point p0 = new Point(1, 1);
            Point p1 = new Point(100, 100);
            Line2D l = new Line2D(p0, p1);
            l.Color = Brushes.Black;
            draw.shapes.lines.Add(l);

            draw.RedrawShapes();

            

        }
    }
}
