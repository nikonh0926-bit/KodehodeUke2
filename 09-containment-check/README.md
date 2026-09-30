# Oppgave 09 — Containment Check

**Hovedfokus:** metode som returnerer bool

Lag:

```csharp
static bool CanContain(int capacity, int occupied, int incoming)
```

Metoden skal returnere `true` når de eksisterende og nye objektene samlet får plass i containeren.

Viktig: Metoden skal bare **svare på spørsmålet**. Den skal ikke skrive `ACCEPTED` eller `REJECTED`. Den beslutningen tas av koden som kaller metoden.

Test:
- `(10, 6, 4)` → true
- `(10, 6, 5)` → false
- `(10, 0, 10)` → true

## Kjøring

```bash
dotnet run
```
