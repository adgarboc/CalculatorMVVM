using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    public class CalcModel
    {
        private string firstNumber;
        private string secondNumber;
        private string operation;
        private string result;

        public CalcModel()
        {
        }

        public string FirstNumber { get => firstNumber; set => firstNumber = value; }
        public string SecondNumber { get => secondNumber; set => secondNumber = value; }
        public string Operation { get => operation; set => operation = value; }
        public string Result { get => result; set => result = value; }
    }
}
