string[] array = new string[7] { "Germany", "50", ":-(", "-76", "kitten", "7362", "0" };

string[] ResultArray = GetResultArray(array);
Console.WriteLine($"[{String.Join(", ", ResultArray)}]");

string[] GetResultArray(string[] array)
{
    int CountElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            CountElements++;
        }
    }

    string[] ResultArray = new string[CountElements];

    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            ResultArray[n] = array[i];
            n++;
        }
    }
    return ResultArray;
}