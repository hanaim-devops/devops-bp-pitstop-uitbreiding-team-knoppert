#docker push pitstop/customermanagementapi:1.0
#docker push pitstop/customermanagementapi:2.0
#docker push pitstop/webapp:1.0
#docker push pitstop/workshopmanagementeventhandler:1.0
#docker push pitstop/timeservice:1.0
#docker push pitstop/notificationservice:1.0
#docker push pitstop/invoiceservice:1.0
#docker push pitstop/auditlogservice:1.0
#docker push pitstop/workshopmanagementapi:1.0
#docker push pitstop/vehiclemanagementapi:1.0

# Push all the tagged images to the same repo with different tags
docker push jelmer0314/pitstop/customermanagementapi:1.0
docker push jelmer0314/pitstop/webapp:1.0
docker push jelmer0314/pitstop/workshopmanagementeventhandler:1.0
docker push jelmer0314/pitstop/timeservice:1.0
docker push jelmer0314/pitstop/notificationservice:1.0
docker push jelmer0314/pitstop/invoiceservice:1.0
docker push jelmer0314/pitstop/auditlogservice:1.0
docker push jelmer0314/pitstop/workshopmanagementapi:1.0
docker push jelmer0314/pitstop/vehiclemanagementapi:1.0
docker push jelmer0314/pitstop/diymanagementapi:1.0