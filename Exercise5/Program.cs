// ⚙️ 5. Generisk Jämförelse
// Skriv en generisk metod AreEqual<T>(T a, T b) som returnerar true om de två värdena är lika.
//  💡 Testa med både tal och text.

// <T> gör metoden generisk, så den kan jämföra olika typer.
// Metoden tar emot två värden av samma typ och returnerar true eller false.
bool AreEqual<T>(T a, T b)
{
	return Equals(a, b);
}

Console.WriteLine(AreEqual(1, 1));
Console.WriteLine(AreEqual("hej", "hej"));
Console.WriteLine(AreEqual("hola", "Hej"));