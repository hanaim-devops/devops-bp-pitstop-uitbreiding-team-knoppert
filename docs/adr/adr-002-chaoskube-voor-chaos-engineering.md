# ADR 002: ChaosKube voor Chaos Engineering

---

**Status**: Besloten  
**Datum**: 30 oktober 2024  
**Auteur**: Jelle Schrans

## Context

Om te kunnen testen of ons systeem bestand is tegen storingen en onverwachte gebeurtenissen, willen we Chaos Engineering toepassen. Chaos Engineering is een discipline die zich richt op het testen van systemen onder onverwachte omstandigheden, waarbij onverwachte storingen worden doorgevoerd in je software omgeving. Door deze tests uit te voeren, kunnen we de veerkracht en betrouwbaarheid van ons systeem testen en waar nodig verbeteren.

## Besluit

In eerste instantie leek de applicatie in Kubernetes niet helemaal goed te draaien dus lukte het ook niet om te testen of ChaosKube goed zou werken in de Pitstop applicatie. Uiteindelijk is dit toch gelukt en is het gelukt om ChaosKube te implementeren, wat uiteindelijk verder ook weinig problemen heeft opgeleverd.

## Argumenten

- **Betrouwbaarheid testen**: Door Chaos Engineering toe te passen, kunnen we de betrouwbaarheid van ons systeem testen en eventueel verbeteren als blijkt dat het systeem niet goed met storingen om kan gaan.
- **Makkelijke implementatie**: De implementatie van ChaosKube in Kubernetes was relatief eenvoudig en leverde weinig problemen op. In een [configuratie bestand](../../src/k8s/chaoskube/chaoskube.yaml) kan gedefinieerd worden welke pods ChaosKube mag targeten zodat er makkelijk verschillende tests uitgevoerd kunnen worden.

## Gevolgen

- Door Chaos Engineering toe te passen, kunnen we de veerkracht van ons systeem verbeteren en eventuele zwakke punten identificeren.
- We kunnen makkelijk tests uitvoeren om te zien hoe ons systeem reageert op storingen en onverwachte gebeurtenissen door de configuratie aan te passen naar wat gewenst is om specifieke tests uit te voeren.
