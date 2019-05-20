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

        public PETCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        public PETCheckHandler()
        {

        }

        public void CreatePETCheck()
        {
            CheckPageViewModel.NewPETCheck.EmployeeNo = ProcessOrderCatalog.Instance.TargetProcessOrder.EmployeeNo;
            CheckPageViewModel.NewPETCheck.ProcessOrderNo = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            CheckPageViewModel.NewPETCheck.CheckTime = DateTime.Now.TimeOfDay;

            var CreatePETPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.NewPETCheck).Result; //Kan ikke få .result; her?? 
        }
        public void ReadPETCheck()
        {
            var ReadPETPersistency = Persistency.PersistencyService
                .ReadObjectsFromDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.ReadPETCheckCommand).Result;
        }
        public void UpdatePETCheck()
        {
            var UpdatePETPersistency = Persistency.PersistencyService
                .UpdateObjectToDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.UpdatePETCheckCommand).Result;
        }
        public void DeletePETCheck()
        {
            var DeletePETPersistency = Persistency.PersistencyService
                .DeleteObjectFromDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.DeletePETCheckCommand).Result;
        }
    }
}
