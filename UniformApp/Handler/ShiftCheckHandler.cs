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
        public ShiftCheckViewModel ShiftCheckViewModel { get; set; }

        public ShiftCheckHandler(ShiftCheckViewModel viewModel)
        {
            ShiftCheckViewModel = viewModel;
        }

        // <summary>
        // Default C-R-U-D features for application
        // </summary>

        public void CreateShiftCheck()
        {
            var Create =
                Persistency.PersistencyService
                    .CreateObjectToDatabaseAsync<ShiftCheck>("ShiftCheck",
                        ShiftCheckViewModel.NewShiftCheck);
        }

        public void ReadShiftCheck()
        {
            var Read
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
