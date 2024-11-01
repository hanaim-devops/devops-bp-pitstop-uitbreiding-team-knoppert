# Eigen bijdrage Jelle

Tijdens dit project heb ik mij bij het implementeren van features bezig gehouden met het aanmelden van klanten voor een doe het zelf avond en het inzien van aangemelde klanten. Daarnaast heb ik ook de technologie uit mijn blog (ChaosKube) geïmplementeerd. Verder heb ik ook een ADR gemaakt voor het gebruik van ChaosKube. Mijn grootste bijdrage qua code was het aanmelden van klanten voor een doe het zelf avond. Hierbij heb ik ook een testplan gemaakt. Ik heb ook een aantal reviews gedaan en feedback gegeven op de opzet van de pipeline, het geven van feedback op de DIY avond en de historie van de aanmelding van de DIY avond. Daarnaast heb ik ook een PR van dependabot gereviewed om bezig te zijn geweest met een stukje security. Naast het testplan en het ADR ben ik voor documentatie ook bezig geweest met het uitwerken van een C4 component diagram voor de functionaliteit die wij hebben toegevoegd aan Pitstop.

## 1. Code/platform bijdrage

- [Code: inzien aangemelde klanten](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/35): Code geschreven om te zorgen dat aangemelde klanten voor een doe het zelf avond ingezien kunnen worden op de detailpagina.
- [Code: aanmelden DIY avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/34): Code geschreven om klanten aan te kunnen melden voor een doe het zelf avond. Bovenstaande code voor het inzien van aangemelde klanten was hier best wel van afhankelijk, dus heb ik ook deze story opgepakt.

## 2. Bijdrage app configuratie/containers/kubernetes

Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration).

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model.

## 4. Onderzoek

- [Blog over ChaosKube](https://github.com/hanaim-devops/devops-blog-JelleSchrans)
- [Config ChaosKube](../../src/k8s/chaoskube/chaoskube.yaml)

**Conclusie**: Nadat Kubernetes in eerste instantie niet helemaal leek te werken, is het in de tweede week wel gelukt om ChaosKube te implementeren. Dit bleek uiteindelijk niet heel moeilijk te zijn, dus is er niet onnodig veel tijd aan verloren gegaan.

## 5. Bijdrage code review/kwaliteit anderen en security

### Reviews

- [Review opzet pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/21)
- [Review feedback geven DIY avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/46)
- [Review historie aanmelding DIY avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/76)

### Security

[Dependabot: Bump set-value and union-value](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/27/files)

Onderstaande PR is aangemaakt door dependabot, waar wat packages worden geupdate en er ook 1 wordt verwijderd. Dependabot had namelijk 2 security vulnerabilities gevonden in de packages (1 high, 1 critical). Dit waren onderstaande vulnerabilities:

- [High severity vulnerability](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/security/dependabot/21)
- [Critical severity vulnerability](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/security/dependabot/14)

Bij beide vulnerabilities wordt gesproken van 'Prototype Pollution'. Hierbij wordt er een prototype object aangepast, wat kan leiden tot ongewenst gedrag. Dit kan bijvoorbeeld leiden tot het uitvoeren van ongewenste code.

## 6. Bijdrage documentatie

[ADR ChaosKube](../../docs/adr/adr-002-chaoskube-voor-chaos-engineering.md)

ADR gemaakt voor het gebruik van ChaosKube voor Chaos Engineering. Hierin wordt beschreven wat ChaosKube is, waarom we het willen gebruiken en hoe we het willen gebruiken. Toegelicht dat het in de eerste week niet werkte, later gelukkig wel.

[Testplan registreren klant voor DIY avond](../../docs/testplan)

(zie kopje 'Registren klant voor doe het zelf avond') Testplan gemaakt voor het registreren van klanten voor een doe het zelf avond. Naast de happy flow 2 edge cases gevonden die getest konden worden.

[C4 Component diagram](../../c4/plaatjes/c4-pitstop-component-diagram.png)

Component diagram gemaakt voor de functionaliteit die wij hebben toegevoegd aan Pitstop. Hierin wordt weergegeven hoe de gemaakte componenten met elkaar communiceren.

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

- Notulist geweest bij de Tech Review in de tweede week (Vrijdag 1 november).
- Tijdens retrospective benoemd dat we tijdens de sprint planningen als team duidelijk hebben welk werk we op willen gaan pakken.
  
## 8. Leerervaringen

**Tops**:

- Vragen stellen aan teamgenoten als iets niet duidelijk is
- Werk wat ik heb opgepakt altijd netjes afgemaakt

**Tips**:

- Communiceren over werk wat ik doe, zodat er geen dubbel werk wordt gedaan
- Actiever aanwezig zijn als er beslissingen worden genomen

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

**Conclusie**:

**Feedback**: Ik vind het altijd leuk om in teamverband aan een project te kunnen werken en dat beviel nu ook weer goed. De opdracht is leuk alleen is de periode waarin we het project uit moeten voeren nogal kort. Je wil uiteindelijk toch wat meer kunnen doen dan dat binnen de 2 weken mogelijk is. De opgedane kennis over infrastructuur binnen je software omgeving is iets wat ik meeneem voor de toekomst.
