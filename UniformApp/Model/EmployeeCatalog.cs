using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class EmployeeCatalog
    {
        private Employee _targetEmployee;
        public Employee TargetEmployee
        {
            get { return _targetEmployee; }
            set { _targetEmployee = value; }
        }

        private static EmployeeCatalog _instance = new EmployeeCatalog();

        public static EmployeeCatalog Instance
        {
            get => _instance;
        }

        public ObservableCollection<Employee> EmployeeList { get; set; }

        public EmployeeCatalog()
        {
            EmployeeList = new ObservableCollection<Employee>();
            LoadEmployeesAsync();
        }

        private async void LoadEmployeesAsync()
        {
            var products = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<Employee>("Employee");
            if (products.Count != 0)
            {
                foreach (var p in products)
                {
                    EmployeeList.Add(p);
                }
            }
            else
            {
                EmployeeList.Add(new Employee(1,"DEF1",1));
                EmployeeList.Add(new Employee(2,"DEF2",2));
            }
        }
    }
}
