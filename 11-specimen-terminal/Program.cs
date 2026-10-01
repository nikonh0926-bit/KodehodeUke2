List<string> specimens = new List<string>();

while (true)
{
    Console.Write("Command (ADD/REMOVE/LIST/COUNT/QUIT): ");
    string? command = Console.ReadLine();

    // TODO: Implementer kommandoene.
    if (command == "ADD")
    {
        Console.Write("Enter specimen name: ");
        string? specimenName = Console.ReadLine();
        if (!string.IsNullOrEmpty(specimenName))
        {
            specimens.Add(specimenName);
            Console.WriteLine($"Added: {specimenName}");
        }
    }
    else if (command == "REMOVE")
    {
        Console.Write("Enter specimen name to remove: ");
        string? specimenName = Console.ReadLine();
        if (!string.IsNullOrEmpty(specimenName) && specimens.Remove(specimenName))
        {
            Console.WriteLine($"Removed: {specimenName}");
        }
        else
        {
            Console.WriteLine($"Specimen not found: {specimenName}");
        }
    }
    else if (command == "LIST")
    {
        Console.WriteLine("Specimens:");
        foreach (var specimen in specimens)
        {
            Console.WriteLine(specimen);
        }
    }
    else if (command == "COUNT")
    {
        Console.WriteLine($"Total specimens: {specimens.Count}");
    }
    else if (command == "QUIT")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown command. Please try again.");
    }
    // Tips: specimens må IKKE opprettes på nytt inne i løkken.

    
}
