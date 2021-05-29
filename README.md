# Craft Hack
Software development track - Siemens challenge.

## Inspiration

Covid-19 pandemic has been highly affecting a public transport. Train operators have a responsibility to ensure that citizens and visitors can travel to work, school and to other places of interest in a safe and sustainable way. Solution to provide safer travels can be achieved with use of train data and modern technology.


## Architecture

Our vision of solution architecture for the platform can be seen on the following picture:

![Architecture](https://github.com/gvuksic/CHTransportation/blob/main/Images/arhitecture.png)

Data flows are following:
1. Data is ingested into the platform from wide variety of sources, such as trains, train stations and more.
2. Data is processed in real-time with use of Azure Stream Analytics and Azure Functions.
3. For real-time use in application data is stored in Azure Comsos database.
4. Data is ingested into Azure Data Explorer.
5. Azure Data Explorer is a big data analytics store for serving near real-time analytics applications and dashboards. Data can be routed to Azure Data Explorer and Cosmos DB in parallel, or from Cosmos DB to Azure Data Explorer.
6. Insights from data stored in Azure Data Explorer can be gained via custom dashboard or Power BI.
7. Azure Data Explorer is integrated with machine learning services such as Databricks and Azure Machine Learning.


## What we built

We built a serveless API with Azure Functions that can be consumed by admin dashboard application for an overview, and mobile application that is used by passenger in order to plan trips.

Our tech stack:
 - Azure Functions written with C#
 - Serverless SQL database
 - Web dashboard built with HTML5
 - Native iOS application written in Swift

Demo (YouTube video) of our iOS application:

[![iOS demo](https://img.youtube.com/vi/boBdc7TNuWk/0.jpg)](https://www.youtube.com/watch?v=boBdc7TNuWk)

Web dashboard:

![Dashboard](https://github.com/gvuksic/CHTransportation/blob/main/Images/dashboard-app.png)

The solution can combine different data about how many people will board at each stop, and predict where they will disembark. This can be done by use of ticket purchases and metrics data provided by the trains. We can calculate how many people are onboard, compare that number with the actual vehicle capacity and calculate occupancy levels.

Passengers could easily select a train that fits their needs in any end user application with use of the API we built.


## Accomplishments that we are proud of

We are proud that we achieved to combine many technologies in such a short time in order to demonstrate our idea and how predictive occupancy solution could be built easily.
