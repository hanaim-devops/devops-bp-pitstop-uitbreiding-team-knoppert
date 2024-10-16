$url = "http://localhost:8080/realms/master/protocol/openid-connect/token"
$clientId = "admin-cli"
$username = "admin"
$password = "admin"
$grantType = "password"

$tokenResponse = Invoke-RestMethod -Uri $url -Method Post -ContentType 'application/x-www-form-urlencoded' -Body @{
    client_id = $clientId
    username = $username
    password = $password
    grant_type = $grantType
}

$masterToken = $tokenResponse.access_token

$realmUrl = "http://localhost:8080/admin/realms"
$headers = @{
    "Content-Type" = "application/json"
    "Authorization" = "Bearer $masterToken"
}

$realmData = @{
    realm = "pitstop-realm"
    enabled = $true
} | ConvertTo-Json

Invoke-RestMethod -Uri $realmUrl -Method Post -Headers $headers -Body $realmData