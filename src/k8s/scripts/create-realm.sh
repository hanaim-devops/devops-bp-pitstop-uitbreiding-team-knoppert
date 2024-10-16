#!/bin/bash

# Fetch the access token from the Keycloak server
MASTER_TOKEN=$(curl --location --request POST "http://localhost:8080/realms/master/protocol/openid-connect/token" \
--header 'Content-Type: application/x-www-form-urlencoded' \
--data-urlencode 'client_id=admin-cli' \
--data-urlencode 'username=admin' \
--data-urlencode 'password=admin' \
--data-urlencode 'grant_type=password' | jq -r '.access_token')

# Create a new realm called 'demo-realm'
curl --silent --show-error -L -X POST "http://localhost:8080/admin/realms" \
--header "Content-Type: application/json" \
--header "Authorization: Bearer $MASTER_TOKEN" \
--data '{"realm":"pitstop-realm","enabled":true}'

echo "Realm 'pitstop-realm' created."