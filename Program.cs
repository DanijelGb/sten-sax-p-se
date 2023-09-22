String[] råvara = File.ReadAllLines("/Users/DaciBaci/Desktop/adventofcode.com_2022_day_2_input.txt");

var total = 0;

for (int i = 0; i < råvara.Length; i++)
{
    string a = råvara[i];
    if (a.Contains("A")) // sten //
    {
        if (a.Contains("X"))
        {
            total += 3;
        }
        if (a.Contains("Z"))
        {
            total += 4;
        }
        if (a.Contains("Y"))
        {
            total += 8;
        }
    }
    if (a.Contains("B")) // påse
    {
        if (a.Contains("X"))
        {
            total += 1;
        }
        if (a.Contains("Z"))
        {
            total += 5;
        }
        if (a.Contains("Y"))
        {
            total += 9;

        }
    }
    if (a.Contains("C")) //sax
    {
        if (a.Contains("X"))
        {
            total += 2;
        }
        if (a.Contains("Z"))
        {
            total += 6;
        }
        if (a.Contains("Y"))
        {
            total += 7;
        }
    }
}

Console.WriteLine("Slutsumman blir " + total);