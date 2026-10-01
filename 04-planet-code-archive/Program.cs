string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
Console.WriteLine($"Length: {planetCodes.Length}, First: {planetCodes[0]}, Last: {planetCodes[planetCodes.Length - 1]}");

// TODO: Finn KAPPA-9 med en løkke.
foreach(string planet in planetCodes)
if(planet == "KAPPA-9")
{
    found = true;
    break;
}
Console.WriteLine($"Found KAPPA-9: {found}");
