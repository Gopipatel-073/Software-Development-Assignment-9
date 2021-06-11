using System.Windows;

namespace EmployeeSearch
{
    public partial class MainWindow : Window
    {
        readonly VM vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = VM.Instance;
            DataContext = vm;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(false)
            {
                Owner = this,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            ef.ShowDialog();
            Snackbar.MessageQueue.Clear();
            Snackbar.MessageQueue.Enqueue("Employee added successfully.");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectedEmployee != null)
            {
                EmployeeForm ef = new EmployeeForm(true)
                {
                    Owner = this,
                    WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                ef.ShowDialog();
            }
            else
            {
                Snackbar.MessageQueue.Clear();
                Snackbar.MessageQueue.Enqueue("Please select an Employee.");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectedEmployee != null)
            {
                if (MessageBox.Show("Are you sure to Delete " + vm.SelectedEmployee.Name,
                "Delete Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    vm.Delete();
                    Snackbar.MessageQueue.Clear();
                    Snackbar.MessageQueue.Enqueue("Employee deleted successfully.");
                }
                else
                {
                    Snackbar.MessageQueue.Clear();
                    Snackbar.MessageQueue.Enqueue("Employee is not deleted!");
                }
            }
            else
            {
                Snackbar.MessageQueue.Clear();
                Snackbar.MessageQueue.Enqueue("Please select an Employee.");
            }
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e) => vm.EmployeeSearched();

        private void DarkModeToggle_Changed(object sender, RoutedEventArgs e) => vm.ToggleTheme();
    }
}
