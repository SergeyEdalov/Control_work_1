int EnterData(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

string[] FillArray(string[] matr)
{
    string elem = String.Empty;
    for (int i = 0; i < matr.Length; i++)
    {
        Console.WriteLine($"Enter {i+1} element massive");
        elem = Console.ReadLine();
        matr[i] = elem;
    }
    Console.WriteLine($"Massive = [{string.Join(", ", matr)}]");
    return matr;
}



int m = EnterData("Enter size massive");
string[] array = new string[m];

FillArray(array);





