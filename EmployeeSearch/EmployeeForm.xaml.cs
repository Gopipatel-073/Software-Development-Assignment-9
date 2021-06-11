using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace EmployeeSearch
{
    public partial class EmployeeForm : Window
    {
        readonly VM vm;
        readonly Employee employee = new Employee();
        public EmployeeForm(bool isEdit)
        {
            InitializeComponent();
            vm = VM.Instance;

            if (isEdit)
            {
                employee.Id = vm.SelectedEmployee.Id;
                employee.Name = vm.SelectedEmployee.Name;
                employee.Position = vm.SelectedEmployee.Position;
                employee.HourlyPay = vm.SelectedEmployee.HourlyPay;

                employee.IsNew = false;
                Title_TextBlock.Text = "EDIT EMPLOYEE";
                Save_Button.Content = "Update";
            }
            DataContext = employee;
        }

        private void Cancel_BUtton_Click(object sender, RoutedEventArgs e) => Close();

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if (employee.IsNew)
            {
                bool isDuplicateId = vm.employees.Exists(e => e.Id == employee.Id);
                if (isDuplicateId)
                {
                    Snackbar.MessageQueue.Clear();
                    Snackbar.MessageQueue.Enqueue("ID Already Exists.");
                }
                else
                {
                    if (employee.Id == null || employee.Name == null
                        || employee.HourlyPay == null || employee.Position == null)
                    {
                        Snackbar.MessageQueue.Clear();
                        Snackbar.MessageQueue.Enqueue("Please fill all the information!");
                    }
                    else {
                        Close();
                        vm.Save(employee);
                    }
                }
            }
            else
            {
                vm.Save(employee);
                Close();
            }
        }

        private void Id_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = sender as TextBox;
            e.Handled = !int.TryParse(tb.Text + e.Text, out _);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = sender as TextBox;
            bool isDecimal = decimal.TryParse(tb.Text + e.Text, out decimal result);
            if (isDecimal)
            {
                if (result >= 0)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
                e.Handled = true;
        }

    }
}
