using EmployeeSample.ViewModel;
using System.Windows;

namespace EmployeeSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = new MainWindow();
            EmployeeViewModel VM = new EmployeeViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
