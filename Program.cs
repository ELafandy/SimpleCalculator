namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[]args)
        {
            #region ConsoleDisplay
            Console.WriteLine("Hello!");
            Console.Write("Input the first number: ");
            double num1 = ReadInput();
            Console.Write("Input the second number: ");
            double num2 = ReadInput();
            Console.WriteLine("\nWhat do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            Console.Write("Your choice: ");
            char choice = char.Parse(Console.ReadLine());
            Console.WriteLine();
            #endregion
            #region SwitchCase
            switch (choice)
            {
                case 'A':
                case 'a':
                    Addition(num1, num2);
                    break;
                case 'S':
                case 's':
                    Subtraction(num1, num2);
                    break;
                case 'M':
                case 'm':
                    Multiplication(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("\nPress Any Key To Close The program");
            Console.ReadKey();
            #endregion
        }
        #region CheckInput
        static double ReadInput()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid number, Please try again: ");
            }
            return number;
        }
        #endregion
        #region Operation
        static void Addition(double num1, double num2)
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        static void Subtraction(double num1, double num2)
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        static void Multiplication(double num1, double num2)
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        #endregion
    }
}