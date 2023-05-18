Console.WriteLine("Enter your name: ");
string username = Console.ReadLine();

if(username.ToLower() == "vadim")
{
    Console.WriteLine("hi the best user");
}
else 
{
    Console.Write("hello, ");
    Console.WriteLine(username);
}