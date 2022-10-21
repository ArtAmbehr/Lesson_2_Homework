// 4.	Найти расстояние между точками в пространстве 2D/3D
Console.Write ("Чтобы получить расстояние между точками в пространстве 2D и 3D, введите координаты точки Ax: ");

int Ax = int.Parse(Console.ReadLine());
Console.Write ("Введите координаты точки Ay: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write ("Введите координаты точки Az: ");
int Az = int.Parse(Console.ReadLine());
Console.Write ("Введите координаты точки Bx: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write ("Введите координаты точки By: ");
int By = int.Parse(Console.ReadLine());
Console.Write ("Введите координаты точки Bz: ");
int Bz = int.Parse(Console.ReadLine());

Console. WriteLine($"Расстояние между точками A и B в 2D равно √{(Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)}, при этом, расстояние между точками A и B в 3D равно √{(Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az)}");
