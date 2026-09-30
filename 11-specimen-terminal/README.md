# Oppgave 11 — Specimen Terminal

**Hovedfokus:** programtilstand gjennom en session

Lag en liten terminal som holder en liste med specimen-navn i minnet mens programmet kjører.

Kommandoer:
- `ADD` → les et navn og legg det til
- `REMOVE` → les et navn og fjern det
- `LIST` → skriv alle navn
- `COUNT` → skriv antall
- `QUIT` → avslutt

Krav:
- Bruk en kontinuerlig løkke.
- Listen skal opprettes **før** løkken slik at data overlever mellom kommandoene.
- Ugyldige kommandoer skal gi en melding, ikke krasj.

Ikke bruk filer ennå; state skal kun leve mens prosessen kjører.

## Kjøring

```bash
dotnet run
```
