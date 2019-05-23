using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class PETCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public PETCheckHandler (CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public void CreatePETCheck()
        {
            CheckPageViewModel.NewPETCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewPETCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewPETCheck.CheckTime = DateTime.Now.TimeOfDay;

            var PETPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.NewPETCheck).Result;
        }
    }
}
