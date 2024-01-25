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

namespace TwojaAplikacja
{
    public partial class MainWindow : Window
    {
        private bool isDragging = false;
        private UIElement draggedElement = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                isDragging = true;
                draggedElement = sender as UIElement;
                draggedElement.CaptureMouse();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && draggedElement != null)
            {
                Point currentPosition = e.GetPosition(this);
                Canvas.SetLeft(draggedElement, currentPosition.X - draggedElement.RenderSize.Width / 2);
                Canvas.SetTop(draggedElement, currentPosition.Y - draggedElement.RenderSize.Height / 2);
            }
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
                draggedElement.ReleaseMouseCapture();
                draggedElement = null;
            }
        }
    }
 }