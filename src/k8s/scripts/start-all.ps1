# If started with argument -nomesh, the solution is started without service-mesh.
# If started with argument -istio, the solution is started with the Istio service-mesh.
# If started with argument -linkerd, the solution is started with the Linkerd service-mesh.

param (
    [switch]$nomesh = $false,
    [switch]$istio = $false,
    [switch]$linkerd = $false
)

if (-not $nomesh -and -not $istio -and -not $linkerd)
{
    echo "Error: You must specify how to start Pitstop:"
    echo "  start-all.ps1 < -nomesh | -istio | -linkerd >."
    return
}

$meshPostfix = ''
if (-not $nomesh)
{
    if ($istio -and $linkerd) {
        echo "Error: You can specify only 1 mesh implementation."
        return
    }

    if ($istio) {
        $meshPostfix = '-istio'
        echo "Starting Pitstop with Istio service mesh."

        # disable global istio side-car injection (only for annotated pods)
        & "../istio/disable-default-istio-injection.ps1"
    }

    if ($linkerd) {
        $meshPostfix = '-linkerd'
        echo "Starting Pitstop with Linkerd service mesh."
    }
}
else
{
    echo "Starting Pitstop without service mesh."
}

$yamlFiles = @(
    "../inotify-limits-daemonset.yaml", 
    "../pitstop-namespace$meshPostfix.yaml",
    "../monitoring-namespace.yaml",
    "../monitoring/prometheus-configmap.yaml",
    "../monitoring/thanos-objstore-config.yaml",
    "../monitoring/minio-deployment.yaml",
    "../monitoring/prometheus-deployment.yaml",
    "../monitoring/prometheus-service.yaml",
    "../monitoring/thanos-sidecar-service.yaml",
    "../monitoring/thanos-store-deployment.yaml",
    "../monitoring/thanos-store-service.yaml",
    "../monitoring/thanos-query-deployment.yaml",
    "../monitoring/thanos-query-service.yaml",
    "../metrics-server.yaml",
    "../rabbitmq.yaml",
    "../logserver.yaml",
    "../sqlserver$meshPostfix.yaml",
    "../mailserver.yaml",
    "../invoiceservice.yaml",
    "../timeservice.yaml",
    "../notificationservice.yaml",
    "../workshopmanagementeventhandler.yaml",
    "../auditlogservice.yaml",
    "../customermanagementapi-v1$meshPostfix.yaml",
    "../customermanagementapi-svc.yaml",
    "../vehiclemanagementapi$meshPostfix.yaml",
    "../workshopmanagementapi$meshPostfix.yaml",
    "../webapp$meshPostfix.yaml",
    "../ingress.yaml",
    # "../hpa/hpa.yaml",  # bestaat niet op deze branch?
    "../diymanagementapi$meshPostfix.yaml"
)

foreach ($file in $yamlFiles) {
    Write-Host "Applying configuration: $file"
    kubectl apply -f $file
}