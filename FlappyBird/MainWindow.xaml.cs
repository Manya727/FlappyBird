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
using System.Windows.Threading;

namespace FlappyBird
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        public readonly DispatcherTimer jatekciklusIdozito = new DispatcherTimer();

        public double MadarSebesseg;
        public const double Gravitacio = 0.55;
        public const double UgrasSebesseg = -8.5;

        public bool Start;
        public bool Ending;

        public readonly Random veletlen = new Random();
    }
    }
}