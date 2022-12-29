int a = int.Parse(Console.ReadLine());
int result = 0;

while (a != 0)
{
    result += a % 10;
    a /= 10;
}

Console.WriteLine(result);