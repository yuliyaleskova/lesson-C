Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() =="julia")
{
Console.WriteLine("Ура,это же Julia!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}