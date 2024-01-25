using System.Windows;
using System.Windows.Input;

namespace plansza
{
    public partial class MainWindow : Window
    {
        private bool isDragging = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChessPiece_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            ChessPiece.CaptureMouse();
        }

        private void ChessPiece_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Ustawianie nowej pozycji pionka na podstawie pozycji myszy
                double mouseX = e.GetPosition(ChessBoard).X;
                double mouseY = e.GetPosition(ChessBoard).Y;

                ChessPiece.Margin = new Thickness(mouseX - ChessPiece.Width / 2, mouseY - ChessPiece.Height / 2, 0, 0);
            }
        }

        private void ChessPiece_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            ChessPiece.ReleaseMouseCapture();
        }
    }
}
