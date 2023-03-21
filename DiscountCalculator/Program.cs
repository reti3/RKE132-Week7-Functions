//rakendus, mis arvutab kasutajale allahindlust
// summa < 10, siis allahindlus 1%
// summa >= 10 && summa < 20, siis allahindlus 5%
// summa >= 20, siis allahindlus 10%

Console.WriteLine("Provide total: ");
int userInput = Int32.Parse(Console.ReadLine());

double discount = CalculateDiscount(userInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(userInput, discount);

// double newTotal = userInput - (userInput * discount) / 100; - selle asemel saab kasutada ülalpool olevat funktsiooni

Console.WriteLine($"Your updated total with {discount}%:  {newTotal}");


static double CalculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if(total >= 10 && total < 20)
    {
        return 5;
    }

    else
    {
        return 10;
    }
}


static double CalculateNewTotal (double total, double discount) //ei ole sama, mis eelmises plokis, seepärast võib kasutada samu nimesid nt total
{
    double result = total - (total * discount) / 100;
    return result; //tulemuse salvestamine vahemälusse
}

