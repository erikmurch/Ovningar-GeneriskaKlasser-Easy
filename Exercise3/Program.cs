// 🧮 3. Enkel Generisk Lista
// Skapa en generisk klass MyList<T> med metoder för att lägga till och visa element.
//  💡 Tips: Använd en intern List<T> inuti klassen.

MyList<string> names = new MyList<string>();
names.Add("Per");
names.Add("Olof");

names.DisplayItems(); // Skriver ut Anna och sedan Bo

public class MyList<Thing>
{
    // Den inre listan lagrar element av typen T.
    private List<Thing> items = new List<Thing>();

    // Lägger till ett element i listan.
    public void Add(Thing item)
    {
        items.Add(item);
    }

    // Går igenom listan och skriver ut varje element.
    public void DisplayItems()
    {
        foreach (Thing item in items)
        {
            Console.WriteLine(item);
        }
    }

    
}



