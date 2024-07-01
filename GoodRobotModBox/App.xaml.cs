using GoodRobotModBox.Workspace.Components;
using System.Configuration;
using System.Data;
using System.Windows;

namespace GoodRobotModBox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_Startup(object sender, StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }
    }

}
