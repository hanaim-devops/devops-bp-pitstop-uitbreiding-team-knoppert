# Testplan

Dit testplan is geschreven voor de features toegevoegd door team Knoppert in het project Pitstop uitbreiding.

## Gesteste onderdelen

- Aanmaken van een doe het zelf avond (ook wel bekend als DIYavond)
- Annuleren van een doe het zelf avond
- Feedback geven van een doe het zelf avond
- Registratie annuleren van een doe het zelf avond

## Testen

Voor het testen van alle features zijn hier een aantal testcases gemaakt, hierbij word gezorgd dat sowieso de happy flow word getest, daarnaast word er ook gekeken naar de edge cases.

### Aanmaken van een doe het zelf avond

Voor deze test zijn er geen pre-condities.

Voor het testen van het aanmaken van een van een doe het zelf avond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word een DIYavond aangemaakt en gekeken of deze correct word toegevoegd aan het overzicht.
- De edge case, hierbij word een DIYavond aangemaakt met een datum in het verleden, hierbij word gekeken of er een error word gegeven.
- De edge case, hierbij word een DIYavond aangemaakt met een leeg titel veld, hierbij word gekeken of er een error word gegeven.

#### Case 1: Happy flow voor het aanmaken van een doe het zelf avond

| **Action**                               | **Extra Info**                                                  | **Expected Result**                                           |
|------------------------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| 1. Ga naar de DIY management pagina       | URL: `http://localhost:7005/DIYManagement`                      | De DIY management pagina wordt geladen.                       |
| 2. Klik op de "Nieuwe avond" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Vul titel in                          | Titel: "DIY Avond - Motor Onderhoud"                            | Titelveld wordt correct ingevuld met ingevoerde waarde.       |
| 4. Vul startdatum en tijd in             | Startdatum: toekomstig tijdstip (bv. "2024-11-20 19:00")        | Startdatumveld wordt correct ingevuld en is een toekomstige datum. |
| 5. Vul einddatum en tijd in              | Einddatum: latere toekomstige tijdstip (bv. "2024-11-20 21:00") | Einddatumveld wordt correct ingevuld en is na starttijd.      |
| 6. Vul mechanic(s) in                    | Mechanics: "John Doe, Jane Smith"                               | Mechanic(s) veld wordt correct ingevuld met ingevoerde waarde.|
| 7. Voeg optionele extra info toe         | Extra info: "Voor gevorderde klussers"                          | Optioneel veld wordt correct ingevuld, indien nodig.          |
| 8. Klik op "Opslaan"                     | Bewaar de avond.                                                | De nieuwe avond is nu toegevoegd aan het overzicht |

#### Case 2: Datum in het verleden (Edge Case)

| **Action**                               | **Extra Info**                                                  | **Expected Result**                                           |
|------------------------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| 1. Ga naar de DIY management pagina       | URL: `http://localhost:7005/DIYManagement`                      | De DIY management pagina wordt geladen.                       |
| 2. Klik op de "Nieuwe avond" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Vul titel in                          | Titel: "DIY Avond - Remmen Controleren"                         | Titelveld wordt correct ingevuld met ingevoerde waarde.       |
| 4. Vul startdatum en tijd in             | Startdatum: een datum in het verleden                           | Een foutmelding verschijnt dat de startdatum in de toekomst moet liggen. |
| 5. Druk de opslaan knop in               |                                                                 | De avond kan niet worden opgeslagen zolang de datum in het verleden is. |

#### Case 3: Verplichte velden leeg laten (Edge Case)

| **Action**                               | **Extra Info**                                                  | **Expected Result**                                           |
|------------------------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| 1. Ga naar de DIY management pagina       | URL: `http://localhost:7005/DIYManagement`                      | De DIY management pagina wordt geladen.                       |
| 2. Klik op de "Nieuwe avond" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Laat alle velden leeg                 |                                                                 | Er komt geen foutmelding                                      |
| 4. Druk de opslaan knop in               |                                                                 | Alle velden. Weergeven een foutmelding dat deze verplicht is. |

### Annuleren doe het zelf avond

Pre-condities: Doe de Happy flow van "Aanmaken van een doe het zelf avond" voordat je deze testcases uitvoert.

Voor het testen van het annuleren van een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word een DIYavond geannuleerd en gekeken of de status van de DIYavond is aangepast.

- De edge case, hierbij word een DIYavond geannuleerd die al geannuleerd is, hierbij word gekeken of er een error word gegeven.

- De edge case, hierbij word een DIYavond geannuleerd die al is geweest, hierbij word gekeken of er een error word gegeven.

#### Case 1: Happy flow annuleren

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op de gewenste avond                          | Selecteer de avond die je wilt annuleren.                    | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Klik op de annuleer knop                           | de knop heet "cancel evening"                                  | Een popup wordt getoond dat de avond is geannuleerd |
| 4. Controleer de status op de overzichtspagina         | Ga terug naar de overzichtspagina om status te checken.       | De avond is geannuleerd en de status is aangepast naar een kruis. |

#### Case 2: annuleren van een al geannuleerde avond

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op de gewenste avond, de avond moet al geannuleerd zijn                          |                   | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Klik op de annuleer knop                           | de knop heet "cancel evening"                                  | Een popup wordt getoond dat de avond al geannuleerd is |
| 4. Controleer de status op de overzichtspagina         | Ga terug naar de overzichtspagina om status te checken.       | De avond is geannuleerd en de status is niet aangepast. |

#### Case 3: annuleren van een al geweest avond

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op de gewenste avond, de avond moet al geweest zijn                          |                   | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Klik op de annuleer knop                           | de knop heet "cancel evening"                                  | Een popup wordt getoond dat de avond al geweest is |
| 4. Controleer de status op de overzichtspagina         | Ga terug naar de overzichtspagina om status te checken.       | De avond is niet geannuleerd en de status is niet aangepast. |

### Feedback geven op een doe het zelf avond

Pre-condities:

- Er is een DIYavond aangemaakt die gestart is.
- Er is een DIYavond aangemaakt die nog niet gestart is

Voor het testen van het geven van feedback over een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word gekeken of er feedback toegevoegd kan worden nadat een DIYavond gestart is.

- De edge case, hierbij word gekeken of de feedback button niet zichtbaar is op het moment dat de DIYavond nog niet begonnen is.

#### Case 1: Happy flow feedback geven

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die al gestart is.                       | Je wordt doorgestuurd naar de detailpagina van de avond.    |
| 3. Klik op de knop "feedback"                         | Knop onder de datails.                                       | Het systeem laad het formulier.                             |
| 4. Vul de gegevens in en klik op opslaan              | Vul naam: "Jan" en feedback: "eten kon beter" in.            | De feedback is opgeslagen overeenkomstig input.             |

#### Case 2: Egde flow feedback geven

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die nog niet gestart is.                 | Je wordt doorgestuurd naar de detailpagina van de avond en kan geen feedback geven.    |

### Registratie annuleren van een doe het zelf avond

Pre-condities:

- Er is een DIYavond aangemaakt die gestart is.
- Er is een DIYavond aangemaakt die nog niet gestart is
- Er is een registratie voor die avonden.

Voor het testen van het annuleren van een registratie voor een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word gekeken of een registratie geannuleerd kan worden voor een DIYavond gestart is.

- De edge flow, hierbij word gekeken of de registratie annuleren button niet zichtbaar is nadat de DIYavond begonnen is.

#### Case 1: Happy flow registratie annuleren

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond nog niet gestart is.                     | Je wordt doorgestuurd naar de detailpagina van de avond.    |
| 3. Klik op de annuleer knop                           | Knop die naast een registratie staat.                        | Het systeem annuleert de registratie.                       |
| 4. Controleer de status                               | Kijk of de registratie niet meer zichtbaar is.               | De registratie is geannuleerd.                              |

#### Case 2: Egde flow registratie annuleren

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die al gestart is.                       | Je wordt doorgestuurd naar de detailpagina van de avond en kan geen registratie annuleren.|
