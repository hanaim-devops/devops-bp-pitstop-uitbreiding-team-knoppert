# Verwijder resources in de pitstop namespace
kubectl delete svc --all -n pitstop
kubectl delete deploy --all -n pitstop
kubectl delete virtualservice --all -n pitstop
kubectl delete destinationrule --all -n pitstop


