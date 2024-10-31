# Eigen bijdrage Jelle

Je schrapt verder deze tekst en vervangt alle andere template zaken, zodat alleen de kopjes over blijven. **NB: Aanwezigheid van template teksten na inleveren ziet de beoordelaar als een teken dat je documentatie nog niet af is, en hij/zij deze dus niet kan of hoeft te beoordelen**.

Je begin hier onder het hoofdkopje met een samenvatting van je bijdrage zoals je die hieronder uitwerkt. Best aan het einde schrijven. Zorg voor een soft landing van de beoordelaar, maar dat deze ook direct een beeld krijgt. Je hoeft geen heel verslag te schrijven. De kopjes kunnen dan wat korter met wat bullet lijst met links voor 2 tot 4 zaken en 1 of 2 inleidende zinnen erboven. Een iets uitgebreidere eind conclusie schrijf je onder het laatste kopje.

## 1. Code/platform bijdrage

Competenties: *DevOps-1 Continuous Delivery*

- [Code: inzien aangemelde klanten](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/35): Code geschreven om te zorgen dat aangemelde klanten voor een doe het zelf avond ingezien kunnen worden op de detailpagina.
- [Code: aanmelden DIY avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/34): Code geschreven om klanten aan te kunnen melden voor een doe het zelf avond. Bovenstaande code was hier best wel van afhankelijk, dus heb ik ook deze story opgepakt.

## 2. Bijdrage app configuratie/containers/kubernetes

Competenties: *DevOps-2 Orchestration, Containerization*

Beschrijf en geef hier links naar je minimaal 2 en maximaal 4 grootste bijdragen qua configuratie, of bijdrage qua 12factor app of container Dockerfiles en/of .yml bestanden of vergelijkbare config (rondom containerization en orchestration).

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Competenties: *DevOps-1 - Continuous Delivery*, *DevOps-3 GitOps*, *DevOps-5 - SlackOps*

Beschrijf hier en geef links naar je bijdragen aan het opzetten en verder automatiseren van delivery pipeline, GitOps toepassing en/of het opzetten van monitoring, toevoegen van metrics en custom metrics en rapportages.

NB Het gebruik van *versiebeheer* ((e.g. git)) hoort bij je standaardtaken en deze hoef je onder dit punt NIET te beschrijven, het gaat hier vooral om documenteren van processtandaarden, zoals toepassen van een pull model.

## 4. Onderzoek

Competenties: *Nieuwsgierige houding*

- [Blog over ChaosKube](https://github.com/hanaim-devops/devops-blog-JelleSchrans)
- [Config ChaosKube](../../src/k8s/chaoskube/chaoskube.yaml)

**Conclusie**: Nadat Kubernetes in eerste instantie niet helemaal leek te werken, is het in de tweede week wel gelukt om ChaosKube te implementeren. Dit bleek uiteindelijk niet heel moeilijk te zijn, dus is er niet onnodig veel tijd aan verloren gegaan.

## 5. Bijdrage code review/kwaliteit anderen en security

Competenties: *DevOps-7 - Attitude*, *DevOps-4 DevSecOps*

### Reviews

- [Review opzet pipeline](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/21)
- [Review feedback geven DIY avond](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/46)

### Security

[Dependabot: Bump set-value and union-value](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/27/files)

Onderstaande PR is aangemaakt door dependabot, waar wat packages worden geupdate en er ook 1 wordt verwijderd. Dependabot had namelijk 2 security vulnerabilities gevonden in de packages (1 high, 1 critical). Dit waren onderstaande vulnerabilities:

- [High severity vulnerability](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/security/dependabot/21)
- [Critical severity vulnerability](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/security/dependabot/14)

Bij beide vulnerabilities wordt gesproken van 'Prototype Pollution'. Hierbij wordt er een prototype object aangepast, wat kan leiden tot ongewenst gedrag. Dit kan bijvoorbeeld leiden tot het uitvoeren van ongewenste code.

## 6. Bijdrage documentatie

Competenties: *DevOps-6 Onderzoek*

[ADR ChaosKube](../../docs/adr/adr-002-chaoskube-voor-chaos-engineering.md)

ADR gemaakt voor het gebruik van ChaosKube voor Chaos Engineering. Hierin wordt beschreven wat ChaosKube is, waarom we het willen gebruiken en hoe we het willen gebruiken. Toegelicht dat het in de eerste week niet werkte, later gelukkig wel.

[Testplan registreren klant voor DIY avond](../../docs/testplan)

(zie kopje 'Registren klant voor doe het zelf avond') Testplan gemaakt voor het registreren van klanten voor een doe het zelf avond. Naast de happy flow 2 edge cases gevonden die getest konden worden.

## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Competenties: *DevOps-1 - Continuous Delivery*, *Agile*

Beschrijf hier minimaal 2 en maximaal 4 situaties van je inbreng en rol tijdens Scrum ceremonies. Beschrijf ook feedback of interventies tijdens Scrum meetings, zoals sprint planning of retrospective die je aan groespgenoten hebt gegeven.

Beschrijf tijdens het project onder dit kopje ook evt. verdere activiteiten rondom communicatie met de opdrachtgever of domein experts, of andere meer 'professional skills' of 'soft skilss' achtige zaken.
  
## 8. Leerervaringen

Competenties: *DevOps-7 - Attitude*

**Tops**:

- Vragen stellen aan groepsgenoten
- (top2)

**Tips**:

- (tip1)
- (tip2)

Geef tot slot hier voor jezelf minimaal 2 en maximaal **4 tops** en 2 dito (2 tot 4) **tips** á la professional skills die je kunt meenemen in je verdere loopbaan. Beschrijf ook de voor jezelf er het meest uitspringende hulp of feedback van groepsgenoten die je (tot dusver) hebt gehad tijdens het project.

## 9. Conclusie & feedback

Competenties: *DevOps-7 - Attitude*

Conclusie: (nog uitwerken)

Feedback: Ik vind het altijd leuk om in teamverband aan een project te kunnen werken en dat beviel nu ook weer goed. De opdracht is leuk alleen is de periode waarin we het project uit moeten voeren nogal kort. Je wil uiteindelijk toch wat meer kunnen doen dan dat binnen de 2 weken mogelijk is. De opgedane kennis over infrastructuur binnen je software omgeving is iets wat ik meeneem voor de toekomst.
