# F8T (Feet On The Tarmac) - ChatBot
![Project logo](./doc/f8t-logo.png)

## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)
* [F8T repositories](#f8t-repositories)

## General info
F8T is version of Feet On The Tarmac (FOTT) project for K8s. Originally FOTT project was built on Azure PaaS approach. 
It means was strongly related to Azure platform services such as Azure Functions for example. 
F8T based on the approach where all services are contenerizable and runnable in the cloud. 
This repository contains source code of ChatBot service. In the repo is a GitHub Actions workflow included which is responsible for build and deploy application into Azure Container Apps.
	
## Technologies
Project is created with:
* C#
* .NET 9
* Semantic Kernel
* Open Telemetry
* MediatR
* Scrutor
* Azure Application Insights

## Setup
TBD

## F8T repositories
* Infrastructure: [github.com/beniaminzaborski/bz-f8t-infrastructure](https://github.com/beniaminzaborski/bz-f8t-infrastructure)
* Administration: [github.com/beniaminzaborski/bz-f8t-administration](https://github.com/beniaminzaborski/bz-f8t-administration)
* Registration: [github.com/beniaminzaborski/bz-f8t-registration](https://github.com/beniaminzaborski/bz-f8t-registration)
* ChatBot (this one): [github.com/beniaminzaborski/bz-f8t-chatbot](https://github.com/beniaminzaborski/bz-f8t-chatbot)