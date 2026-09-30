# Oppgave 02 — Corrupt Packet Stream

**Hovedfokus:** continue

En strøm med datapakker inneholder noen ødelagte pakker merket `CORRUPT`.

Iterer gjennom arrayet og:
- hopp over `CORRUPT` med `continue`
- skriv `Processed: ...` for alle andre pakker
- tell antall gyldige pakker

Ikke fjern elementer fra arrayet; poenget er å trene `continue`.

## Kjøring

```bash
dotnet run
```
