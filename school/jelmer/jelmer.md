# Eigen bijdrage Jelmer Noppert

Ik heb de frontend-structuur opgezet voor de 'Doe het Zelf Avond' en een pipeline ontwikkeld die de applicatie bouwt, test en deployt naar Rancher. Thanos heb ik geïmplementeerd voor geavanceerde monitoring met MinIO voor dataopslag. Daarnaast heb ik actief code reviews uitgevoerd op merge requests en documentatie geschreven, waaronder handmatige E2E-tests en twee ADR's. Binnen het team heb ik stand-ups geleid, notulen gemaakt en bijgedragen aan effectieve communicatie.

## 1. Code/platform bijdrage

Ik ben gestart met het opzetten van onze benodigde structuur in de frontend (webApp). Ik heb voor de 'Doe het Zelf Avond' (ook wel in het Engels: 'Do It Yourself Evening', DIYEvening) alle benodigde componenten en logica gemaakt volgens de MVC-structuur die er al staat. Dat is hier te vinden: [diy startup](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/31)

Vervolgens heb ik mijn user story uitgewerkt in die frontend en backend. Ik moest bij die [user story](https://github.com/orgs/hanaim-devops/projects/31/views/1?pane=issue&itemId=83412406&issue=hanaim-devops%7Cdevops-bp-pitstop-uitbreiding-team-knoppert%7C1) het mogelijk maken dat via de frontend een reparateur een 'Doe het Zelf Avond' kan aanmaken. Voor de frontend moest ik een pagina maken, modellen, controllers en views.

Ik heb helaas geen automatische tests geschreven. Ik heb wel handmatige E2E-tests geschreven. De ADR waarin we uitleggen waarom we geen tests hebben geschreven, behandel ik in het kopje van documentatie.

Ik heb een pipeline gemaakt waarbij de applicatie wordt gebouwd, getest en gedeployed naar Rancher. De pipeline is hier te vinden: [pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/39/files#diff-a9fcf81f55b16d4db9d62258b46a56b196b1e20741c9f5fc61728a3578064b98)

## 2. Bijdrage app configuratie/containers/kubernetes

Ik heb kort een teamgenoot geholpen met een probleem. Het probleem was dat de backend-service container steeds werd afgesloten. Ik heb dit opgelost: [commit](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/33/commits/d962971291ac93bd42b2b8009c093b8aec6af549)

Daarnaast heb ik ook de app settings aangepast zodat dit met de nieuwe backend-service werkt: [appsettings.Production.json](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/31/files#diff-324e1a9f613e28efa076b2f5094ff8cd2dab1e38f03301bf6d975588764b8b8c)

Ik heb met containers, configuratie en Kubernetes gewerkt toen ik Thanos ging implementeren. Ik heb dit eerst via [Docker Compose](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/commits/bd9d0f5e6945803710915ade2db287d2fe7cd04c) gemaakt. Vervolgens heb ik dit ook in Kubernetes verwerkt. Ik heb een map voor de monitoring gemaakt en daar de benodigde namespaces, services en deployments in gezet. Ik heb de verschillende componenten van Thanos uitgewerkt, gezorgd dat deze worden opgeslagen in MinIO en enkele bestaande Prometheus-configuraties aangepast. Alle wijzigingen die ik heb toegevoegd zijn hier te vinden: [thanos k8s](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61)

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Bij deze competentie heb ik aan twee grote dingen gewerkt. Ik heb als eerste monitoring toegevoegd in de vorm van Thanos. Thanos is een uitbreiding van Prometheus. Ik heb dit gedaan door een nieuwe namespace aan te maken, de benodigde services en deployments te maken en de configuratie van Prometheus aan te passen. Ik heb dit gedaan in de Kubernetes-configuratie. Al mijn Thanos-toevoegingen kunnen hier gevonden worden: [thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61)

Vervolgens heb ik ook gewerkt aan de CI/CD-pipeline. Ik heb een nieuwe workflow gemaakt waarbij de hele applicatie wordt gebouwd, getest, gepublished en gedeployed. Ik heb dat gedaan door een nieuwe workflow aan te maken in de .github/workflows map. Deze workflow bouwt eerst de applicatie (de Pitstop applicatie, ook wel de solution) en test deze. Vervolgens worden de images gebouwd en gepublished naar de publieke Docker Registry. Als laatste wordt via Minikube de applicatie gedeployed op onze Rancher-cluster. De hele workflow en benodigde wijzigingen zijn hier te vinden: [CI/CD pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/39/files)

## 4. Onderzoek

Ik heb voor de blog onderzoek gedaan naar Thanos. Thanos is een extensie op Prometheus. De blog zelf is hier te vinden: [Thanos blog](https://github.com/hanaim-devops/devops-blog-pietknoppert/blob/main/src/dev-blog-thanos-metrics-endgame/README.md)

Ik heb dit succesvol geïmplementeerd in de Pitstop applicatie. Ik heb de benodigde services en deployments gemaakt en de configuratie van Prometheus aangepast. Vervolgens heb ik onderzocht hoe ik MinIO kon gebruiken om de data van Thanos op te slaan. Normaal gezien raadt Thanos namelijk aan om dit online te doen zoals bij Azure of AWS. Ik heb onderzoek gedaan naar hoe ik dit lokaal kan doen en dit gedaan d.m.v. [MinIO](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/files#diff-e19124e993b85be0fd8ec64927a1ab3029c154d6b466359600cae42ccffe1f2e). Ik heb ervoor gezorgd dat Thanos connectie heeft met een MinIO-instance en dat de data wordt opgeslagen in een bucket.

Daarnaast heb ik een nieuwe configuratie toegevoegd in de k8s-omgeving waardoor er automatisch een bucket wordt aangemaakt voor onze omgeving: [bucket generatie](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/commits/3ec8cb940ff1db2543882b2028076b8d01b3aa73)

Het resultaat is hier te vinden: [thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/61/files). 

Ik heb sinds de blog geleerd hoe ik zo'n automatische bucketgeneratie kan maken.

## 5. Bijdrage code review/kwaliteit anderen en security

Tijdens dit project heb ik verschillende merge requests nagekeken. Omdat ik die niet allemaal kan benoemen, licht ik er enkele uit. Ik heb de kwaliteit van de code beoordeeld en feedback gegeven. Ik heb ook gekeken of de code voldoet aan de standaarden en of de code veilig is.

Dit is de eerste merge request die ik heb nagekeken: [eerste merge request](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/22). Bij deze heb ik naar de structuur van het project gekeken, aangezien dit een setup is waar wij ook in zouden werken.

De tweede review die ik heb uitgevoerd is op de functionaliteit van het annuleren van een Doe het Zelf Avond: [annuleren Doe het Zelf Avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/44#pullrequestreview-2378189436). Ik ben begonnen met het doornemen van de wijzigingen. Ik heb feedback gegeven op enkele punten zoals commentaar dat weg moet, mogelijke verbetering in de UI en enkele kleine codekwaliteit-verbeteringen in de API.

Vervolgens heb ik de [MR van Prometheus metrics](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/53/files) nagekeken. Dit is belangrijk voor mij aangezien ik met Thanos de functionaliteiten van Prometheus ga uitbreiden.

Naast MR's ben ik ook kort bezig geweest met security. Ik heb voor de pipeline om naar Rancher te deployen de belangrijkste gegevens zoals logins en wachtwoorden in secrets gezet. Dit is hier te vinden: [pipeline GitHub secret](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9c619281355ddd9126bf0755fd2ee004a5b7bcd1/.github/workflows/pipeline.yaml#L54) Daarnaast heb ik ook de [Rancher login YAML als base64 geëncodeerd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9c619281355ddd9126bf0755fd2ee004a5b7bcd1/.github/workflows/pipeline.yaml#L75)

## 6. Bijdrage documentatie

Zoals eerder aangehaald heb ik een handmatige E2E-test geschreven. De [test gaat over het aanmaken van een avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/81/files?short_path=4b74009#diff-4b74009979ef413f625da303968da579b9e10e743d22d9f14196b8050406b4e9)

Ik heb ook een kleine README gemaakt voor een aantal web-URL's die we gebruiken voor Prometheus en Thanos. Ik heb hierin beschreven waar die te vinden zijn voor de Docker-omgeving en voor k8s. Ook heb ik een aantal belangrijke querycommando's beschreven die de persoon kan uitvoeren om custom metrics op te halen. De README kan hier gevonden worden: [README](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/src/README.md)

Ik heb twee ADR's geschreven. De eerste ADR gaat over de [implementatie van Thanos](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/docs/adr/adr-005-gebruik-van-thanos-voor-metrics.md). De tweede ADR gaat over het [niet schrijven van automatische testen](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/docs/adr/adr-006-geen-code-tests-geschreven.md).

Daarnaast heb ik natuurlijk ook aan de user story documentatie gewerkt. Ik heb hier een bijdrage aan geleverd door tijdens de gezamenlijke groepsbespreking de user stories te bespreken en te verduidelijken.

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Ik heb in de eerste sprint op dinsdag een daily stand-up geleid. Ik ben begonnen met het vragen van de progressie, resultaten en problemen van de vorige dag aan de eerste teamgenoot. Ik heb dit aan alle teamgenoten gevraagd en bewaakt dat iedereen aan het woord kwam. Vervolgens heb ik de planning van de dag besproken en de teamgenoten gevraagd wat ze gingen doen. Ik heb de stand-up afgesloten met een vraag of er nog problemen waren en of iemand hulp nodig had.

Vervolgens heb ik onze [sprint planning 2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/notulen/sprint-planning-2.md) genotuleerd. Ik heb daarna de retrospective geleid. Tijdens de retro heb ik ideeën proberen te geven en gezorgd dat alle teamgenoten hun eigen stukje konden zeggen. De notulen van die retrospective zijn hier te vinden: [retro](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/notulen/retrospective.md)

## 8. Leerervaringen

### Tips

- Soms minder direct zijn in de communicatie. Mijn directheid kan soms overkomen als onvriendelijk.
- Beter houden aan de afgesproken werktijden. Ik maak graag dingen af en werk vaak langer door dan afgesproken. Niet dat dit direct negatieve gevolgen heeft, maar het is wel belangrijk om een goede balans te houden.
- Sneller accepteren wanneer iets niet lukt; bijvoorbeeld minder tijd besteden aan het oplossen van Rancher-issues. Dit heeft lang geduurd maar is wel gelukt. Alleen was het mogelijk niet de meest efficiënte manier.

### Tops

- Hard gewerkt en altijd inzet getoond.
- Actieve communicatie binnen de groep en duidelijke bijdragen geleverd.
- Initiatief genomen, zoals het opzetten van de frontend-structuur voor het DIY-systeem en het ondersteunen van groepsleden.
- Oog voor detail bij het reviewen van merge requests; regelmatig issues opgemerkt die anderen hadden gemist.

Terwijl ik bezig was met Rancher gaf Jorian mij de tip om mijn bestede tijd bij te houden zodat ik niet te lang aan een probleem blijf hangen. Dit was een goede tip en heeft mij geholpen om sneller te accepteren wanneer iets niet lukt.

## 9. Conclusie & feedback

Dit project heeft me veel DevOps-ervaring gebracht, zoals de ontwikkeling van DIY-avonden, Thanos-monitoring en een verbeterde CI/CD-pipeline. Ik ben trots op mijn inzet en actieve betrokkenheid, maar zie verbeterpunten, zoals efficiënter omgaan met uitdagingen en beter bewaken van mijn werktijden.

**Feedback voor docenten:** Duidelijke richtlijnen voor automatisering en meer ondersteuning bij complexe tools zoals Rancher zouden het proces stroomlijnen, aangezien veel groepen problemen met Rancher hadden.

Voor de volgende opdrachten neem ik mee: kennis van monitoring, Kubernetes en CI/CD, evenals kleine verbeteringen van soft skills en communicatievaardigheden.