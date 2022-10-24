// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositive(int[] Array) {
    int count = 0;

    for (int i = 0; i < Array.Length; ++i) {
        if (Array[i] > 0) {
            count++;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количество элементов массива");
int M = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[M];

Console.WriteLine("Заполните элементы массива");
for (int i = 0; i < M; ++i) {
    Array[i] = Convert.ToInt32(Console.ReadLine());
}

int Count = CountPositive(Array);

Console.Write($"\nКоличество чисел больше 0: {Count}");