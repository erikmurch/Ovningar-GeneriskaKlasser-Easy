// 🎨 4. Generisk Printer
// Skapa en generisk metod PrintItems<T>(List<T> items) som skriver ut alla element oavsett typ.
// 💡 Testa med listor av string, int och double.

var intList = new List<int>();
intList.Add(42);
Console.WriteLine(intList[0]);

// Skriver ut o testar
var stringList = new List<string>();
stringList.Add("Hej");
Console.WriteLine(stringList[0]);

// Skriver ut o testar
var doubleList = new List<double>();
doubleList.Add(50.5);
Console.WriteLine(doubleList[0]);


void PrintItems<T>(List<T> items)
{
    foreach (T item in items)
    {
        Console.WriteLine(item);
    }
}