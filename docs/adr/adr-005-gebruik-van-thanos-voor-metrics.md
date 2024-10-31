# ADR 006: Implementatie van Thanos voor Metrics Aggregatie en Opslag

---

**Status**: Besloten  
**Datum**: 31 oktober 2024  
**Auteur**: Jelmer Noppert & ChatGPT

## Context

Binnen ons project is Prometheus geimplementeerd. Maar Prometheus is niet volledig top. Thanos lost enkele gebrekken van Prometheus op. Bijvoorbeeld de schaalbaarheid en hoog beschikbare oplossing voor het verzamelen,
opslaan en raadplegen van metrics uit onze Kubernetes clusters.
We willen een oplossing die deze beperkingen overwint en ons in staat stelt om metrics over meerdere clusters en over een langere periode te analyseren.

## Besluit

We hebben besloten om Thanos te implementeren als uitbreiding op onze huidige Prometheus-opstelling.
Thanos biedt mogelijkheden voor horizontale schaalbaarheid, globale querying en lange-termijnopslag via object storage.

## Argumenten

- **Lange-termijnopslag**: Door metrics op te slaan in object storage via Thanos, kunnen we data over een langere periode behouden.
- Dit is essentieel voor historische analyses en trendonderzoek.
- **Hoge beschikbaarheid**: Thanos zorgt voor redundantie en verhoogt de betrouwbaarheid van onze metrics-infrastructuur.
- Dit betekent dat we minder risico lopen op dataverlies of onderbrekingen in monitoring.
- **Eenvoudige integratie**: Aangezien Thanos ontworpen is om naadloos samen te werken met Prometheus,
- kunnen we het implementeren zonder grote wijzigingen aan onze huidige setup.

## Gevolgen

- **Extra complexiteit**: Het toevoegen van Thanos introduceert nieuwe componenten in onze infrastructuur,
- wat kan leiden tot een hogere complexiteit in beheer en onderhoud.
- **Resourceverbruik**: De Thanos-componenten vergen extra systeembronnen, wat invloed kan hebben op onze operationele kosten en resourceplanning.
- **Leercurve**: Ons team zal tijd moeten investeren in het leren en begrijpen van Thanos om het effectief te kunnen beheren en troubleshooten.
