# Eigen bijdrage Jelmer Noppert


## 1. Code/platform bijdrage - klaar!

Ik ben gestart met het opzetten van onze benodigde structuur in de frontend (webApp).
Ik heb voor de Doe het zelf avond (ook wel in het Engels: Do it yourself evening, DIYEvening) alle benodigde componenten en logica gemaakt volgens de MVC structuur die er al staat.
Dat is hier te vinden: [diy startup](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/31)

Vervolgens heb ik mijn userstory uitgewerkt in die frontend en backend. Ik moest bij die [userstory](https://github.com/orgs/hanaim-devops/projects/31/views/1?pane=issue&itemId=83412406&issue=hanaim-devops%7Cdevops-bp-pitstop-uitbreiding-team-knoppert%7C1)
het mogelijk maken dat via de frontend een reparateur een doe het zelf avond kan maken. Voor de frontend moest ik een pagina maken, modellen, controllers en view.

Ik heb helaas geen automatische testen geschreven. Ik heb wel handmatige E2E testen geschreven. De ADR, waarom we geen testen hebben geschreven, behandel ik in het kopje van documentatie. 

Ik heb een pipeline gemaakt waarbij de applicatie wordt gebuild en getest en gedeployed naar Rancher. De pipeline is hier te vinden: [pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/39/files#diff-a9fcf81f55b16d4db9d62258b46a56b196b1e20741c9f5fc61728a3578064b98)

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

## 4. Onderzoek !! klaar

Ik heb voor de blog onderzoek gedaan naar Thanos. Thanos is een extensie op Prometheus. De blog zelf is hier te vinden: [Thanos blog](https://github.com/hanaim-devops/devops-blog-pietknoppert/blob/main/src/dev-blog-thanos-metrics-endgame/README.md)

Ik heb dit heb dit succesvol geimplementeerd in de Pitstop applicatie. 
Ik heb de benodigde services en deployments gemaakt en de configuratie van Prometheus aangepast. 
Vervolgens heb ik onderzocht hoe ik MinIO kon gebruiken om de data van Thanos op te slaan. Normaal gezien raad Thanos namelijk aan om dit online te doen zoals bij Azure of AWS.
Ik onderzoek gedaan naar hoe ik dit lokaal kan doen en dit gedaan d.m.v. [MinIO](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/files#diff-e19124e993b85be0fd8ec64927a1ab3029c154d6b466359600cae42ccffe1f2e). 
Ik heb ervoor gezorgd dat Thanos connectie heeft met een MinIO instance en dat de data wordt opgeslagen in een Bucket. 


Daarnaast heb ik een nieuwe configuratie toegevoegd in de k8s omgeving waardoor er automatisch een bucket wordt aangemaakt voor onze omgeving: 
[bucket generatie](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/commits/3ec8cb940ff1db2543882b2028076b8d01b3aa73)

Het resultaat is hier te vinden: [thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/files)
Ik heb sinds de blog geleerd hoe ik zo'n automatische bucket generatie kan maken.

## 5. Bijdrage code review/kwaliteit anderen en security !! klaar

Tijdens dit project heb ik wel meer dan 15 MR requests nagekeken. Omdat ik die niet allemaal kan benomen ligt er ik enkele uit. Ik heb de kwaliteit van de code beoordeeld en feedback gegeven. Ik heb ook gekeken of de code voldoet aan de standaarden en of de code veilig is.

Dit is de eerste merge request die ik heb nagekeken: [eerste merge request](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/22). Bij deze heb ik naar de structuur van het project gekeken, aanzien dit een setup is waar wij ook in zouden werken.
De tweede review die ik heb uitgevoerd is op de functionaliteit van het annuleren van een doe het zelf avond: [annuleren doe het zelf avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/44#pullrequestreview-2378189436). Ik ben begonnen met het doornemen van de wijzigingen. Ik heb feedback gegeven op enkele punten zoals commentaar dat weg moet, mogelijke verbetering in de UI en enkele kleine code kwaliteit verbeteringen in de API.
Vervolgens heb ik de [MR van Prometheus metrics](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/53/files) nagekeken. Dit is een belangrijke voormij aangezien ik met Thanos de functionaliteiten van Prometheus ga uitbreiden. 
De laatste MR die ik toon is de functionaliteit van het annuleren van een doe het zelf avond: [annuleren doe het zelf avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/44)

Naast MR ben ik ook kort bezig geweest met security. Ik heb voor de pipeline om naar Rancher te deployen de belangrijkste gegevens zoals logins en wachtwoorden in secrets gezet. Dit is hier te vinden: [pipeline GitHub secret](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9c619281355ddd9126bf0755fd2ee004a5b7bcd1/.github/workflows/pipeline.yaml#L54)
Daarnaast heb ik ook de [Rancher login yaml als base64 geencodeerd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9c619281355ddd9126bf0755fd2ee004a5b7bcd1/.github/workflows/pipeline.yaml#L75)

## 6. Bijdrage documentatie !! klaar

Zoals eerder aangehaald heb ik een handmatige E2E test geschreven. De [test gaat over het aanmaken van een avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/81/files?short_path=4b74009#diff-4b74009979ef413f625da303968da579b9e10e743d22d9f14196b8050406b4e9)

Ik heb ook een kleine readme gemaakt voor een aantal weburls die we gebruiken voor Prometheus en Thanos.
Ik heb hierin beschreven waar die te vinden zijn voor de Docker omgeving en voor k8s. 
Ook heb ik een aantal belangrijke query commando's beschreven die de persoon kan uitvoeren om custom metrics op te halen. 
De readme kan hier gevonden worden: [read me](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/src/README.md)

Ik heb twee ADR's geschreven. De eerste ADR gaat over de [implementatie van Thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/docs/adr/adr-005-gebruik-van-thanos-voor-metrics.md).
De tweede ADR gaat over het [niet schrijven van automatische testen](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/docs/adr/adr-006-geen-code-tests-geschreven.md).

Daarnaast heb ik natuurlijk ook aan de userstory documentatie gewerkt. Ik heb hier een bijdrage aan geleverd door tijdens de gezamelijke groepsbespreking de userstorys te bespreken en te verduidelijken. 

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills !! klaar

Ik heb in de eerste sprint op dinsdag een daily stand-up geleid. 
Ik ben begonnen met het vragen van de progressie, results en problemen van de vorige dag aan de eerste teamgenoot. 
Ik heb dit aan alle teamgenoten gevraagd en bewaakt dat iedereen aan het woord kwam. 
Vervolgens heb ik de planning van de dag besproken en de teamgenoten gevraagd wat ze gingen doen. 
Ik heb de stand-up afgesloten met een vraag of er nog problemen waren en of iemand hulp nodig had.

Vervolgens heb ik onze [sprint planning 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/notulen/sprint-planning-2.md) genotuleerd. Ik heb daarna de retrospective geleid. De notulen van die retrospective is hier te vinden: [retro](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/notulen/retrospective.md) 

## 8. Leerervaringen



## 9. Conclusie & feedback



!! taal nog controleren!