// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите число ");
int number = Convert.ToInt32(Console.ReadLine());
void GetCubNumber(int num)
{
    int count = 1;
    while (count <= Math.Abs(num))
    {
        Console.WriteLine ($"куб числa {count} is {Math.Pow(count, 3)}");
        count++;
    }
}
GetCubNumber(number);
