using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть перше число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введіть друге число:");
        string input2 = Console.ReadLine();

        input1 = input1.Replace('.', ',');
        input2 = input2.Replace('.', ',');

        if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
        else
        {
            Console.WriteLine("Некоректний ввід. Будь ласка, введіть числа коректно.");
        }

        Console.ReadLine();
    }
}
