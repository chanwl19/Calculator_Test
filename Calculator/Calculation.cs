using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculation
    {
        private delegate decimal Operation(decimal num1, decimal num2);
        public static string calculationEquation(List<string> equation) {
            Console.WriteLine("Equation " + String.Join(",", equation));
            //foreach (var item in equation)
            //{
            //    Console.WriteLine("Oriinal " + item);
            //}

            if (equation.Count <= 2) {
                return equation[0].ToString();
            }

            decimal returnVal = decimal.Zero;
            while (equation.IndexOf("*") > 0){
                int multIndx = equation.IndexOf("*");

                if (multIndx == equation.Count - 1) {
                    break;
                } 
                    
                string num1Str = equation[multIndx - 1];
                string num2Str = equation[multIndx + 1];
                if (num2Str.IndexOf("/") > 0){
                    returnVal = calculateValue(Decimal.Divide, Convert.ToDecimal(num1Str), Convert.ToDecimal(num2Str.Split('/')[1]));
                } else {
                    returnVal = calculateValue(Decimal.Multiply, Convert.ToDecimal(num1Str), Convert.ToDecimal(num2Str));
                }
                equation.RemoveAt(multIndx + 1);
                equation.RemoveAt(multIndx);
                equation[multIndx - 1] = returnVal.ToString();
            }

            while (equation.IndexOf("+") > 0){
                int addIndex = equation.IndexOf("+");

                if (addIndex == equation.Count - 1){
                    break;
                }
                string num1Str = equation[addIndex - 1];
                string num2Str = equation[addIndex + 1];

                if (num2Str.IndexOf("-") >= 0){
                    returnVal = calculateValue(Decimal.Subtract, Convert.ToDecimal(num1Str), Convert.ToDecimal(num2Str.Substring(1)));
                } else {
                    returnVal = calculateValue(Decimal.Add, Convert.ToDecimal(num1Str), Convert.ToDecimal(num2Str));
                }
                equation.RemoveAt(addIndex + 1);
                equation.RemoveAt(addIndex);
                equation[addIndex - 1] = returnVal.ToString();
            }

            //foreach (var item in equation) {
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Return value " + returnVal.ToString());
            return returnVal.ToString();
        }

        private static decimal calculateValue(Operation opr, decimal num1, decimal num2) {
            return opr(num1, num2);
        }
    }
}
