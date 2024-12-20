# CDMM Zelfreflectie

## Cultuur & Organisatie: 8

### Basis

- [x] CO-001 Werk geprioriteerd: We hebben werk geprioriteerd tijdens de userstory mapping in [Miro](https://miro.com/app/board/uXjVLTQ53kg=/).
- [ ] CO-002 Gedef'd en -doc't proces
- [x] CO-003 Frequente commits: We hebben frequent gecommit zie hierbij de [geclosede PR's](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pulls?q=is%3Apr+is%3Aclosed).

### Beginner

- [x] CO-101 Eén backlog per team: We hebben één backlog per team.
- [x] CO-102 Delen van pijn: We hebben samen aan taken gewerkt en elkaar geholpen.
- [x] CO-103 Stabiel team per project: We hebben met ze allen aan hetzelfde project gewerkt.
- [x] CO-104 Basis Agile methode: We hebben gebruik gemaakt van de Agile methode, dit hebben we gedaan M.B.V. daily standups en sprintplanningen, -reviews, -retrospectives.
- [ ] CO-105 Testen onderdeel development

### Gemiddeld

- [x] CO-201 Multidiscpl. team (betrekken DBA, CM): We hebben een team wat van meerdere software achtergronden komt, we hebben een aantal webdevelopers, een aantal software developers.
- [x] CO-202 Component eigenaarschap: We hebben allemaal gewerkt aan een eigen component. Hier ook de testen voor geschreven en bugs opgelost.
- [ ] CO-203 Handelen op metrics
- [x] CO-204 Ops & Dev samen: We hebben met ze allen gewerkt aan zowel de development als de operations.
- [x] CO-205 Vast proces voor wijzigingen (DB/CM/Docs/Code/Artefacts): We hebben een vast proces voor wijzigingen, dit hebben we gedaan door gebruik te maken van Git en GitHub, waarbij we gebruik hebben gemaakt van branches en pull requests. Ook hebben we gebruik gemaakt van de GitHub Actions om de code te testen en te deployen.
- [x] CO-206 Decentrale besluitvorming: Degene die verstand heeft van een bepaald onderwerp heeft de taken van dat onderwerp op zich genomen, en de keuzes daarin gemaakt.

### Gevorderd

- [ ] CO-301 Dedicated tools team
- [x] CO-302 Team verantwoordelijk tot productie: We hebben gezorgd dat het product productie klaar is, vervolgens hebben we het online gezet.
- [ ] CO-303 Deploy losgekoppeld van release
- [x] CO-345 Continuous improvement (Kaizen): We hebben d.m.v. sprints gewerkt en daardoor continue verbeteringen doorgevoerd.

### Expert

- [ ] CO-401 Cross functional team (=CO-201++)
- [x] CO-402 No rollbacks (always roll forward): We hebben updates gedaan en als er een fout was hebben we deze gefixt en een nieuwe update gedaan.

## Ontwerp & Architectuur: 6

### Basis

- [x] OA-001 Geconsolideerd platform & en technologie: Wij hebben gewerkt met kubernetes.

### Beginner

- [x] OA-101 Systeem opsplitsen in modules: Wij hebben een module toegevoegd genaamd DIY Management.
- [x] OA-102 API-gestuurde aanpak: Wij zijn steeds begonnen met het ontwikkelen van de API.
- [ ] OA-103 (3rd party) Library management

### Gemiddeld

- [x] OA-201 Geen of minimale branching: Wij hebben kleine taken en minimale branching gedaan.
- [ ] OA-202 Branch by abstraction
- [x] OA-203 Configuratie als Code (CaC; Config -> Cac): Wij hebben geconfigureerd met .yaml files.
- [ ] OA-204 Feature toggle
- [ ] OA-205 Modules omzetten naar componenten
- [x] OA-206 Trunk based development: Wij hebben allemaal gewerkt met soms kleine branching vanuit main.

### Gevorderd

- [ ] OA-301 Volledige component gebaseerde architectuur
- [x] OA-302 Graph business metrics uit applicatie: Wij gebruiken Prometheus om business metrics uit de applicatie te verzamelen en te visualiseren. In Prometheus kunnen de standaard metrics zoals CPU en RAM worden uitgelezen, maar ook custom metrics kunnen worden toegevoegd. Dit hebben we gedaan door in onze [controle custom metrics](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/3cd851dbfb83911d38ae485e087644c4dd9f8024/src/DIYManagementAPI/Controllers/DIYController.cs#L14) te maken.  

### Expert

- [ ] OA-401 Infrastructure as Code (IaC)

## Build & Deploy: 6

### Basis

- [x] BD-001 Code in versiebeheer: We hebben ons project in een git repository met historie en branches.
- [x] BD-002 Gescripte builds: We hebben een script om de applicatie te bouwen. Deze wordt ook gebruikt in de CI/CD pipeline ([Build en deploy](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/main/.github/workflows/pipeline.yaml)).
- [x] BD-003 Basis scheduled builds (CI): We hebben een CI pipeline die automatisch wordt uitgevoerd bij elke push naar de main branch.
- [ ] BD-004 Dedicated build server
- [ ] BD-005 Gedocumenteerde handmatige deploy
- [x] BD-006 Enkele deployment scripts bestaan: We hebben een script om de applicatie te deployen naar onze Rancher omgeving.

### Beginner

- [ ] BD-101 Polling builds
- [ ] BD-102 Opslag van build (milestone)
- [ ] BD-103 Handmatige tags en versies
- [x] BD-104 1e stap naar standaardisatie deploys: We hebben een script om de applicatie te deployen naar onze Rancher omgeving.
- [x] BD-105 DB wijzigingen in VCS: Via [Entity Framework Core migrations](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/tree/main/src/DIYManagementAPI/Migrations) worden de DB wijzigingen in de code opgeslagen.

### Gemiddeld

- [x] BD-201 Auto triggered builds (commit hooks): We hebben een CI pipeline die automatisch wordt uitgevoerd bij elke push naar de main branch. Daarnaast worden ook de solution gecompileerd en de tests uitgevoerd.
- [ ] BD-202 Geautomatiseerde tags & versies
- [ ] BD-203 Build once deploy anywhere: Helaas niet volledig gelukt. Het deel van 'build once' hebben we. Maar deploy anywhere is niet omdat we het naar een enkele Rancher omgeving deployen en niet naar meerdere omgevingen.
- [x] BD-204 Automatiseer meeste DB wijzigingen: Doordat we bij iedere applicatie start de [database migration opnieuw uitvoeren](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/3cd851dbfb83911d38ae485e087644c4dd9f8024/src/DIYManagementAPI/Program.cs#L46), worden de meeste wijzigingen automatisch doorgevoerd.
- [x] BD-205 Basis pipeline, prod deploy: We hebben een pipeline die de applicatie bouwt en deployt naar onze Rancher omgeving.
- [ ] BD-206 Gescripte config wijzigingen
- [ ] BD-207 Standaard proces voor alle omgevingen

### Gevorderd

- [ ] BD-301 Zero downtime deploys
- [ ] BD-302 Meerdere build machines
- [x] BD-303 Volledig automatische DB deploys: Onze CI/CD pipeline start automatisch de applicatie, waarbij de database-migraties worden uitgevoerd zonder handmatige tussenkomst. Dit garandeert dat alle schema-updates en databasewijzigingen consistent worden doorgevoerd bij elke deployment.

### Expert

- [ ] BD-401 Build bakery
- [ ] BD-402 Zero touch continuous deployment

## Test & Verificatie: 4

### Basis

- [ ] TV-001 Automatische unit tests
- [ ] TV-002 Aparte test omgeving

### Beginner

- [ ] TV-101 Automatische integratietests

### Gemiddeld

- [ ] TV-201 Automatische component test (geisoleerd)
- [ ] TV-202 Enkele automatische acceptatie tests

### Gevorderd

- [ ] TV-301 Volledige automatische acceptatie tests
- [ ] TV-302 Automatische performance tests
- [ ] TV-303 Automatische security tests
- [x] TV-304 Risico gebaseerde handmatige tests: We hebben een [testplan](../docs/testplan.md) uitgewerkt, waarin we tests uitwerken die alleen handmatig uitgevoerd kunnen worden. Dit ivm het feit dat we geen tijd hadden om geautomatiseerde tests te maken.

### Expert

- [x] TV-401 Verifieer verwachte bedrijfswaarde: We verifiëren de verwachte bedrijfswaarde door de geimplementeerde functionaliteit handmatig te testen, om aan te kunnen tonen dat alles naar wens is geimplementeerd. We hebben per functionaliteit de happy flow uitgewerkt, en ook de edge cases om aan te tonen dat als er afgeweken wordt van de happy flow, de applicatie nog steeds werkt zoals verwacht.

## Informatie & Rapporteren: 6

### Basis

- [x] IR-001 Basis procesmetrics: We maken gebruik van Prometheus, deze verzamelt procesmetrics. We hebben hiervoor [custom metrics gedefinieerd](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/69/files).
- [ ] IR-002 Handmatige rapportages

### Beginner

- [x] IR-101 Meet het proces: Prometheus verzamelt gegevens zoals CPU gebruik.
- [ ] IR-102 Statische code analyse
- [ ] IR-103 Periodieke automatisch kwaliteitsrapportage

### Gemiddeld

- [ ] IR-201 Gedeeld informatie model
- [ ] IR-202 Traceerbaarheid ingebouwd in pipeline
- [ ] IR-203 Rapportage historie is beschikbaar

### Gevorderd

- [x] IR-301 Graphing-as-a-service: We voldoen hier lichtelijk aan door het gebruik van Prometheus. Prometheus verzamelt real-time data en maakt de data inzichtelijk in een grafiek waar je op kan filteren en inzoomen. Het biedt alleen geen optie om een andere soort grafiek te gebruiken wat typisch wel in een GaaS kan.
- [ ] IR-302 Dynamic test coverage analysis
- [ ] IR-303 Report trend analysis

### Expert

- [x] IR-401 Dynamische grafieken en dashboards: Prometheus biedt dynamische grafieken (zie afbeelding 1).
![Prometheus grafiek](./plaatjes/prometheus-grafiek.png)
Afbeelding 1
- [ ] IR-402 Cross silo analysis
