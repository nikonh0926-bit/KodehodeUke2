List<string> beacons = new List<string>();

while (true)
{
    string choice = PrintMenu();

    if (choice == "1")
    {
        AddBeacon(beacons);
    }
    else if (choice == "2")
    {
        RemoveBeacon(beacons);
    }
    else if (choice == "3")
    {
        PrintBeacons(beacons);
    }
    else if (choice == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Unknown choice.");
    }
}

// TODO: Refaktorer den fungerende koden over til flere metoder.


static string PrintMenu()
{
    Console.WriteLine();
    Console.WriteLine("1 - Add beacon");
    Console.WriteLine("2 - Remove beacon");
    Console.WriteLine("3 - List beacons");
    Console.WriteLine("4 - Quit");
    Console.Write("Choice: ");
    return Console.ReadLine() ?? "";
}

// adds a new beacon to the list if the name is not empty or whitespace. If the name is valid, it adds the beacon to the list and prints a confirmation message.
static void AddBeacon(List<string> beacons)
{
    Console.Write("Beacon name: ");
    string? name = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(name))
    {
        beacons.Add(name);
        Console.WriteLine("Beacon added.");
    }
}

// removes a beacon from the list if it exists. If the beacon is not found, it prints a message indicating that the beacon was not found.
static void RemoveBeacon(List<string> beacons)
{
    Console.Write("Beacon name: ");
    string? name = Console.ReadLine();
    if (name is not null && beacons.Remove(name))
    {
        Console.WriteLine("Beacon removed.");
    }
    else
    {
        Console.WriteLine("Beacon not found.");
    }
}

// Lists all beacons in the list. If the list is empty, it prints a message indicating that there are no beacons registered.
static void PrintBeacons(List<string> beacons)
{
    if (beacons.Count == 0)
    {
        Console.WriteLine("No beacons registered.");
    }
    else
    {
        foreach (string beacon in beacons)
        {
            Console.WriteLine($"- {beacon}");
        }
    }
}
