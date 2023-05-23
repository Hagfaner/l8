using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using lab8;
namespace lab8
{
    internal class Standart
    {
        public string place_number(char num,string display)
        {
            
            switch (num)
            {
               
                case '0':
                    display += "0";
                    break;
                case '1':
                    display += "1";
                    break;
                case '2':
                    display += "2";
                    break;
                case '3':
                    display += "3";
                    break;
                case '4':
                    display += "4";
                    break;
                case '5':
                    display += "5";
                    break;
                case '6':
                    display += "6";
                    break;
                case '7':
                    display += "7";
                    break;
                case '8':
                    display += "8";
                    break;
                case '9':
                    display += "9";
                    break;
                default:
                    break;
            }
            return display;
        }
        public char operations(object sender)
        {
            string buf = sender.ToString();
            char oper = buf[buf.Length - 1];
            return oper;
        }
        public string calculation(string expression, char operation)
        {
            double res = 0;
            string[] buf;
           switch(operation) {
                case '+':
                    buf=expression.Split(" + ");
                    res = double.Parse(buf[0]) + double.Parse(buf[1]);
                    break;
                case '-':
                    buf = expression.Split(" - ");
                    res = double.Parse(buf[0]) - double.Parse(buf[1]);
                    break;
                case '/':
                    buf = expression.Split(" / ");
                    res = double.Parse(buf[0]) / double.Parse(buf[1]);
                    break;
                case '*':
                    buf = expression.Split(" * ");
                    res = double.Parse(buf[0]) * double.Parse(buf[1]);
                    break;
                default:
                    break;
            }
            return res.ToString();
        }
        public string pow_2(string expression)
        {
            double x = double.Parse(expression);
            return (x * x).ToString();
        }
        public string div1x(string expression)
        {
            double x = double.Parse(expression);
            return (1.0/x).ToString();
        }
        public string sqrtx (string expression)
        {
            double x = double.Parse(expression);
            return Math.Sqrt(x).ToString();
        }
        public string negativ(string expression) {
            if (expression[0] != '-')
            {
                expression = '-' + expression;
            }
            else
            {
                expression=expression.Substring(1);
            }
            return expression;
        }
        public string powof2(string expression)
        {
            double x = double.Parse(expression);
            return Math.Pow(2, x).ToString();
        }
    }
}
