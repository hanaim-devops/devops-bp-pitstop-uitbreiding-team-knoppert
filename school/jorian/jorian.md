# Eigen bijdrage jorian

In dit project heb ik als Developer gewerkt aan verschillende functionaliteiten en configuraties, met name rond het annuleren en tonen van DIY-avonden en het opzetten van testplannen voor kwaliteitsbewaking. Daarnaast heb ik voor Keycloak configuraties ontwikkeld en geïmplementeerd, maar dit bleek door technische beperkingen niet werkend te krijgen. Voor de workflow in GitHub heb ik merge-regels en review-richtlijnen opgezet om een eenduidig proces te waarborgen.

Verder heb ik bijgedragen aan documentatie, zoals het C4-containerdiagram en een ADR over Keycloak. Binnen het team heb ik aan de acceptatiecriteria voor user stories gewerkt, notulen gemaakt, en enkele Daily Standups geleid.

## 1. Code/platform bijdrage

Ik heb in dit project de Dev rol op me genomen. Ik heb gewerkt aan de volgende onderdelen:

- Cancellen van Diy avond. [pull req1](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/44), [pull req2](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/68).
- [Details van de eerst volgende Diy avond in overzicht](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/80).
- [Start van het testplan en een aantal testen geschreven](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/58).
 
## 2. Bijdrage app configuratie/containers/kubernetes

Ik heb gewerkt aan de configuratie van keycloak, dit heb ik jammer genoeg niet kunnen toevoegen aan het project.

- Ik heb voor deze configuratie een script geschreven die een [realm configureert](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9-register-with-keycloak/src/k8s/scripts/create-realm.ps1).
- Ook heb ik voor keycloak de laaste versie van keycloak toegevoegd aan het [start script](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/blob/9-register-with-keycloak/src/k8s/scripts/start-all.ps1). Ik heb gekozen dat altijd de laatste versie van keycloak wordt gebruikt, omdat dit de meest veilige versie is.

## 3. Bijdrage versiebeheer, CI/CD pipeline en/of monitoring

Deze week heb ik gewerkt aan de flow van werk in github, ik er voor gezorgd dat er een aantal extra rules zijn bij het mergen van een pull-request, zoals het gebruik van 1 manier en het standaard verwijderen van een branch na het mergen. Voor de standaard manier hebben ik na overleg gekozen voor squash merging, deze keuze heb ik gemaakt omdat meer mensen wisten hoe mergen werkte ten opzichte van rebase. Ook heb ik een ruleset aangemaakt die controleert of de pull-request is gereviewd.

- [Merging rules](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/settings)
- [Review rules](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/settings/rules)

## 4. Onderzoek

Ik heb mijn onderzoek gedaan naar keycloak ([keycloak onderzoek](https://github.com/hanaim-devops/devops-blog-jorianroelofsen)), dit heb ik ook in dit project proberen te verwerken.
Ik heb de eerste week gewerkt aan keycloak, dit ik heb dit niet werkend kunnen krijgen door een aantal [errors](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/issues/9) die ik niet weg kreeg.
De 1e comment laat een error zien die ik kreeg na het maken van de 401 error, deze error duid erop dat de manier waarop en de setting die je meegeef geen toegang hebben tot keycloak. De errors uit de 2e comment duiden erop dat ik geen acces heb tot keycloak [issue 1](https://github.com/IdentityServer/IdentityServer4/issues/2337) [issue 2](https://github.com/IdentityServer/IdentityServer4/issues/2672).
Om deze errors op te lossen heb ik zelfs nog gebruik gemaakt van exact dezelfde code die is gegeven in de [documentatie](https://nikiforovall.github.io/keycloak-authorization-services-dotnet/examples/web-app-mvc.html), maar zelf met deze code kreeg ik dezelfde errors.
 
## 5. Bijdrage code review/kwaliteit anderen en security

Ik heb een heel aantal code reviews gedaan, hieronder een aantal van de belangrijkste.
16-10-2024
[Code review](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/17)
gekeken naar de code over HPA, opmerking gegeven over het feit dat elke service een eigen stuk heeft. Dit kon niet gecombineerd worden, dus de code is goedgekeurd.
17-10-2024
[Code review](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/32)
Gekeken naar de code over logic voor DIYavond, heb hier opmerkingen gemaakt over de gebruikte datatypes. Deze zijn aangepast. Ook heb ik opmerkingen gemaakt over de gebruikte namen van de variabelen, de naamgeving was afwisselend nederland en engels. Dit is aangepast.
17-10-2024
[Code review](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/33)
Gekeken naar de code over de logic voor de DIYavond, hier heb ik opmerkingen gemaakt over het gebruik van async zonder await. De datacast van list naar IEnumerable. Ook heb ik een opmerking gegeven dat de propertys die null kunnen zijn nullable moeten zijn in de models. En als laatste heb ik een opmerking gemaakt over een mogelijke fout doordat een waarde null kan zijn. Die is netjes afgevangen.
 
## 6. Bijdrage documentatie

Ik heb samen met mitchel gewerkt aan het container diagram in c4. Ook heb ik gewerkt aan het testplan en aan een ADR over keycloak.

- [C4 diagram](https://github.com/hanaim-devops/devops-bp-pitstop-uitbreiding-team-knoppert/pull/97)
- [Testplan](C:\documenten\Minor-DevOps\devops-bp-pitstop-uitbreiding-team-knoppert\docs\testplan.md), ik heb hier gewerkt aan testen voor annuleren van een DIY avond en de details van de eerst volgende DIY avond.
- [ADR keycloak](C:\documenten\Minor-DevOps\devops-bp-pitstop-uitbreiding-team-knoppert\docs\adr\adr-001-gebruik-van-keycloak-voor-authenticatie-en-autorisatie.md)
 
## 7. Bijdrage Agile werken, groepsproces, communicatie opdrachtgever en soft skills

Ik heb geholpen met de acceptatiecriteria van de userstories. Ook ben ik notulist geweest tijdens sprint retrospective en voorzitter tijdens de eind oplevering. Tijdens de sprint heb ik een aantal DSU geleid.

- Helpen met [acceptatiecriteria](https://github.com/orgs/hanaim-devops/projects/31)
- Notulist tijdens sprint retrospective
- Voorzitter tijdens eind oplevering
- DSU geleid
  
## 8. Leerervaringen

### Tips

- Ik moet het volgende project meenemen dat ik niet te lang moet blijven hangen in een probleem. Als ik er niet uitkom moet ik hulp vragen of het laten liggen en later weer oppakken als er meer tijd beschikbaar is.
- Ik moet me meer focussen op 1 taak tegelijk, ik heb nu vaak meerdere taken tegelijk gedaan en dat werkt niet altijd even goed.

### Tops

- Ik heb veel geleerd over gebruik van automatisering van het proces doormiddel van github actions.

- Ik heb geleerd om beslisser te zijn, ik heb nu een aantal keer beslissingen genomen die ik eerst niet durfde te nemen. B.V. het kiezen van de merge strategie, het opzetten van het testplan.

### Feedback

Tijdens het werken aan keycloak heb ik de feedback gekregen dat ik beter er mee kon stoppen en een ADR schrijven over keycloak. Dit heb ik gedaan en dit heeft mij veel tijd bespaard.

## 9. Conclusie & feedback

Ik heb dit project veel geleerd, wel is het veel ste kort. Dit zorgt ervoor dat het lastig is om elk aspect van DevOps toe te passen. Wel heb ik een heel aantal dingen die bij DevOps horen toegepast, zoals het configuren van apps en git en het gebruik van reviews en documentatie.
Ik neem het maken van simpele documentatie mee naar mijn afstudeeropdracht.

### Feedback Docent

De volgende onderdelen van het project kunnen beter:

- Het project is te kort, hierdoor is het lastig om alle aspecten van DevOps toe te passen.
