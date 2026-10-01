string[] packets = { "P-100", "CORRUPT", "P-101", "P-102", "CORRUPT", "P-103" };
int processedCount = 0;

foreach (string packet in packets)
{
    // TODO: Bruk continue for CORRUPT.
    if(packet.Contains("CORRUPT"))
        continue;
    else
        Console.WriteLine($"Processed: {packet}");// TODO: Prosesser resten og øk processedCount.
        processedCount++;
}

Console.WriteLine($"Processed packets: {processedCount}");
