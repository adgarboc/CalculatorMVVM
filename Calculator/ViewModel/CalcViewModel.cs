using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;

namespace Calculator.ViewModel
{
    public class CalcViewModel
    {
        CalcModel model = new CalcModel();
        MainWindow view = new MainWindow();

        public string Calculator(string firstNumber, string secondNumber, string operation)
        {
            model.FirstNumber = firstNumber;
            model.SecondNumber = secondNumber;
            model.Operation = operation;
            switch (model.Operation)
            {
                case "+":
                    model.Result = (int.Parse(model.FirstNumber) + int.Parse(model.SecondNumber))+"";
                    break;
                
                default:
                    break;
            }
            return model.Result;
        }
    }
}
