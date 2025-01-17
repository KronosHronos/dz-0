﻿Console.Clear();
int m = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите натуральное число: ", "Ошибка ввода!");
int akkerman = AkkermanFunction(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {akkerman}");

int AkkermanFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    else if (number1 > 0 && number2 == 0) return AkkermanFunction(number1 - 1, 1);
    else if (number1 > 0 && number2 > 0) return AkkermanFunction(number1 - 1, AkkermanFunction(number1, (number2 - 1)));
    else return -1;
}

int GetNumberFromUser(string text, string errorMessage)
{
    while (true)
    {
        Console.Write(text);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        else Console.WriteLine(errorMessage);
    }
}