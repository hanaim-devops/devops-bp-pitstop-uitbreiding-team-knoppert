$DOCKER_USERNAME = 'jelmer0314'
$IMAGE_TAG = '1.0'

# List of services
$services = @(
    'customermanagementapi',
    'webapp',
    'workshopmanagementeventhandler',
    'timeservice',
    'notificationservice',
    'invoiceservice',
    'auditlogservice',
    'workshopmanagementapi',
    'vehiclemanagementapi',
    'diymanagementapi'
)

foreach ($service in $services) {
    $originalImage = "pitstop/${service}:${IMAGE_TAG}"

    $newImage = "${DOCKER_USERNAME}/pitstop-${service}:${IMAGE_TAG}"
    
    Write-Host "Retagging $originalImage to $newImage"
    docker tag $originalImage $newImage
    
    Write-Host "Pushing $newImage to Docker Hub"
    docker push $newImage
}

Write-Host "All images have been retagged and pushed successfully."
