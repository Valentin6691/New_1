Console.WriteLine("Ведите ваше число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите ваше число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите ваше число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > max)
{
max = b;
}
else if(c > max)
{
    max = c;
}
else
{
    max = a;
}
Console.WriteLine(max);