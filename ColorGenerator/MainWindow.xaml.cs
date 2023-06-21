using System.Windows;
using System.Windows.Media;

namespace ColorGenerator
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

        void GenerateColorBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var color = logic.ColorGenerator.GenerateColor();
            ColorSwatch.Fill = new SolidColorBrush(color);
            AlphaTextBox.Text = color.A.ToString();
            RedTextBox.Text = color.R.ToString();
            GreenTextBox.Text = color.G.ToString();
            BlueTextBox.Text = color.B.ToString();
            HexTextBox.Text = color.ToString();
        }
    }
}