# Testplan

Dit testplan is geschreven voor de features toegevoegd door team Knoppert in het project Pitstop uitbreiding.

## Gesteste onderdelen

- Registreren klant voor doe het zelf avond
- Aanmaken van een doe het zelf avond (ook wel bekend als DIYavond)
- Annuleren van een doe het zelf avond
- Feedback geven van een doe het zelf avond
- Registratie annuleren van een doe het zelf avond
- Bekijken historie van doe het zelf avonden van een klant

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
| 2. Klik op de "Register DIYEvening" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
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
| 2. Klik op de "Register DIYEvening" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Vul titel in                          | Titel: "DIY Avond - Remmen Controleren"                         | Titelveld wordt correct ingevuld met ingevoerde waarde.       |
| 4. Vul startdatum en tijd in             | Startdatum: een datum in het verleden                           | Een foutmelding verschijnt dat de startdatum in de toekomst moet liggen. |
| 5. Druk de opslaan knop in               |                                                                 | De avond kan niet worden opgeslagen zolang de datum in het verleden is. |

#### Case 3: Verplichte velden leeg laten (Edge Case)

| **Action**                               | **Extra Info**                                                  | **Expected Result**                                           |
|------------------------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| 1. Ga naar de DIY management pagina       | URL: `http://localhost:7005/DIYManagement`                      | De DIY management pagina wordt geladen.                       |
| 2. Klik op de "Register DIYEvening" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Laat alle velden leeg                 |                                                                 | Er komt geen foutmelding                                      |
| 4. Druk de opslaan knop in               |                                                                 | Alle velden weergeven een foutmelding dat deze verplicht is. |

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

### Registreren klant voor doe het zelf avond

Prerequisites:

- Er is een DIY Avond aangemaakt.

Voor het testen van het registreren van een klant voor een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij wordt een klant geregistreerd voor een DIYavond en gekeken of de klant is toegevoegd aan de lijst.

- De edge case, hierbij wordt geprobeerd een klant te registreren voor een DIYavond die al is geweest, hierbij word gekeken of de gebruiker niet naar de registratie pagina kan.

- De edge case, hierbij wordt een klant geregistreerd met lege waarden, hierbij word gekeken of er een error word gegeven.

#### Case 1: Happy flow

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op de gewenste avond                        |                   | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Klik op de registreer knop                           | De knop heet "Register Customer"                                  | Je wordt naar de pagina gestuurd waar je de nodige gegevens kan invullen om een klant te registreren voor de gegeven avond |
| 4. Vul de gegevens in en klik op de registreer knop                           |                   | De klant is toegevoegd aan de lijst van klanten die zich hebben geregistreerd voor de avond. |

#### Case 2: Egde flow

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op een avond die al begonnen is.                     |                   | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Check of er een knop aanwezig is om een klant te registreren                           |       | De knop is niet aanwezig, er kan geen klant geregistreerd worden |

#### Case 3: Egde flow

| **Action**| **Extra Info**| **Expected Result** |
|-----------|---------------|---------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Klik op de gewenste avond                        |                   | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 3. Klik op de registreer knop                           | De knop heet "Register Customer"                                  | Je wordt naar de pagina gestuurd waar je de nodige gegevens kan invullen om een klant te registreren voor de gegeven avond |
| 4. Laat alle velden leeg en druk op de registreer knop                           |                   | Er komt een foutmelding dat de aanwezige velden verplicht zijn. |

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

### Bekijken historie van klant doe het zelf avonden

Pre-condities:

- Er is een DIYavond aangemaakt die inmiddels is afgelopen
- Er is een DIYavond aangemaakt die nog niet gestart is
- Er is een registratie voor die avonden

Voor het testen van het bekijken van de historie van doe het zelf avonden van een klant, zijn de volgende testcases gemaakt:

- De happy flow, hierbij wordt een klant aangemeld voor een avond die al is geweest en voor een avond in de toekomst.

#### Case 1: Happy flow voor het bekijken van de historie van de doe het zelf avonden van een klant

| **Action**                               | **Extra Info**                                                  | **Expected Result**                                           |
|------------------------------------------|-----------------------------------------------------------------|---------------------------------------------------------------|
| 1. Ga naar de DIY management pagina      | URL: `http://localhost:7005/DIYManagement`                      | De DIY management pagina wordt geladen.                      |
| 2. Klik op de "Register DIYEvening" knop        | Begin het proces voor het aanmaken van een nieuwe avond.        | Het formulier voor een nieuwe avond wordt geopend.            |
| 3. Vul titel in                          | Titel: "Test avond 1"                                           | Titelveld wordt correct ingevuld met ingevoerde waarde.       |
| 4. Vul startdatum en tijd in             | Startdatum: toekomstig tijdstip (bv. "2024-11-20 19:00") (ik raad aan om een starttijd 1 minuut in de toekomst te zetten )        | Startdatumveld wordt correct ingevuld en is een toekomstige datum. |
| 5. Vul einddatum en tijd in              | Einddatum: latere toekomstige tijdstip (bv. "2024-11-20 21:00") (ik raad aan om een starttijd 2 minuut in de toekomst te zetten ) | Einddatumveld wordt correct ingevuld en is na starttijd.      |
| 6. Vul mechanic(s) in                    | Mechanics: "John Doe, Jane Smith"                               | Mechanic(s) veld wordt correct ingevuld met ingevoerde waarde.|
| 7. Voeg optionele extra info toe         | Extra info: "Voor gevorderde klussers"                          | Optioneel veld wordt correct ingevuld, indien nodig.          |
| 8. Klik op "Opslaan"                     | Bewaar de avond.                                                | De nieuwe avond is nu toegevoegd aan het overzicht. |
| 9. Klik op in de overzichtspagina op "Test avond 1" | Klik op "Register customer" | Het formulier voor een nieuwe klant registratie wordt geopend. |
| 10. Vul de "Customer Name" in            | Vul "Piet Knoppert" in                                          | Customer name is correct ingevuld. |
| 11. Vul de "Reparations" in              | Vul "Banden vervangen" in                                       | Reparations is correct ingevuld. |
| 12. Bevestig de aanmelding               | Klik op de "Register knop"                                      | De aanmelding is gelukt. |
| 13. Herhaal stap 2 tot en met 8, maar dan met andere titel, start- en einddatum | Zet de titel op "Test avond 2" en zet de start- en einddatum een dag in de toekomst | De nieuwe toekomstige avond is nu toegevoegd aan het overzicht |
| 14. Klik op in de overzichtspagina op "Test avond 2" | Klik op "Register customer" | Het formulier voor een nieuwe klant registratie wordt geopend. |
| 15. Herhaal stap 10 tot en met 12 |  | Een toekomstige reparatie wordt aangemaakt onder dezelfde naam |
| 16. Wacht tot de eindtijd van avond 1 is verstreken |  |  |
| 17. In het overzichtspagina vuld de klant naam in, in het invulveld | Vul de naam "Piet Knoppert" in | De naam staat in het invoerveld |
| 18. Klik op de knop "Customer History" | | Er is genavigeerd naar de customer history pagina |
| 19. Controleer of de juiste klant historie is opgehaald | Bekijk of in de titel de naam "Piet Knopper" staat | Deze naam staat er |
| 20. Controleer of alleen de historie er staat | Bekijk of in de tabel alleen "Test avond 1" staat | "Test avond 1" staat er en "Test avond 2" niet |
