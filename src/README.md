wat je wel moet doen handmatig; 

ga naar;

`http://localhost:9001`

login met de gegevens uit de docker compose.

controleer of 'thanos-bucket' bestaat of niet. zo niet; 
create een nieuwe bucket met de naam; 'thanos-bucket' 

restart de compose enz. 

TODO; dit netjes maken natuurlijk.en de docker configs enz weer netjes maken. Prometheus yamls en docker compose.


![img.png](img.png)
![img_1.png](img_1.png)
![img_2.png](img_2.png)

prometheus, ziedt wel de results, maar metrics zelf gaan na 5 min weg (rentention)

![img_3.png](img_3.png)

thanos, door minio, blijven de metrics wel langer beschikbaar

![img_4.png](img_4.png)