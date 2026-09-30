# Oppgave 01 — Command Receiver

**Hovedfokus:** kontinuerlig while + break

Lag en enkel kommandoreceiver som kjører helt til brukeren skriver `EXIT`.

Krav:
- Bruk `while (true)` eller tilsvarende kontinuerlig løkke.
- Les input med `Console.ReadLine()`.
- Når input er `EXIT`, bruk `break`.
- All annen input skal skrives tilbake som `Received: ...`.
- `null` kan behandles som `EXIT`.

Test med flere kommandoer før du avslutter.

## Kjøring

```bash
dotnet run
```
