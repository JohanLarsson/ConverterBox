using System.Windows;

namespace ConverterBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Vm { StringValue = "Johan", DoubleValue = 1.2345 };
        }
    }
}
