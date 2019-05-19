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
            CheckPageViewModel.NewPETCheck.CheckTime = DateTime.Now.TimeOfDay; //TODO Johan/Ncraigh help

            var PETPersistency = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PETCheck>("PETCheck", CheckPageViewModel.NewPETCheck); //Kan ikke få .result; her?? 
        }
        public void ReadPETCheck()
        {

        }
        public void UpdatePETCheck()
        {

        }
        public void DeletePETCheck()
        {

        }
    }
}
