// Задача 19. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.

/*
bool findPalind (int num)
  {
    if (num < 0)    
    Console.Write($"{num} is less zero");

    int a = num;
    int b;
    int numNew = 0;
    while (a > 0)
{
    b = a % 10;
    a = a / 10;
    numNew = numNew * 10 + b;
      
}
if (numNew == num)
return true;
else return false;
}
  
Console.Write("Input the integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

bool res = findPalind (num);

    if (res)
    Console.WriteLine("This is a palindrom");
    else 
    Console.WriteLine("This is not a palindrom");

*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double lineSegment(double x1, double y1, double z1, double x2, double y2, double z2)

{
double dx = x1 - x2;
double dy = y1 -y2;
double dz = z1 - z2;
double line = Math.Sqrt(dx*dx+dy*dy+dz*dz);
return line;
}

Console.WriteLine("Input x coordinate of the first point");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate of the first point");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z coordinate of the first point");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x coordinate of the second point");
double x2= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate of the second point");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z coordinate of the second point");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"The lenght of the line segment ({x1}, {y1}, {z1}) ({x2}, {y2}, {z2}) is {lineSegment(x1, y1, z1, x2, y2, z2)}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void cubeNum (int num)
{
    int n = 1;
    while (n <= num)
    {
        Console.WriteLine($"Cube of number {n} is {n * n * n}");
        n ++;
    }
}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

cubeNum(num);
*/
