# ADR 004: Prometheus voor monitoring

**Status**: Besloten  
**Datum**: 31 oktober 2024  
**Auteur**: Mitchel Fleury

## Context

Om de prestaties en statistieken van de applicatie te kunnen bijhouden willen we een monitoring tool gebruiken. Een monintoring tool haalt deze gegevens op, slaat deze op en maakt ze inzichtbaar. Het voordeel van het kunnen inzien van deze gegevens is dat je er op kan acteren, bijvoorbeeld als de prestaties van de applicatie niet voldoen aan het gewenste resultaat.

## Besluit

We hebben besloten om gebruik te maken van Prometheus om 'metrics' te kunnen ophalen en opslaan.

## Argumenten

- We kunnen met deze tool de prestaties van het systeem in de gaten houden (bijvoorbeeld CPU gebruik)
- We kunnen 'custom' statistieken aanmaken om onze eigen metrics bij te houden

## Gevolgen

- We kunnen nu de metrics van de applicatie bijhouden
- We zouden alerts kunnen versturen als de prestaties van de applicatie slechter zijn dan gewenst
