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
        Console.WriteLine($"Enter {i + 1} element massive");
        elem = Console.ReadLine();
        matr[i] = elem;
    }
    // Console.WriteLine($"Massive = [{string.Join(", ", matr)}]");
    return matr;
}

string[] PrintArray(string[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        Console.Write($"{matr[i],4} ");
    }
    return matr;
}

string[] CheckLenghtElement(string[] matr, string[] arr)
{
    for (int i = 0, j = 0; i < matr.Length; i++)
    {
        if (matr[i].Length >= 3)
        {
            arr[j] = matr[i];
            j++;
        }
    }
    return arr;
}

int m = EnterData("Enter size massive");
string[] array = new string[m];

FillArray(array);
Console.WriteLine ("Massive:");
PrintArray(array);

string[] massive = new string[m];

CheckLenghtElement(array, massive);
Console.WriteLine ();
Console.WriteLine ("Massive with elements contain more than three char:");
PrintArray(massive);


