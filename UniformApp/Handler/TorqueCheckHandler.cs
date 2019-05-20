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

            var CreateTorquePersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<TorqueCheck>("TorqueCheck", CheckPageViewModel.NewTorqueCheck).Result;
        }
        public void ReadTorqueCheck()
        {
            var ReadTorquePersistency = Persistency.PersistencyService
                .ReadObjectsFromDatabaseAsync<TorqueCheck>("TorqueCheck", CheckPageViewModel.ReadTorqueCheckCommand)
                .Result;
        }
        public void UpdateTorqueCheck()
        {
            var UpdateTorquePersistency =
                Persistency.PersistencyService
                    .UpdateObjectToDatabaseAsync<TorqueCheck>("TorqueCheck",
                        CheckPageViewModel.DeleteTorqueCheckCommand).Result;
        }
        public void DeleteTorqueCheck()
        {
            var DeleteTorquePersistency = Persistency.PersistencyService
                .DeleteObjectFromDatabaseAsync<TorqueCheck>("TorqueCheck", CheckPageViewModel.DeleteTorqueCheckCommand)
                .Result;
        }
    }
}
