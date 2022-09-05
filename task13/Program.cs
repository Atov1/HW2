Console.WriteLine("Введите число");
int a = Int32.Parse(Console.ReadLine());
if (a < 99 & a >0 || a > -99 & a < 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if(a < 0)
    {a = a * -1;
    string str = a.ToString();
    Console.WriteLine(str[2]);}
    else {
        string str = a.ToString();
        Console.WriteLine(str[2]);
    }
}