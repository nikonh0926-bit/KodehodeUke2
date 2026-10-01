string transmission = "AX?19??Q";
int markerCount = 0;
List<int> markerPositions = new List<int>();

// TODO: Bruk for og transmission[i].
for(int i = 0; i < transmission.Length; i++)
{
    if(transmission[i] == '?')
    {
        markerCount++;
        markerPositions.Add(i);
    }
}
Console.WriteLine($"Marker count: {markerCount}");
Console.WriteLine($"Marker positions: {string.Join(", ", markerPositions)}");