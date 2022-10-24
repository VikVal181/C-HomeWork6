// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите коэффициент b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коэффициент b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2) {
    if (b1 == b2) {
        Console.WriteLine("Прямые совпадают, точек пересечения бесконечно много");
    }
    else {
        Console.WriteLine("Прямые паралельны, точек пересечения нет");
    }
}
else {
    double x = Convert.ToDouble(b2 - b1) / (k1 - k2);
    double y = (k1 * x + b1);

    Console.WriteLine($"Точка пересечения прямых: ({x}, {y})");
}

