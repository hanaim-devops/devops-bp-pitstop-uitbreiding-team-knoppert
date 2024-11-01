# ADR 006: Geen Implementatie van Automatische Code Tests

---

**Status**: Besloten  
**Datum**: 31 oktober 2024  
**Auteur**: Jelmer Noppert, Mitchel Fleury & ChatGPT

## Context

In het kader van ons twee weken durende project hebben we overwogen om automatische code tests te implementeren, zoals unit tests, integratietests en end-to-end tests. Automatische tests zijn essentieel voor het waarborgen van de kwaliteit en betrouwbaarheid van software. Echter, gezien de aard en de complexiteit van onze toevoeging aan Pitstop moeten we een beslissing nemen over het al dan niet implementeren van automatische tests.

## Besluit

We hebben besloten om geen automatische code tests te implementeren in dit project. In plaats daarvan hebben we, met goedkeuring van de docent, handmatige tests uitgevoerd om de functionaliteit en stabiliteit van onze applicatie te waarborgen.

## Argumenten

- **Tijdslimiet**: Het opzetten en schrijven van automatische tests vergt aanzienlijke tijd, die binnen ons twee weken durende project niet beschikbaar was.
- **Complexiteit van de applicatie**: Onze applicatie heeft volgens onze mening niet bijzonder genoege functionaliteiten en om aanzienlijk veel tijd te spenderen aan automatische tests. De toevoeging zou niet in verhouding staan van te besteden tijd tot de impact van tests door de complexiteit van de applicatie.
- **Prioriteitenstelling**: Gezien de beperkte tijd hebben we ervoor gekozen om onze inspanningen te richten op anderen aspecten van dit project, zoals het toepassen van de onderzochte blog techniek en het implementeren van de functionaliteiten.
- **Goedkeuring docent**: In overleg met de docent is besloten dat handmatige tests voldoende zijn voor de doeleinden van dit project.

## Gevolgen

- **Risico op onopgemerkte fouten**: Zonder automatische tests is er een verhoogd risico dat bepaalde fouten of regressies onopgemerkt blijven.
- **Toekomstige uitbreidingen**: Mocht de applicatie in de toekomst worden uitgebreid, dan kan het noodzakelijk zijn om alsnog automatische tests te implementeren om de kwaliteit te waarborgen.
- **Efficiënt gebruik van tijd**: Door te kiezen voor handmatige tests hebben we onze tijd efficiënt kunnen besteden aan het ontwikkelen van de belangrijkste onderdelen van het project.
