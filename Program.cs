using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1;
           int num2;
           string operand;
           float answer;

           Console.WriteLine("Please Enter 1`st Number:\n");
           num1 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Please choose operand (+, *, -, /):\n");
           operand = Console.ReadLine();
 
           Console.WriteLine("Please Enter 2`nd Number:\n");
           num2 = Convert.ToInt32(Console.ReadLine());

           switch (operand)
           {
            case "+":
                answer = num1 + num2;
                break;
            case "*":
                answer = num1 * num2;
                break;
            case "-":
                answer = num1 - num2;
                break;
            case "/":
                answer = num1 / num2;
                break;
            default:
                answer = 0;
                break;
           }

           Console.WriteLine("Your Answer is:\n" + num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
           Console.ReadLine(); 
        }
    }
}
