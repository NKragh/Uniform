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
