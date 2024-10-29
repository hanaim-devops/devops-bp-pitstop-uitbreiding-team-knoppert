# MinIO

Als je voor de eerste keer de applicatie gaat starten moet je in MinIO een bucket voor de applicatie maken. Als je dit al reeds hebt gedaan, negeer dan dit! 

Helaas maakt MinIO niet automatisch een bucket aan als deze niet bestaat. Dat resultaat tot errors in de Thanos Sidecar. 

- Voor Docker, ga naar: 
`http://localhost:9001`

- Voor de k8s omgeving, ga naar; 
`http://localhost:30901`

Login met de gegevens uit de docker compose of k8s. Standaard zal dit zijn: 
Gebruikersnaam: minio

Wachtwoord: minio123

Wacht even en mogelijk ziet de Sidecar dat de bucket nu bestaat. Zo niet, herstart de omgeving.