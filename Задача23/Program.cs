// Напишите программу, кот принимает число (N) и выдает таблицу кубовчисел от 1 до N
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
GetCubNumber(num);

void GetCubNumber(int num)
{
    int count = 1;
    while(count <= num);
    {
        Console.WriteLine($"квадрат числа {count} = {count*count*count}");
        count++;
    }
}   