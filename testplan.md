# Testplan

Dit testplan is geschreven voor de features toegevoegd door team Knoppert in het project Pitstop uitbreiding.

## Gesteste onderdelen

- Annuleren DIYavond
- Feedback geven DIYavond
- Registratie annuleren DIYavond

## Testen

Voor het testen van alle features zijn hier een aantal testcases gemaakt, hierbij word gezorgd dat zowiezo de happy flow word getest, daarnaast word er ook gekeken naar de edge cases.

### Annuleren DIYavond

Voor het testen van het annuleren van een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word een DIYavond geannuleerd en gekeken of de status van de DIYavond is aangepast.

- De edge case, hierbij word een DIYavond geannuleerd die al geannuleerd is, hierbij word gekeken of er een error word gegeven.

- De edge case, hierbij word een DIYavond geannuleerd die al is geweest, hierbij word gekeken of er een error word gegeven.

#### Case 1: Happy flow

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                      |
| 2. Switch naar de monteur view                        | TODO: Uitleggen hoe                                          | Monteur view wordt ingeschakeld.                             |
| 3. Klik op de gewenste avond                          | Selecteer de avond die je wilt annuleren.                    | Je wordt doorgestuurd naar de detailpagina van de avond.      |
| 4. Klik op de annuleer knop                           | TODO: Locatie van de knop                                    | Een popup wordt getoond met de vraag of je zeker wilt annuleren. |
| 5. Bevestig annulering                                | Klik op "Ja, annuleer avond" in de popup.                    | Het systeem annuleert de avond en toont een bevestigingsbericht. |
| 6. Controleer de status op de overzichtspagina         | Ga terug naar de overzichtspagina om status te checken.       | De avond is geannuleerd en de status is aangepast naar een kruis. |

### Feedback geven DIYavond

Voor het testen van het geven van feedback over een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word gekeken of er feedback toegevoegd kan worden nadat een DIYavond gestart is.

- De edge case, hierbij word gekeken of de feedback button niet zichtbaar is op het moment dat de DIYavond nog niet begonnen is.

#### Case 1: Happy flow

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die al gestart is.                       | Je wordt doorgestuurd naar de detailpagina van de avond.    |
| 3. Klik op de feedback knop                           | Knop onder de datails.                                       | Het systeem laad het formulier.                             |
| 4. Vul de gegevens in en klik op opslaan              | Vul naam en feedback in.                                     | De feedback is opgeslagen.                                  |

#### Case 2: Egde flow

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die nog niet gestart is.                 | Je wordt doorgestuurd naar de detailpagina van de avond en kan geen feedback geven.    |

### Registratie annuleren DIYavond

Voor het testen van het annuleren van een registratie voor een DIYavond, zijn de volgende testcases gemaakt:

- De happy flow, hierbij word gekeken of een registratie geannuleerd kan worden voor een DIYavond gestart is.

- De edge flow, hierbij word gekeken of de registratie annuleren button niet zichtbaar is nadat de DIYavond begonnen is.

#### Case 1: Happy flow

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond nog niet gestart is.                     | Je wordt doorgestuurd naar de detailpagina van de avond.    |
| 3. Klik op de annuleer knop                           | Knop die naast een registratie staat.                        | Het systeem annuleert de registratie.                       |
| 4. Controleer de status                               | Kijk of de registratie niet meer zichtbaar is.               | De registratie is geannuleerd.                              |

#### Case 2: Egde flow

| **Action**                                            | **Extra Info**                                              | **Expected Result**                                          |
|-------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------------------|
| 1. Ga naar de DIY management pagina                   | URL: `http://localhost:7005/DIYManagement`                   | De DIY management pagina wordt geladen.                     |
| 2. Klik op de gewenste avond                          | Selecteer een avond die al gestart is.                       | Je wordt doorgestuurd naar de detailpagina van de avond en kan geen registratie annuleren.    |