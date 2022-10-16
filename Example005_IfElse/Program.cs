Console.WriteLine("Enter your USERNAME:");
string username = Console.ReadLine();

if (username.ToLower() == "masha")  //ToLower() - переводит значение переменной в нижний регистр
{
    Console.WriteLine("URA! This is MASHA!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}