using MaterialDesignThemes.Wpf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace EmployeeSearch
{
    public class VM : INotifyPropertyChanged
    {
        private readonly PaletteHelper _paletteHelper = new PaletteHelper();

        DB db = DB.Instance;
        internal List<Employee> employees;

        private static VM vm;
        public static VM Instance
        {
            get
            {
                if (vm == null)
                    vm = new VM();
                return vm;
            }
        }

        public BindingList<Employee> Employees { get; set; } = new BindingList<Employee>();

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set { 
                searchText = value;
                //propChange("SearchText");
                //EmployeeSearched();
            }
        }

        private bool isDarkMode;
        public bool IsDarkMode
        {
            get { return isDarkMode; }
            set { isDarkMode = value; }
        }


        private VM()
        {
            db.checkStatus();
            employees = db.Get();
            updateEmployeesList();
        }

        public void Save(Employee employee)
        {
            bool success = false;

            if (employee.IsNew)
            {
                success = db.Insert(employee);
            }
            else
            {
                success = db.Update(employee);
                if (success)
                {
                    employees.Remove(SelectedEmployee);
                    SelectedEmployee = null;
                }
            }

            if (success)
            {
                employees.Add(employee);
                updateEmployeesList();
            }

        }

        public void Delete()
        {
            bool success = db.Delete(SelectedEmployee);
            if (success)
            {
                employees.Remove(SelectedEmployee);
                Employees.Remove(SelectedEmployee);
                SelectedEmployee = null;
            }
            
        }

        private void updateEmployeesList()
        {
            employees = employees.OrderBy(e => e.Id).ToList();

            Employees.Clear();
            foreach (Employee e in employees)
                Employees.Add(e);
        }

        public void EmployeeSearched()
        {
            Employees.Clear();
            BindingList<Employee> foundEmployees;

            if (!string.IsNullOrEmpty(searchText))
                foundEmployees = new BindingList<Employee>(employees.Where(e => e.Name.ToUpper().Contains(SearchText.ToUpper())).ToList());
            else
                foundEmployees = new BindingList<Employee>(employees);

            foreach (Employee e in foundEmployees)
                Employees.Add(e);
        }

        public void ToggleTheme()
        {
            ITheme theme = _paletteHelper.GetTheme();
            IBaseTheme baseTheme = IsDarkMode ? new MaterialDesignDarkTheme() : (IBaseTheme)new MaterialDesignLightTheme();
            theme.SetBaseTheme(baseTheme);
            _paletteHelper.SetTheme(theme);
        }

        #region propChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void propChange([CallerMemberName] string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        #endregion
    }
}
