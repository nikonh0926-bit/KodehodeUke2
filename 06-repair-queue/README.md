# Oppgave 06 — Repair Queue

**Hovedfokus:** iterasjon over collections

En reparasjonskø inneholder både aktive og kansellerte jobber. Kansellerte jobber begynner med `"CANCELLED:"`.

Bruk én løkke til å:
- hoppe over kansellerte jobber
- nummerere bare jobbene som faktisk skal utføres fra 1 og oppover
- skrive f.eks. `Job 1: Replace antenna`

Bruk `continue` der det gir mening.

## Kjøring

```bash
dotnet run
```
