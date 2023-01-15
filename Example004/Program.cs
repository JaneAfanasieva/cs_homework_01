System.Console.WriteLine("Введите любое число начиная от 1:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1) 
{
    System.Console.WriteLine("Вы ввели число меньше 1");
    return;
}
int curentNumber = 2;
while (curentNumber <= number)
{
    System.Console.WriteLine(curentNumber);
    curentNumber = curentNumber + 2;
}   