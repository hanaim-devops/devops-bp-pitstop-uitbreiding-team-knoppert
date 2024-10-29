# push-images.ps1

# Set your Docker Hub username and image tag
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

# Retag and push images for each service
foreach ($service in $services) {
    # Original image name
    $originalImage = "pitstop/${service}:${IMAGE_TAG}"
    
    # New image name with Docker Hub username
    $newImage = "jelmer0314/pitstop/${service}:${IMAGE_TAG}"
    
    # Retag the image
    Write-Host "Retagging $originalImage to $newImage"
    docker tag $originalImage $newImage
    
    # Push the image to Docker Hub
    Write-Host "Pushing $newImage to Docker Hub"
    docker push $newImage
}

Write-Host "All images have been retagged and pushed successfully."
