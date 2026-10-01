while (true)
{
    Console.Write("Command: ");
    string? command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    if(command == "EXIT")
        break;
    else if(string.IsNullOrWhiteSpace(command))
        Console.WriteLine("invalid command recieved. ");
    else
        Console.WriteLine($"Received: <{command}>"); // TODO: Ellers skriv Received: <command>.
}
Console.WriteLine("Receiver stopped.");