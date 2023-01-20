// Напишите программу, которая принимает на вход 
// трехзначное число и на выходе показывает
// вторую цифру этого числа

// Первый вариант

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1); // Переводим отрицательное число в положительное
if (number.ToString().Length == 3) { // Проверяем, правильность ввода числа
    int number2 = (number / 10) % 10; // Поиск второй цифры в трехзначном числе
    Console.WriteLine("Вторая цифра числа " + number + " -> " + number2);
}
else {
    Console.WriteLine("Вы ввели не трехзначное число!");
}

// Второй вариант (с использованием метода)

// int secondNumber(int number) // Создаем метод
// {
//     int number2 = (number / 10) % 10;
//     return number2;
// }

// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0) number = number * (-1);
// if (number.ToString().Length == 3)
// {
//     Console.WriteLine("Вторая цифра числа " + number + " -> " + secondNumber(number));
// }
// else
// {
//     Console.WriteLine("Вы ввели не трехзначное число!");
// }