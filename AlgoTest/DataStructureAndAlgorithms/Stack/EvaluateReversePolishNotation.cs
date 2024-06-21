using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoTest.DataStructureAndAlgorithms.Stack
{
    public class EvaluateReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new();
            HashSet<string> operators = new() { "+", "-", "*", "/" };

            foreach (var token in tokens)
            {
                if (operators.Contains(token))
                {
                    int operand2 = stack.Pop();
                    int operand1 = stack.Pop();
                    int result = 0;

                    switch (token)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            result = operand1 / operand2; 
                            break;
                    }

                    stack.Push(result);
                }
                else
                {
                    stack.Push(int.Parse(token));
                }
            }

            return stack.Pop(); 
        }
    }
}
