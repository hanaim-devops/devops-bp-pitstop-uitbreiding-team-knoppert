# ADR 003: Horizontal Pod Autoscaler (HPA) in Kubernetes

---

**Status**: Besloten
**Datum**: 31 oktober 2024
**Auteur**: Dirk van Bruxvoort

## Context

Met de mogelijke groei van pitstop en de toenemende vraag naar schaalbaarheid, willen we de mogelijkheid implementeren om automatisch het aantal pods te schalen op basis van de belasting. Het gebruik van de Horizontal Pod Autoscaler (HPA) in Kubernetes biedt ons de flexibiliteit om de resources efficiënt te beheren en de beschikbaarheid van de applicatie te waarborgen, zelfs tijdens piekbelastingen.

## Besluit

We hebben besloten om de Horizontal Pod Autoscaler (HPA) in onze Kubernetes-cluster te implementeren. Dit stelt ons in staat om automatisch het aantal actieve pods aan te passen op basis van realtime metrics, wij gebruiken CPU-gebruik.

## Argumenten

Schaalbaarheid: HPA maakt het mogelijk om de applicatie automatisch te schalen, wat essentieel is voor het beheren van fluctuaties in de vraag. Dit zorgt ervoor dat we altijd voldoende capaciteit hebben zonder onnodige resources te verspillen.

Kostenbesparing: Door automatisch te schalen, kunnen we kosten besparen op infrastructuur door alleen de benodigde resources te gebruiken, afhankelijk van de belasting.

Betere gebruikerservaring: Met HPA kunnen we de prestaties van de applicatie waarborgen, zelfs tijdens hoge belasting, wat leidt tot een betere gebruikerservaring en tevredenheid.

Eenvoudige implementatie: De configuratie van HPA is relatief eenvoudig en kan eenvoudig worden aangepast aan de specifieke behoeften van onze applicatie door gebruik te maken van Kubernetes-configuratiebestanden.

## Gevolgen
De implementatie van HPA stelt ons in staat om de resourceallocatie dynamisch aan te passen, wat leidt tot een efficiënter gebruik van onze Kubernetes-cluster.

We zullen continu de prestaties van de HPA monitoren en de parameters indien nodig aanpassen om te zorgen voor optimale werking en schaalbaarheid.

Door deze beslissing te nemen, bereiden we onze applicatie voor op de toekomst en zorgen we voor een robuuste en schaalbare infrastructuur.