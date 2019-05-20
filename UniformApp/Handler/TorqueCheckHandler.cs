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

        public TorqueCheckHandler()
        {
        }

        public void CreateTorqueCheck()
        {
            CheckPageViewModel.NewTorqueCheck.EmployeeNo = ProcessOrderCatalog.Instance.TargetProcessOrder.EmployeeNo;
            CheckPageViewModel.NewTorqueCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewTorqueCheck.CheckTime = DateTime.Now.TimeOfDay; //TODO Johan/Ncraigh help

            var TorquePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<TorqueCheck>("TorqueCheck", CheckPageViewModel.NewTorqueCheck).Result;
        }
        public void ReadTorqueCheck()
        {

        }
        public void UpdateTorqueCheck()
        {

        }
        public void DeleteTorqueCheck()
        {

        }
    }
}
