Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Маша, ты коза?");
}
else{
    Console.Write(username);
    Console.Write(", ты козел?");
}