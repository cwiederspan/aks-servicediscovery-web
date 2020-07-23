# AKS Service Discovery Tester

A simple container utility that can be used to test service discovery within Kubernetes. This container
can be used recursively to test call chaining between different pods and services within a Kubernetes
deployment.

## Build Locally

```bash

cd src

docker build -t aksservicesweb:latest .

docker run -it --rm -p 8099:80 --env IDENTIFIER=XXX --env CHILDURL=https://resttesttest.com/ --name svcdisc aksservicesweb:latest

```

## Test Locally

[Test The Service](http://localhost:8099)
