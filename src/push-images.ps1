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
    # Original image name
    $originalImage = "pitstop/${service}:${IMAGE_TAG}"
    
    # New image name with Docker Hub username and simplified naming
    $newImage = "${DOCKER_USERNAME}/pitstop-${service}:${IMAGE_TAG}"
    
    # Retag the image
    Write-Host "Retagging $originalImage to $newImage"
    docker tag $originalImage $newImage
    
    # Push the image to Docker Hub
    Write-Host "Pushing $newImage to Docker Hub"
    docker push $newImage
}

Write-Host "All images have been retagged and pushed successfully."
