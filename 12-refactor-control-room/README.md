# Oppgave 12 — Refactor the Control Room

**Hovedfokus:** dele funksjonalitet opp i metoder

Programmet i `Program.cs` fungerer allerede, men nesten all logikk ligger inne i hovedløkken.

Refaktorer uten å endre funksjonaliteten.

Trekk ut meningsfulle metoder, for eksempel:
- `PrintMenu()`
- `AddBeacon(...)`
- `RemoveBeacon(...)`
- `PrintBeacons(...)`

Krav:
- Programmet skal oppføre seg likt før og etter refaktoreringen.
- Minst tre separate hjelpe-/operasjonsmetoder skal opprettes.
- Ikke lag metoder bare for én enkelt `Console.WriteLine` hvis de ikke uttrykker en meningsfull oppgave.

## Kjøring

```bash
dotnet run
```
