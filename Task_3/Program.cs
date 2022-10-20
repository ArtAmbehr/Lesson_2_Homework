// 3.	Задать номер четверти, показать диапазоны для возможных координат
Console.Write ("Введите номер четверти от 1 до 4, чтобы узнать диапазоны для возможных координат в ней: ");
int quarterNum = int.Parse(Console.ReadLine());

if (quarterNum == 1)
{
    Console. WriteLine("Координаты: х > 0, y > 0");
}
else if (quarterNum == 2)
{
    Console. WriteLine("Координаты: х < 0, y > 0");
}
else if (quarterNum == 3)
{
    Console. WriteLine("Координаты: х < 0, y < 0");
}
else if (quarterNum == 4)
{
    Console. WriteLine("Координаты: х > 0, y < 0");
}
else
{
    Console. WriteLine("Укажите корректный номер четверти от 1 до 4");
}

