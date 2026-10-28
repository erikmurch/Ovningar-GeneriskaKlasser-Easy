// Skapa en generisk klass Box<T> som kan lagra ett värde av vilken typ som helst.
//  ✅ Lägg till metoder:
// SetValue(T value)
// GetValue()

// Skriver ut o testar
// När man skriver Box<int> betyder det att T ersätts med int i just den lådan.
var intBox = new Box<int>();
intBox.SetValue(42);
Console.WriteLine(intBox.GetValue());

// Skriver ut o testar
var stringBox = new Box<string>();
stringBox.SetValue("Hej");
Console.WriteLine(stringBox.GetValue());

// Skriver ut o testar
var doubleBox = new Box<double>();
doubleBox.SetValue(14.4);
Console.WriteLine(doubleBox.GetValue());

// <T> gör klassen generisk.
// T är en platshållare för typen som lådan ska innehålla,
// t.ex int, string eller double.
public class Box<T>
{
    // Här sparas värdet som läggs i lådan.
    private T value;

    // Tar emot ett värde av typen T och sparar det i lådan T.
    public void SetValue(T value)
    {
        // this.value betyder fältet ovan.
        // value utan "this" är värdet som skickades in.
        this.value = value;
    }

    // Hämtar och returnerar värdet som finns i lådan.
    public T GetValue()
    {
        return value;
    }
}