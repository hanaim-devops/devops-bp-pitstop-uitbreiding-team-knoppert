# Eigen bijdrage Jelmer Noppert


## 1. Code/platform bijdrage

Ik ben gestart met het opzetten van onze benodigde structuur in de frontend (webApp).
Ik heb voor de Doe het zelf avond (ook wel in het Engels: Do it yourself, DIY) de alle benodigde componenten en logica gemaakt volgens de MVC structuur.
Dat is hier te vinden: [diy startup](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/31)

Vervolgens heb ik mijn userstory uitgewerkt in die frontend en backend. Ik moest bij die [userstory](https://github.com/orgs/hanaim-devops/projects/31/views/1?pane=issue&itemId=83412406&issue=hanaim-devops%7Cdevops-bp-pitstop-uitbreiding-team-knoppert%7C1)
het mogelijk maken dat via de frontend een reparateur een doe het zelf avond kan maken. Voor de frontend moest ik een pagina maken, modellen, controllers en view.

**kort tekstje geen testen gedaan want, en kijk ook ADR. 
wel handmatige testen, die staan bij; documentatrie**

## 2. Bijdrage app configuratie/containers/kubernetes - Klaar!!

Ik heb kort een teamgenoot geholpen met het een probleem. Het probleem was dat de backend service container steeds werdt afgesloten. Ik heb dit opgelost: https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/33/commits/d962971291ac93bd42b2b8009c093b8aec6af549

Daarnaast heb ik ook de app settings aangepast zodat dit met de nieuwe backend service werkt: [appsettings.Production.json](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/31/files#diff-324e1a9f613e28efa076b2f5094ff8cd2dab1e38f03301bf6d975588764b8b8c)

Ik heb met containers, configuratie en kubernetes gewerkt toen ik Thanos ben gaan implementeren. Ik heb als eerst dit via [Docker compose](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/commits/bd9d0f5e6945803710915ade2db287d2fe7cd04c) gemaakt. 
Vervolgens heb ik dit in de kubernetes ook verwerkt. 
Ik heb een map voor de monitoring gemaakt en daar de benodigde namespace, services en deployments in gezet.  Ik heb de verschillende components van Thanos uitgewerkt, gezorgd dat deze worden opgeslagen in MinIO en enkele bestaande Prometheus configuraties aangepast.
Alle wijzingen die ik heb toegevoegd zijn hier te vinden: [thanos k8s](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring - Klaar!!

Bij deze competentie heb ik twee grootte dingen aan gewerkt. Ik heb als eerst monitoring toegevoegd in de vorm van Thanos. 
Thanos is een uitbreiding van Prometheus.
Ik heb dit gedaan door een nieuwe namespace aan te maken, de benodigde services en deployments te maken en de configuratie van Prometheus aan te passen.
Ik heb dit gedaan in de kubernetes configuratie. Al mijn Thanos toevoegingen kunnen hier gevonden worden: [thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61)

Vervolgens heb ik ook gewerkt aan de CI/CD pipeline. Ik heb een nieuwe workflow gemaakt waarbij de hele applicatie wordt gebuild en getest, gepublished en gedeployed. Ik heb dat gedaan door een nieuwe workflow aan te maken in de .github/workflows map. Deze workflow bouwt eerst de applicatie (de pitstop applicatie ook wel de solution) en test deze. Vervolgens worden de images gebouwd en gepublished naar de publieke Docker Registry. 
Als laatste wordt via Minikube de applicatie gedeployed op onze Rancher cluster. De hele workflow en benodigde wijzigingen zijn hier te vinden: [CI/CD pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/39/files)

## 4. Onderzoek

**Thanos implementatie**

## 5. Bijdrage code review/kwaliteit anderen en security

**Thanos implementatie**

## 6. Bijdrage documentatie

**Misschien C4 voor Thanos implementatie en enkele ADRs?**

**Userstorys gewerkt**

testplan; https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/81
maar die kan ook bij testen? 
de commit, if nodig;
https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/81/commits/d4bda874efae10a27f7d8fa6ecb928aa90a5789c

kan ook die readme voor prom en th

https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/files#diff-e1d5879ce3e222eb0cdd43051fb8c34c00796467acb091d0b3fa939ee3355cb5

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Ik heb op dinsdag een daily stand-up geleid. Ik ben begonnen met het vragen van de progressie, results en problemen van de vorige dag aan de eerste teamgenoot. Ik heb dit aan alle teamgenoten gevraagd en bewaakt dat iedereen aan het woord kwam. Vervolgens heb ik de planning van de dag besproken en de teamgenoten gevraagd wat ze gingen doen. Ik heb de stand-up afgesloten met een vraag of er nog problemen waren en of iemand hulp nodig had.

Volgens onze planning ga ik maandag notuleren bij de planning en dinsdag de retrospective leiden. 

    en waar is die MR van mijn notule!!

## 8. Leerervaringen



## 9. Conclusie & feedback

