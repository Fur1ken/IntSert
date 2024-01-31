//Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
static void Inter(int m, int n)
{
    if (m > n)
    {
    return;
    }
        Console.Write($"{m} ");
        Inter(m + 1, n);
}
Inter(m, n);


//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
if (m == 0) 
return n + 1;
else if (n == 0) 
return Akkerman(m - 1, 1);
else 
return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write($"Функция Аккермана: {Akkerman(m, n)} ");


//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.
void PrintArray(int[] arr, int i)
{
    if (i >= 0)
    {
        Console.Write($"{arr[i]} ");
        PrintArray(arr, i-1);
    }
}
int[] arr = {11, 52, 43, 14, 5, 86};
PrintArray(arr, arr.Length-1);