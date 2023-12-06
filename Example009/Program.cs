Console.WriteLine("Ведите ваше число");
int number = Convert.ToInt32(Console.ReadLine());
int negnumber = number *-1;

while(negnumber <= number)
{
    Console.WriteLine(negnumber);
    negnumber = negnumber + 1;
}
