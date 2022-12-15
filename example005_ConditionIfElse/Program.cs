Console.Write(" Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "амир")
{
    Console.WriteLine("Приветсвую, хозяин!!");
}
else
{
    Console.Write("Оу, ты не мой хозяин. Но так уж и быть, я поприветствую тебя.");
    Console.WriteLine("Здравствуй, " + username + ", но на этом всё!!!");
}
