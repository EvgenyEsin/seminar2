// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает,
// что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1); // Переводим в положительное число
int count = number.ToString().Length; // Запоминаем количество цифр

if (count < 3) Console.WriteLine("Третьей цифры нет");
else
{
    while (count > 3) // Доводим число до трехзначного
    {
        number = number / 10;
        count --;
    }
        
Console.Write("Третья цифра числа -> " + number % 10);
}