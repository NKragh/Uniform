using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class TorqueCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public TorqueCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public void CreateTorqueCheck()
        {
            CheckPageViewModel.NewTorqueCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewTorqueCheck.EmployeeNo = EmployeeCatalog.Instance.TargetEmployee.EmployeeNo;
            CheckPageViewModel.NewTorqueCheck.CheckTime = DateTime.Now.TimeOfDay;
            CheckPageViewModel.NewTorqueCheck.LidNo = LidCatalog.Instance.TargetLid.LidNo;
            CheckPageViewModel.NewTorqueCheck.PreformNo = PreformCatalog.Instance.TargetPreform.PreformNo;

            var torquePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<TorqueCheck>("TorqueCheck", CheckPageViewModel.NewTorqueCheck).Result;
        }
    }
}
