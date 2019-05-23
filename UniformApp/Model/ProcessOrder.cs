using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class ProcessOrder
    {
        private int _processOrderNo;
        //#pragma disables error list warning of default date - as it is intended
        #pragma warning disable 649
        private DateTime _processOrderDate /*= DateTime.Now*/;
        #pragma warning restore 649
        private string _batchCode;
        private bool _isComplete = false;
        private int _columnNo;
        private int _productNo;
        private int _employeeNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public DateTime ProcessOrderDate { get => _processOrderDate; /*set => _processOrderDate = value; */}
        public string BatchCode { get => _batchCode; set => _batchCode = value; }
        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
        public int ColumnNo { get => _columnNo; set => _columnNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }

        public ProcessOrder(int processOrderNo, string batchCode, bool isComplete, int columnNo, int productNo, int employeeNo/*, DateTime processOrderDate*/)
        {
            ProcessOrderNo = processOrderNo;
            //ProcessOrderDate = processOrderDate;
            BatchCode = batchCode;
            IsComplete = isComplete;
            ColumnNo = columnNo;
            ProductNo = productNo;
            EmployeeNo = employeeNo;
        }

        public ProcessOrder()
        {

        }
    }
}
