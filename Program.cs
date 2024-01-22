void ShowArray(string[] a)
{
    if (a.Length == 0)
    {
        Console.Write("< Empty array >");
        return;
    }
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + " ");
    }
    Console.WriteLine();
}

void ProcessingArray(string[] a, ref string[] b)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i].Length <= 3)
        {
            Array.Resize(ref b, b.Length + 1);
            b[b.Length - 1] = a[i];
        }
    }
}

string[] StartArray = new string[]{"Table", "Wood", "Pen", "Football", "Dog", "Face"};
string[] FinalArray = new string[0];

ProcessingArray(StartArray, ref FinalArray);
ShowArray(StartArray);
ShowArray(FinalArray);