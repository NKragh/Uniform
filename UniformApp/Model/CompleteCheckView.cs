using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UniformApp.Annotations;

namespace UniformApp.Model
{
    class CompleteCheckView : INotifyPropertyChanged
    {
        private string _productName;
        private int _productNo;
        private int _labelNo;
        private int _lidNo;
        private int _processOrderNo;
        private string _batchCode;
        private int _preformNo;
        private int _palletNo;

        [StringLength(50)]
        public string ProductName { get => _productName; set => _productName = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }
        public int LabelNo { get => _labelNo; set => _labelNo = value; }
        public int LidNo { get => _lidNo; set => _lidNo = value; }
        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        [StringLength(20)] 
        public string BatchCode { get => _batchCode; set => _batchCode = value; }
        public int PreformNo { get => _preformNo; set => _preformNo = value; }
        public int PalletNo { get => _palletNo; set => _palletNo = value; }

        public CompleteCheckView(string productName, int productNo, int labelNo, int lidNo, int processOrderNo, string batchCode, int preformNo, int palletNo)
        {
            ProductName = productName;
            ProductNo = productNo;
            LabelNo = labelNo;
            LidNo = lidNo;
            ProcessOrderNo = processOrderNo;
            BatchCode = batchCode;
            PreformNo = preformNo;
            PalletNo = palletNo;
        }

        public CompleteCheckView()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
