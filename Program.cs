//Домашние задания 1


Random rnd = new Random();

int rndNum = rnd.Next(100, 1000);

Console.WriteLine (rndNum);

int twoNum = rndNum / 10 % 10;

Console.Write (twoNum);


//Домашние задания 2

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



//Домашние задания 3

Console.Write("Введите номер дня недели: ");

int Num = int.Parse(Console.ReadLine());

if (Num > 7)
{
    Console.Write("Это не день недели");
}

if (Num < 6)
{
    Console.Write("Рабочий день");
}
if (Num >= 6 && Num <= 7)
{
    Console.Write("Выходной");
}

