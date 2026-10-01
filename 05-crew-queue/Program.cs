List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

// TODO: Endre listen etter instruksjonene.
crew.Add("Mira");
crew.Add("Sol");
crew.Remove("Bex");
Console.WriteLine($"Crew count: {crew.Count}");
// TODO: Skriv alle navn med en løkke.
for (int i = 0; i < crew.Count; i++)
{
    Console.WriteLine($"Crew member {i + 1}:{crew[i]}");
}