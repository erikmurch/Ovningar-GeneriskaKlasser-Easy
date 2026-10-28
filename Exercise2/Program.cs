// 📦 2. Generisk Dubblerare
// Skapa en generisk metod Duplicate<T>(T item) som returnerar en lista med två kopior av objektet.
//  💡 Ex: Duplicate("Hej") → lista med "Hej", "Hej"

// <T> gör metoden generisk, så den kan användas med olika typer.
// Metoden tar emot ett värde av typen T och returnerar en lista med T-värden.
List<T> Duplicate<T>(T item)
    {
        // Skapar en tom lista som kan innehålla värden av typen T.
        List<T> result = new List<T>();

        // Lägger till samma värde två gånger.
        result.Add(item);
        result.Add(item);

        // Skickar tillbaka listan.
        return result;
    }

    List<string> words = Duplicate("Hej");

// Skriver ut båda elementen i listan.
Console.WriteLine(words[0]);
Console.WriteLine(words[1]);