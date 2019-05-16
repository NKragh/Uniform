using System;
using System.Diagnostics;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class PressureCheckHandler
    {
        //Binding with Handler with ViewModel
        public CheckPageViewModel CheckPageViewModel { get; set; }

        public PressureCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        /// <summary>
        /// Default C-R-U-D features for application 
        /// </summary>
        public void CreatePressureCheck()
        {
            var test = Persistency.PersistencyService.CreateObjectToDatabaseAsync<PressureCheck>("PressureCheck",
                CheckPageViewModel.NewPressureCheck);
            Debug.WriteLine(test);
            throw new NotImplementedException();
        }

        public void ReadPressureCheck()
        {
            throw new NotImplementedException();
        }

        public void UpdatePressureCheck()
        {
            throw new NotImplementedException();
        }

        public void DeletePressureCheck()
        {
            throw new NotImplementedException();
        }
    }
}
