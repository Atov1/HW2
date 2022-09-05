Console.WriteLine("Введите трехзначное число");
int a = Int32.Parse(Console.ReadLine());

a = a / 10;
a = a % 10;

if (a < 0)
{
    a = a * -1;
    Console.WriteLine(a);
}
else Console.WriteLine(a);