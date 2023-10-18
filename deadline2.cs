// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
string stringNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(stringNumber, out number);
if (isNumber && stringNumber.Length >= 3) // isNumber == True
{
    Console.WriteLine($"{stringNumber} => {stringNumber[2]}");
    if(number > 100)
    {
    Console.WriteLine($"Введеное число меньше 3х символов");
    }
    
}
