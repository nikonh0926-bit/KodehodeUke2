# Oppgave 08 — Jump Calculation

**Hovedfokus:** flere parametere og returverdi

Lag en metode som beregner drivstoffbehov:

```csharp
static int CalculateFuel(int distance, int fuelPerUnit, int reserve)
```

Formel:

```text
distance * fuelPerUnit + reserve
```

Kall metoden med minst disse testene:
- `(10, 3, 5)` → `35`
- `(0, 4, 12)` → `12`
- `(7, 2, 0)` → `14`

Poenget er å sende **flere argumenter** inn og få én verdi tilbake.

## Kjøring

```bash
dotnet run
```
