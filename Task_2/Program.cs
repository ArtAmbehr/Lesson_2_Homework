// 2.	По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB * numberB == numberA || numberA * numberA == numberB)
{
   Console.Write("Да"); 
}
else
{
   Console.Write("Нет"); 
}

