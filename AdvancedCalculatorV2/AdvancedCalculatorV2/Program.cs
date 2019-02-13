using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCalculatorV2
{
    class Program
    {
        static string choice;
        static double firstNumber = 0;
        static double secondNumber = 0;
        static double answer = 0.0;
        static string numoperation;
        static string shapechoice;
        static double areat = 0;
        static double areas = 0;
        static double arear = 0;
        static string choice2 = " ";
        static bool condition = true;

        static void Main(string[] args)
        {
            while(condition)
            {
                if (choice2 == "N")
                {
                    condition = false;
                }

                Console.WriteLine("What would you like to calculate? Maths or Shapes?");
                choice = Console.ReadLine();
                if (choice == "Maths")
                {
                    Console.WriteLine("Enter the operator (+,-,/,* or %)");
                    numoperation = Console.ReadLine();

                    Console.WriteLine("Enter first number");
                    firstNumber = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    secondNumber = Convert.ToInt32(Console.ReadLine());

                    switch (numoperation)
                    {
                        case "+":
                            answer = Add(firstNumber, secondNumber);
                            break;
                        case "-":
                            answer = Subtract(firstNumber, secondNumber);
                            break;
                        case "*":
                            answer = Multiplication(firstNumber, secondNumber);
                            break;
                        case "/":
                            answer = Divide(firstNumber, secondNumber);
                            break;
                        case "%":
                            answer = Modular(firstNumber, secondNumber);
                            break;
                        default:

                            Console.WriteLine("This calculator does not understand this function");
                            break;
                    }
                    Console.WriteLine(firstNumber + " " + numoperation + " " + secondNumber + " = " + answer);
                    Console.ReadLine();
                }

                else
                {

                    Console.WriteLine("What shape would you like to calculate? Triangle, Square or Rectangle");
                    shapechoice = Console.ReadLine();

                    if (shapechoice == "triangle")
                    {
                        Console.WriteLine("Enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        areat = Triangle(base1, height1);
                        Console.WriteLine(areat);
                        Console.Read();


                    }
                    else if (shapechoice == "square")
                    {
                        Console.WriteLine("Enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        areas = Square(base1, height1);
                        Console.WriteLine(areas);
                        Console.Read();
                    }
                    else
                    {
                        Console.WriteLine("Enter base");
                        double base1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Enter height");
                        double height1 = double.Parse(Console.ReadLine());

                        arear = Rectangle(base1, height1);
                        Console.WriteLine(arear);
                        Console.Read();
                    }
                    Console.WriteLine("Would you like to calculate something else? Y/N");
                    choice2 = Console.ReadLine();
                }


            }
        }
        static double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
        }
        static double Multiplication(double val1, double val2)
        {
            return val1 * val2;
        }
        static double Divide(double val1, double val2)
        {
            return val1 / val2;
        }
        static double Modular(double val1, double val2)
        {
            return val1 % val2;
        }
        static double Triangle(double val1, double val2)
        {
            return (val1 * val2 * 0.5);
        }
        static double Square(double val1, double val2)
        {
            return (val1 * val2);
        }
        static double Rectangle(double val1, double val2)
        {
            return (val1 * val2);
        }

    }
}

   

            

            
