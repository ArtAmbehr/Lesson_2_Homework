// 1.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите номер дня недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.Write("Выходной");
}  
else
{
  Console.Write("Не выходной");  
}


 