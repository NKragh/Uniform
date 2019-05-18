﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class WeightCheck
    {
        private int _processOrderNo;
        private DateTime _checkTime;
        private float _weight1;
        private float _weight2;
        private float _weight3;
        private float _weight4;
        private float _weight5;
        private float _weight6;
        private bool _droptest;
        private string _comments;
        private int _employeeNo;
        private int _productNo;

        /// <summary>
        /// ProcessOrderNo er 
        /// </summary>
        public int ProcessOrderNo { get => _processOrderNo; set => _processOrderNo = value; }
        public DateTime CheckTime { get => _checkTime; }
        public float Weight1 { get => _weight1; set => _weight1 = value; }
        public float Weight2 { get => _weight2; set => _weight2 = value; }
        public float Weight3 { get => _weight3; set => _weight3 = value; }
        public float Weight4 { get => _weight4; set => _weight4 = value; }
        public float Weight5 { get => _weight5; set => _weight5 = value; }
        public float Weight6 { get => _weight6; set => _weight6 = value; }
        public bool Droptest { get => _droptest; set => _droptest = value; }
        public string Comments { get => _comments; set => _comments = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="processOrderNo">Processorder number from Processorder</param>
        /// <param name="weight1"></param>
        /// <param name="weight2"></param>
        /// <param name="weight3"></param>
        /// <param name="weight4"></param>
        /// <param name="weight5"></param>
        /// <param name="weight6"></param>
        /// <param name="droptest"></param>
        /// <param name="comments"></param>
        /// <param name="employeeNo"></param>
        /// <param name="productNo"></param>
        public WeightCheck(int processOrderNo, float weight1, float weight2, float weight3, float weight4, float weight5, float weight6, bool droptest, string comments, int employeeNo, int productNo)
        {
            ProcessOrderNo = processOrderNo;
            Weight1 = weight1;
            Weight2 = weight2;
            Weight3 = weight3;
            Weight4 = weight4;
            Weight5 = weight5;
            Weight6 = weight6;
            Droptest = droptest;
            Comments = comments;
            EmployeeNo = employeeNo;
            ProductNo = productNo;
        }

        public WeightCheck()
        {
                
        }
    }
}