using System;

namespace MyFirstCalculator
{
    class calculate
    {
        double firstNum, secondNum, resNum;
        string operate;

        public calculate()
        {
            firstNum = secondNum = resNum = 0;
            operate = "";
        }

        public string res(string str)
        {
            if (str.Contains("+"))
            {
                operate = "+";
            }
            else if (str.Contains("^"))
            {
                operate = "^";
            }
            else if (str.Contains("t"))
            {
                operate = "t";
            }
            else if (str.Contains("*"))
            {
                operate = "*";
            }
            else if (str.Contains("/"))
            {
                operate = "/";
            }
            else
            {
                operate = "-";
            }

            if (operate != "t")
            {
                firstNum = Convert.ToDouble(str.Substring(0, str.IndexOf(operate)));
                secondNum = Convert.ToDouble(str.Substring(str.IndexOf(operate) + 1));
            }
            else
            {
                operate = str.Substring(str.IndexOf(operate) + 1);
                firstNum = Convert.ToDouble(str.Substring(0, str.IndexOf(operate) - 1));
            }

            switch (operate)
            {
                case "*":
                    resNum = firstNum * secondNum;
                    break;

                case "+":
                    resNum = firstNum + secondNum;
                    break;

                case "-":
                    resNum = firstNum - secondNum;
                    break;

                case "/":
                    if (secondNum != 0)
                    {
                        resNum = firstNum / secondNum;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                    break;

                case "^":
                    resNum = Math.Pow(firstNum, secondNum);
                    break;

                case "sin":
                    resNum = Math.Sin(firstNum);
                    break;

                case "cos":
                    resNum = Math.Cos(firstNum);
                    break;

                case "tan":
                    resNum = Math.Tan(firstNum);
                    break;

                case "exp":
                    resNum = Math.Exp(firstNum);
                    break;

                case "ln":
                    resNum = Math.Log(firstNum);
                    break;
            }



            return str = Convert.ToString(resNum); ;
        }
    }
}

