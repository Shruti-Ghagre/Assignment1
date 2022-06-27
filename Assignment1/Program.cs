using System;

namespace Assignment1
{

    public class Calculator
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Substraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            int op = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the input value1");
            int input1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the input value2");

            int input2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (op)
            {
                case 1:
                    {
                        result = Addition(input1, input2);
                        break;
                    }
                case 2:
                    {
                        result = Substraction(input1, input2);
                        break;
                    }

                case 3:
                    {
                        result = Multiplication(input1, input2);
                        break;
                    }

                case 4:
                    {
                        result = Division(input1, input2);
                        break;
                    }
                default:

                    Console.WriteLine("Operation does not exist.");
                    break;
            }
            Console.WriteLine("Result is {0}", result);
            Console.ReadKey();
        }
        public static int Addition(int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }

        public static int Substraction(int input1, int input2)
        {
            int result = input1 - input2;
            return result;

        }

        public static int Multiplication(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }

        public static int Division(int input1, int input2)
        {
            int result = input1 / input2;
            return result;
        }
    }
}
