# Oppgave 10 — Manifest Search

**Hovedfokus:** collection som parameter + søkemetode

Lag en søkemetode:

```csharp
static bool ContainsItem(List<string> items, string search)
```

Metoden skal iterere gjennom listen selv og returnere `true` hvis en verdi matcher `search` nøyaktig.

Krav:
- Bruk en løkke.
- Returner tidlig når match er funnet.
- Ikke bruk LINQ, `Contains` eller `Any`.

Test både en verdi som finnes og en som ikke finnes.

## Kjøring

```bash
dotnet run
```
