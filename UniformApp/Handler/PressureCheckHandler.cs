using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class PressureCheckHandler
    {           
         public CheckPageViewModel CheckPageViewModel { get; set; }

        public PressureCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }
        public void CreatePressureCheck()
        {
            CheckPageViewModel.NewPressureCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewPressureCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewPressureCheck.CheckTime = DateTime.Now.TimeOfDay;
            CheckPageViewModel.NewPressureCheck.PreformNo = PreformCatalog.Instance.TargetPreform.PreformNo;

            var pressurePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PressureCheck>("PressureCheck", CheckPageViewModel.NewPressureCheck).Result;
        }
    }
}
