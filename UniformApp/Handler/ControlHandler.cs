using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Model;
using UniformApp.ViewModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniformApp.Annotations;
using UniformApp.Persistency;

namespace UniformApp.Handler
{
    class ControlHandler : INotifyPropertyChanged
    {
        public CheckPageViewModel CheckPageViewModel { get; set; }

        private CompleteCheckView _targetCompleteCheckView;

        public CompleteCheckView TargetCompleteCheckView
        {
            get { return _targetCompleteCheckView; }
            set
            {
                _targetCompleteCheckView = value; 
                OnPropertyChanged();
            }
        }

        public ControlHandler(CheckPageViewModel viewModel)
        {
            TargetCompleteCheckView = new CompleteCheckView();
            CheckPageViewModel = viewModel;
        }

        public async void LoadCompleteCheckViewsAsync()
        {
            var checks = await Persistency.PersistencyService.ReadObjectsFromDatabaseAsync<CompleteCheckView>("CompleteCheckView");

            if (checks.Count != 0)
            {
                foreach (var c in checks)
                {
                    if (c.ProcessOrderNo == ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo)
                    {
                        TargetCompleteCheckView = c;
                    }
                }
            }
            else
            {
                TargetCompleteCheckView = new CompleteCheckView("defaultProduct2", 123, 456, 789, 123456789, "defaultBatch2", 098, 765);
            }
        }

        public void PostToCompletion()
        {
            OpenBrowserExtension(TargetCompleteCheckView);
            ChangeIsComplete();
            //CreatePackageSlip();
        }


        /// <summary>
        /// Opens the default browser at the associated URL
        /// </summary>
        /// <param name="input">CompleteCheckView data associated with the ProcessOrder</param>
        private void OpenBrowserExtension(CompleteCheckView input)
        {
            string p = $"{input.ProductNo} {input.ProductName}";
            string v = $"{input.ProcessOrderNo}";
            string e = $"{input.LabelNo}";
            string bk = $"{input.BatchCode}";
            string kn = $"{input.LidNo}";
            string pre = $"{input.PreformNo}";
            string pa = $"{input.PalletNo}";

            string url = "http://kvalitet/default.aspx?p=" + p + "&v=" + v + "&l=Faxe&kol=K12&BK=" + bk + "&KN=" + kn +
                         "&E=" + e + "&pre=" + pre + "&pa=" + pa;
#if DEBUG
            url = "http://zealand.dk";
#endif
            var uri = new Uri(url);
            Windows.System.Launcher.LaunchUriAsync(uri);
        }

        /// <summary>
        /// Updates targeted ProcessOrders IsComplete status to complete.
        /// </summary>
        private void ChangeIsComplete()
        {
            var id = ProcessOrderCatalog.Instance.TargetProcessOrder.ProcessOrderNo;
            ProcessOrderCatalog.Instance.TargetProcessOrder.IsComplete = true;
            //TODO StatusCode: 405, ReasonPhrase: 'Method Not Allowed', Version: 1.1, Content: System.Net.Http.StreamContent, Headers:
            var tmp = PersistencyService.UpdateObjectToDatabaseAsync<ProcessOrder>("ProcessOrder", ProcessOrderCatalog.Instance.TargetProcessOrder, id).Result;
        }

        /// <summary>
        /// Creates a Package Slip for the ProcessOrder production run
        /// </summary>
        private void CreatePackageSlip()
        {
            //TODO Implementer i fremtidigt sprint
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
