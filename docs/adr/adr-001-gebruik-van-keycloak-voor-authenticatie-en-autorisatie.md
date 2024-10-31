# ADR 001: Gebruik van Keycloak voor Authenticatie en Autorisatie

---

**Status**: Besloten  
**Datum**: 26 oktober 2024  
**Auteur**: Jorian Roelofsen & CHATGPT

## Context

Binnen ons project waren we bezig met het implementeren van authenticatie en autorisatie in een frontend .NET applicatie. Om dit te realiseren, hebben we gekozen voor Keycloak als Identity en Access Management (IAM) oplossing. Keycloak biedt uitgebreide mogelijkheden voor het beheren van gebruikers, rollen, en rechten, en leek aanvankelijk een geschikte keuze.

## Besluit

Na verschillende pogingen om Keycloak te integreren in de frontend .NET applicatie, liepen we tegen onoplosbare problemen aan. Deze problemen hadden te maken met compatibiliteitsissues en de complexiteit van de integratie, zoals beschreven in [issue #9](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/issues/9). Gezien de beperkte tijd die we hadden om deze problemen op te lossen, hebben we besloten om Keycloak niet verder te implementeren.

Uiteindelijk hebben we besloten om authenticatie en autorisatie in deze fase van het project niet te implementeren.

## Argumenten

- **Tijdslimiet**: De tijd die nodig zou zijn om de [integratieproblemen](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/issues/9) op te lossen, paste niet binnen de strakke deadlines van het project.
- **Complexiteit**: De integratie van Keycloak in onze specifieke technologieën bleek ingewikkelder dan verwacht, wat het risico op toekomstige problemen vergrootte.
- **Prioriteiten**: Gezien de beperkte tijd en de complexiteit van de integratie, hebben we ervoor gekozen om onze middelen te richten op andere essentiële functionaliteiten.

## Gevolgen

- Het project bevat geen implementatie van authenticatie en autorisatie op dit moment.
- In een toekomstige fase kan een andere oplossing voor authenticatie en autorisatie worden overwogen, of kan Keycloak opnieuw geëvalueerd worden wanneer er meer tijd beschikbaar is.
