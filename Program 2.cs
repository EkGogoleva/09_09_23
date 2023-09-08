// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнений y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

двойная точкаX;
двойная точкаY;

Console.Write("Даны прямые заданные формулы y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди строки b1, k1, b2 и k2 через один пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

если (а == б)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
еще
{
    точкаX = (двойной) (постоянный ток)/(ab);
    pointY = (double) a*(dc)/(ab) + c;
    Console.WriteLine("Координаты точек пересечения двух прямых трансляций:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}