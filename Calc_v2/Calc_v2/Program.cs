using Calc_v2;
using System;

class Program: Calculator
{
    static void Main(string[] args)
    {
        ILogger fileLogger = new FileLogger();
        CheckCanLog(fileLogger);

        void CheckCanLog(ILogger logger)
        {
            logger.Log("Calculator has started");
        }

        string appName = Config.AppName;

        Console.WriteLine("++++++++++++++");
        Console.WriteLine($"++{appName}++");
        Console.WriteLine("++++++++++++++");

        char again = 'y';
        while (again == 'y')

        {
            double result;

            Console.WriteLine();
            Console.Write("Please enter first value: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter action (+, -, *, /): ");
            char operate = Convert.ToChar(Console.ReadLine());

            Console.Write("Pleae enter second value: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            if (operate == '+')
            {
                result = Add(firstNumber, secondNumber);
                Operators operators = Operators.Plus;
                Console.WriteLine($"Result: {firstNumber} {operators} {secondNumber} = {result}");
            }
            else if (operate == '-')
            {
                result = Subtract(firstNumber, secondNumber);
                Operators operators = Operators.Minus;
                Console.WriteLine($"Result: {firstNumber} {operators} {secondNumber} = {result}");
                
            }

            else if (operate == '*')
            {
                result = Multi(firstNumber, secondNumber);
                Operators operators = Operators.Multimultiplication;
                Console.WriteLine($"Result: {firstNumber} {operators} {secondNumber} = {result}");
            }
            else if (operate == '/')
            {
                result = Div(firstNumber, secondNumber);
                Operators operators = Operators.Subtract;
                Console.WriteLine($"Result: {firstNumber} {operators} {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine($"Incorrect operator");
            }

            Console.WriteLine("Continue y/n: ");
            again = Convert.ToChar(Console.ReadLine());
        }
    }
}