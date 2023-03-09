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
    return matr;
}

string[] PrintArray(string[] matr)
{
    const string quote = "\"";
    Console.Write("[");
    for (int i = 0; i < matr.Length - 1; i++)
    {
        Console.Write($"{quote}{matr[i]}{quote}  ");
    }
    Console.Write($"{quote}{matr[matr.Length - 1]}{quote}");
    Console.Write("]");
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

int CountSizeMassive(string[] matr)
{
    int count = 0;
    for (int i = 0; i < matr.Length; i++)
    {
        if (matr[i].Length >= 3)
        {
            count++;
        }
    }
    return count;
}


Console.WriteLine ("Welcome, dear user, to my program");
int m = EnterData("Enter size massive");
string[] array = new string[m];

FillArray(array);
Console.WriteLine ("Massive:");
PrintArray(array);

int n = CountSizeMassive(array);
string[] massive = new string[n];

CheckLenghtElement(array, massive);
Console.WriteLine ();
Console.WriteLine ("Massive with elements contain more than three char:");
PrintArray(massive);


