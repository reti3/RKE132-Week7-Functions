Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput = argument

static void PrintAnyWord(string anyString) //anyString = parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++) //sõna kutsutakse vällja 5 korda
    {
        Console.WriteLine(anyString);
    }
}

