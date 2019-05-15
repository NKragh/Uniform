using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniformApp.Model
{
    class WeightCheck
    {
        private int _processNo;
        private DateTime _checkTime;
        private float _weight1;
        private float _weight2;
        private float _weight3;
        private float _weight4;
        private float _weight5;
        private float _weight6;
        private string _comments;
        private int _employeeNo;
        private int _productNo;

        public int ProcessNo { get => _processNo; set => _processNo = value; }
        public DateTime CheckTime1 { get => _checkTime; }
        public float Weight1 { get => _weight1; set => _weight1 = value; }
        public float Weight2 { get => _weight2; set => _weight2 = value; }
        public float Weight3 { get => _weight3; set => _weight3 = value; }
        public float Weight4 { get => _weight4; set => _weight4 = value; }
        public float Weight5 { get => _weight5; set => _weight5 = value; }
        public float Weight6 { get => _weight6; set => _weight6 = value; }
        public string Comments { get => _comments; set => _comments = value; }
        public int EmployeeNo { get => _employeeNo; set => _employeeNo = value; }
        public int ProductNo { get => _productNo; set => _productNo = value; }

        public WeightCheck(int processNo, float weight1, float weight2, float weight3, float weight4, float weight5, float weight6, string comments, int employeeNo, int productNo)
        {
            ProcessNo = processNo;
            Weight1 = weight1;
            Weight2 = weight2;
            Weight3 = weight3;
            Weight4 = weight4;
            Weight5 = weight5;
            Weight6 = weight6;
            Comments = comments;
            EmployeeNo = employeeNo;
            ProductNo = productNo;
        }

        public WeightCheck()
        {
                
        }
    }
}
