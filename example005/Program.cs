Console.Write ("Введите Ваше имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{ 
    Console.WriteLine("Ура! Эта Машка!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}