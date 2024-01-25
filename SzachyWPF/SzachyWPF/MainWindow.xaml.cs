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

namespace SzachyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void PionekLeftButtonDown(object sender, RoutedEventArgs e)
        {
            isDragging = true;
            WhitePawn1.CaptureMouse();
        }

        private void PionekMouseMove(object sender, MouseEventArgs e)
        {
            double mouseX = e.GetPosition(Plansza).X;
            double mouseY = e.GetPosition(Plansza).Y;
            WhitePawn1.Margin = new Thickness(mouseX - WhitePawn1.Width / 2, mouseY - WhitePawn1.Height / 2, 0, 0);
        }

        private void PionekLeftButtonUp(object sender, RoutedEventArgs e)
        {
            isDragging = false;
            WhitePawn1.ReleaseMouseCapture();
        }
    }
}