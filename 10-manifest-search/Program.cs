List<string> manifest = new List<string> { "LENS", "BATTERY", "FILTER", "CABLE" };

Console.WriteLine(ContainsItem(manifest, "FILTER"));
Console.WriteLine(ContainsItem(manifest, "WRENCH"));

static bool ContainsItem(List<string> items, string search)
{
    // TODO: Søk med løkke.
    return false;
}
