# AKS Service Discovery Tester

A simple container utility that can be used to test service discovery within Kubernetes

## Test Locally

```bash

cd src

docker build -t aksservicesweb:latest -f ./Aks.Services.Web/Dockerfile .

docker run -it --rm -p 8099:80 --env IDENTIFIER=XXX --env CHILDURL=https://resttesttest.com/ --name svcdisc aksservicesweb:latest

```
