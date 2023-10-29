string Greeting= " Hello ";
string Name;
Console.WriteLine("Whats is Your Name ?");
Name = Console.ReadLine();
Console.WriteLine(Greeting +" "+ Name);
Console.WriteLine("Do you Want To Play Some Games? \nEnter 0 for NO and 1 for YES ? ");
ConsoleKeyInfo keyInfo = Console.ReadKey();

if (keyInfo.KeyChar == '0')
{
    Console.WriteLine("\nGo Away, Stupid!!");
}
else if (keyInfo.KeyChar == '1')
{
    Console.WriteLine("\nWelcome to this game");
}