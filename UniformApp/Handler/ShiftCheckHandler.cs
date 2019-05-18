using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;

namespace UniformApp.Handler
{
    class ShiftCheckHandler
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }


        public ShiftCheckHandler(CheckPageViewModel viewModel)
        {
            CheckPageViewModel = viewModel;
        }

        // <summary>
        // Default C-R-U-D features for application
        // </summary>

        public void CreateShiftCheck()
        {
            var Create =
                Persistency.PersistencyService
                    .CreateObjectToDatabaseAsync<ShiftCheck>("ShiftCheck",
                        CheckPageViewModel.NewShiftCheck);
        }

        public void ReadShiftCheck()
        {
            var Read =
                Persistency.PersistencyService
                    .ReadObjectsFromDatabaseAsync<ShiftCheck>("ShiftCheck",
                        new CheckPageViewModel());
        }

        public void UpdateShiftCheck()
        {
            throw new NotImplementedException();
        }

        public void DeleteShiftCheck()
        {
            throw new NotImplementedException();
        }
    }
}
