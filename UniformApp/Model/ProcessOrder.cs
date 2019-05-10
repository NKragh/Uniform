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
        private DateTime _processDate;
        private string _batchCode;
        private bool _isComplete;
        private int _columnNo;
        private int _productNo;
        private int _employee;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public DateTime ProcessDate { get => _processDate; set => _processDate = value; }
        public string BatchCode { get => _batchCode; set => _batchCode = value; }
        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
        public int ColumnNo { get => _columnNo; set => _columnNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }
        public int Employee { get => _employee; set => _employee = value; }

<<<<<<< HEAD
        public ProcessOrder(int processOrderNo, DateTime processDate, string batchCode, bool isComplete, int columnNo, int productNo, int employee)
=======
        public ProcessOrder(int processOrderNo, string batchCode, bool isComplete, int columnNo, int productNo, int employee)
>>>>>>> parent of 1c6f0b8... Bleh
        {
            ProcessOrderNo = processOrderNo;
            ProcessDate = processDate;
            BatchCode = batchCode;
            IsComplete = isComplete;
            ColumnNo = columnNo;
            ProductNo = productNo;
            Employee = employee;
        }

        public ProcessOrder()
        {
            
        }
    }
}
