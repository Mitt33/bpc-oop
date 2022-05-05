using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv09
{
    public class Calculator
    {
        public String Display { get; set; }
        public String Memory { get; set; }
        private enum State
        {
            FirstNum,
            Operation,
            SecondNum,
            Result
        };
        private State _state;
        private string firstNum;
        private string operation;
        private string secondNum;
        private string result;

        private enum Operation
        {
            Plus,
            Minus,
            Multiply,
            Divide
        };
        private Operation _operation;
        public Calculator()
        {
            firstNum = "0";
            operation = "0";
            secondNum = "0";
            result = "0";
            _state = State.FirstNum;
            Display = "0";
            Memory = "0";
        }
        public void Button(string button)
        {
            string number = "";

            switch (button)
            {
                case "+":
                    _state = State.Operation;
                    _operation = Operation.Plus;
                    break;
                case "-":
                    _state = State.Operation;
                    _operation = Operation.Minus;
                    break;
                case "*":
                    _state = State.Operation;
                    _operation = Operation.Multiply;
                    break;
                case "/":
                    _state = State.Operation;
                    _operation = Operation.Divide;
                    break;
                case "=":
                    _state = State.Result;
                    Result();
                    Reset();
                    break;
                case ",":
                    number = button;
                    break;
                case "CE":
                    _state = State.FirstNum;
                    Memory = Display;
                    Display = "0";
                    firstNum = "0";
                    secondNum = "0";
                    result = "0";
                    break;
                case "ANS":
                    _state = State.FirstNum;
                    firstNum = "";
                    number = Memory;
                    break;
                default:
                    if (_state == State.FirstNum)
                    {
                        if (firstNum == "0" || firstNum == "NaN")
                        {
                            firstNum = "";
                            number = button;
                        }
                        else
                        {
                            number = button;
                        }
                    }
                    else if (_state == State.SecondNum)
                    {
                        if (secondNum == "0" || firstNum == "NaN")
                        {
                            secondNum = "";
                            number = button;
                        }
                        else
                        {
                            number = button;
                        }
                    }
                    break;

            }
            switch (_state)
            {
                case State.FirstNum:
                    firstNum += number;
                    Display = firstNum;
                    break;
                case State.SecondNum:
                    secondNum += number;
                    Display = secondNum;
                    break;
                case State.Operation:
                    _state = State.SecondNum;
                    break;
                case State.Result:
                    _state = State.FirstNum;
                    firstNum = Display;
                    break;
            }
        }

        private void Reset()
        {
            firstNum = "0";
            operation = "0";
            secondNum = "0";
            Display = result;
            Memory = result;
        }

        private void Result()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double res = 0;

            firstNumber = Convert.ToDouble(firstNum);
            secondNumber = Convert.ToDouble(secondNum);
            switch (_operation)
            {
                case Operation.Plus:
                    res = firstNumber + secondNumber;
                    break;
                case Operation.Minus:
                    res = firstNumber - secondNumber;
                    break;
                case Operation.Multiply:
                    res = firstNumber * secondNumber;
                    break;
                case Operation.Divide:
                    if (secondNumber == 0)
                    {
                        res = double.NaN;
                    }
                    else
                    {
                        res = firstNumber / secondNumber;
                    }
                    break;
            }

            result = "" + res;
        }
    }
    
}
