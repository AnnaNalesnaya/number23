// Задача 21 расстояние между двумя точками в зD прастранстве
Console.WriteLine("Введите x1 ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1 ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1 ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2 ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2 ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2 ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistionse(x1, y1, x2, y2, z1, z2));
double GetDistionse(int x1, int y1, int z1, int x2, int y2, int z2)
{
  double distionse = 0;  
  distionse = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
  return distionse;
}
