int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9" M = 13; N = 20. -> "15, 18"
// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

void Recursion64(int counter, int number)
{
    if (counter > number) return; 

    if (counter % 3 == 0)
    {
        Console.WriteLine(counter);
    }
    counter++;

    Recursion64(counter, number);
}

// Console.Clear();
// int counter = Input("введите число M: ");
// int number = Input("введите число N: ");
// Recursion64(counter, number);

int Recursion66(int counter, int number, int result = 0)
{
    if (counter > number) return result; 
    
    result += counter;
    counter++;

    return Recursion66(counter, number, result);
}

// Console.Clear();
// int counter = Input("введите число M: ");
// int number = Input("введите число N: ");
// Console.WriteLine(Recursion66(counter, number));

int Recursion68(int m,int n)
{
    if (m == 0) return (n+1);

    else if (n == 0 && m > 0) return Recursion68(m - 1, 1);
    
    else return Recursion68(m - 1, Recursion68(m,n - 1));
}

// Console.Clear();
// int m = Input("введите первое число: ");
// int n = Input("введите второе число: ");
// Console.WriteLine(Recursion68(m,n));
