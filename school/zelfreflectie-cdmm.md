# CDMM Zelfreflectie

## Cultuur & Organisatie

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

- [x] CO-201 Multidiscpl. team (betrekken DBA, CM): We hebben een team wat van meerdere software afkomsten komt, we hebben een aantal webdevelopers, een aantal software developers.
- [x] CO-202 Component eigenaarschap: We hebben allemaal gewerkt aan een eigen component. Hier ook de testen voor geschreven en bugs opgelost.
- [ ] CO-203 Handelen op metrics
- [x] CO-204 Ops & Dev samen: We hebben met ze allen gewerkt aan zowel de development als de operations.
- [x] CO-205 Vast proces voor wijzigingen (DB/CM/Docs/Code/Artefacts): We hebben een vast proces voor wijzigingen, dit hebben we gedaan door gebruik te maken van Git en GitHub, waarbij we gebruik hebben gemaakt van branches en pull requests. Ook hebben we gebruik gemaakt van de GitHub Actions om de code te testen en te deployen.
- [x] CO-206 Decentrale besluitvorming: De gene die verstand heeft van een bepaald onderwerp heeft de taken van dat onderwerp op zich genomen, en de keuzes daarin gemaakt.

### Gevorderd

- [ ] CO-301 Dedicated tools team
- [x] CO-302 Team verantwoordelijk tot productie: We hebben gezorgt dat het product productie klaar is, vervolgens hebben we het online gezet.
- [ ] CO-303 Deploy losgekoppeld van release
- [x] CO-345 Continuous improvement (Kaizen): We hebben doormiddel van sprints gewerkt en daardoor continue verbeteringen doorgevoerd.

### Expert

- [ ] CO-401 Cross functional team (=CO-201++)
- [x] CO-402 No rollbacks (always roll forward): We hebben updates gedaan en als er een fout was hebben we deze gefixt en een nieuwe update gedaan.

## Ontwerp & Architectuur : Dirk

### Basis

- [x] OA-001 Geconsolideerd platform & en technologie

### Beginner

- [x] OA-101 Systeem opsplitsen in modules
- [x] OA-102 API-gestuurde aanpak
- [ ] OA-103 (3rd party) Library management

### Gemiddeld

- [x] OA-201 Geen of minimale branching
- [ ] OA-202 Branch by abstraction
- [x] OA-203 Configuratie als Code (CaC; Config -> Cac)
- [ ] OA-204 Feature toggle
- [ ] OA-205 Modules omzetten naar componenten
- [x] OA-206 Trunk based development

### Gevorderd

- [ ] OA-301 Volledige component gebaseerde architectuur
- [x] OA-302 Graph business metrics uit applicatie

### Expert

- [ ] OA-401 Infrastructure as Code (IaC)

## Build & Deploy : Jelmer

### Basis

- [x] BD-001 Code in versiebeheer
- [x] BD-002 Gescripte builds
- [x] BD-003 Basis scheduled builds (CI)
- [ ] BD-004 Dedicated build server
- [ ] BD-005 Gedocumenteerde handmatige deploy
- [x] BD-006 Enkele deployment scripts bestaan

### Beginner

- [ ] BD-101 Polling builds
- [ ] BD-102 Opslag van build (milestone)
- [ ] BD-103 Handmatige tags en versies
- [x] BD-104 1e stap naar standaardisatie deploys
- [x] BD-105 DB wijzigingen in VCS

### Gemiddeld

- [x] BD-201 Auto triggered builds (commit hooks)
- [ ] BD-202 Geautomatiseerde tags & versies
- [x] BD-203 Build once deploy anywhere
- [x] BD-204 Automatiseer meeste DB wijzigingen
- [x] BD-205 Basis pipeline, prod deploy
- [ ] BD-206 Gescripte config wijzigingen
- [ ] BD-207 Standaard proces voor alle omgevingen

### Gevorderd

- [ ] BD-301 Zero downtime deploys
- [ ] BD-302 Meerdere build machines
- [x] BD-303 Volledig automatische DB deploys

### Expert

- [ ] BD-401 Build bakery
- [ ] BD-402 Zero touch continuous deployment

## Test & Verificatie : Jelle

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
- [x] TV-304 Risico gebaseerde handmatige tests

### Expert

- [x] TV-401 Verifieer verwachte bedrijfswaarde

## Informatie & Rapporteren : Mitchel

### Basis

- [x] IR-001 Basis procesmetrics
- [ ] IR-002 Handmatige rapportages

### Beginner

- [x] IR-101 Meet het proces
- [ ] IR-102 Statische code analyse
- [ ] IR-103 Periodieke automatisch kwaliteitsrapportage

### Gemiddeld

- [ ] IR-201 Gedeeld informatie model
- [ ] IR-202 Traceerbaarheid ingebouwd in pipeline
- [ ] IR-203 Rapportage historie is beschikbaar

### Gevorderd

- [x] IR-301 Graphing-as-a-service
- [ ] IR-302 Dynamic test coverage analysis
- [ ] IR-303 Report trend analysis

### Expert

- [x] IR-401 Dynamische grafieken en dashboards
- [ ] IR-402 Cross silo analysis
