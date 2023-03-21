Console.WriteLine("Are you coming or leaving? (in/out)");
string UserChoice = Console.ReadLine();

if(UserChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


PrintHello();//call-on method/käsud
PrintGoodBye();



static void PrintHello() //function e meetod; () tähendab, et tee midagi
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}