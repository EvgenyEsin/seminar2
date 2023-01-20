// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным


string dayOfWeek (int day)
{
if (day > 0 & day < 8) 
    {
        if (day == 6 || day == 7)
        {
            Console.Write(day +" - выходной");
        }
        else
        {
            Console.Write(day + " - рабочий");
        }
    }
else
    {
        Console.Write("Вы ввели неправильный");
    }
return " день.";
}

Console.Write("Введите день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(dayOfWeek(day));