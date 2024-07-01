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
using GoodRobotModBox;
using GoodRobotModBox.Workspace.Classes;


namespace GoodRobotModBox.Workspace.Components
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("");
            FileParserINI parser = new FileParserINI();
            var path = @"E:\SteamLibrary\steamapps\common\Good Robot\core\data\gameplay.ini";
            parser.Parse(path);
        }
    }
}