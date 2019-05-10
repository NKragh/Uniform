﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class ProcessOrder
    {
        private int _processOrderNo;
        //private DateTime _processDate;
        private string _batchCode;
        private bool _isComplete;
        private int _columnNo;
        private int _productNo;
        private int _employeeNoNo;

        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        //public DateTime ProcessDate { get => _processDate; set => _processDate = value; }
        public string BatchCode { get => _batchCode; set => _batchCode = value; }
        public bool IsComplete { get => _isComplete; set => _isComplete = value; }
        public int ColumnNo { get => _columnNo; set => _columnNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }
        public int EmployeeNo { get => _employeeNoNo; set => _employeeNoNo = value; }

        public ProcessOrder(int processOrderNo, string batchCode, bool isComplete, int columnNo, int productNo, int employeeNo)
        {
            ProcessOrderNo = processOrderNo;
            //ProcessDate = processDate;
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
