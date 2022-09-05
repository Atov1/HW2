Console.WriteLine("Введите день");
int date = Int32.Parse(Console.ReadLine());

if(date<1 || date>7)
{
    Console.WriteLine("Введите верный день");
}
else
{
    if (date >= 6)
    {
        Console.WriteLine("это выходной");
    }
    else
    {
        Console.WriteLine("это будний день");
    }
}