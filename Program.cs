//Домашние задания


Random rnd = new Random();

int rndNum = rnd.Next(100, 1000);

Console.WriteLine (rndNum);

int twoNum = rndNum / 10 % 10;

Console.Write (twoNum);




Console.Write("Введите число: ");

int Num = int.Parse(Console.ReadLine());

int thirdNum = Num % 10;

if (Num > 100 && Num < 999)
{
    Console.Write(thirdNum);
}

if (Num < 100)
{
    Console.Write("Третьей цифры нет");
}



Console.Write("Введите номер дня недели: ");

int Num = int.Parse(Console.ReadLine());

if (Num < 6)
{
    Console.Write("Рабочий день");
}
else
{
    Console.Write("Выходной");
}