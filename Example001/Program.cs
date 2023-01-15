System.Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
if (number2 > max)
{
    max = number2;
    min = number1;
}
System.Console.Write("max = ");
System.Console.WriteLine(max);
System.Console.Write("min = ");
System.Console.WriteLine(min);