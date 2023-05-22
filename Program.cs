//Домашние задания 1

Console.Write("Введите первое число: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber>secondNumber)

{
Console.WriteLine("Большее число " + firstNumber + " Меньшее число " + secondNumber);
}
else
{
    Console.WriteLine("Большее число " + secondNumber + " Меньшее число " + firstNumber);
}



//Домашние задания 2

Console.Write("Введите первое число: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");

int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

int max;

if (firstNumber>secondNumber)
{
    max = firstNumber;
}
else
{
   max = secondNumber; 
}
if (max>thirdNumber)

Console.WriteLine(max);

else
{
    Console.WriteLine(thirdNumber);
}



//Домашние задания 3
Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int point = 0;

while (point<=N)
{
    Console.WriteLine(point);
    point = point + 2;
}



//Домашние задания 4

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

if (N%2 == 0)

Console.WriteLine("Да");

else

Console.WriteLine("Нет");

