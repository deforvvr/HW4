//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow

int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine()); //a - число которое возводим в степень, b - степень, в которую возводим
int c = a;

for (int i = 1; i < b; i++)
{
    a = a * c;
}

Console.WriteLine(a);