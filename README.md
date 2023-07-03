# MovieCharactersAPI

Third and final assignment of the Back-end Web Development with .NET course I am currently undertaking.

This project is based on the following requirements for the assignment: 

## EF Core Code First
Create an application in ASP.NET Core and the application should comprise of a database made in SQL Server through EF Core with a RESTful API to allow users to manipulate the data. The database will store information about **characters**, **movies** they appear in, and the **franchises** these movies belong to. 

*Characters and movies*:

* One **movie** contains many **characters**, and a **character** can play in multiple **movies**.

*Movies and franchises*:

* One **move** belongs to one **franchise**, but a **franchise** can contain many **movies**.

Data requirements: 

The following subsections details the minimum required information to be stored for each entity. The foreign keys are omitted - this is up to you. 

*Character*
* Autoincremented Id
* Full name
* Alias (if applicable)
* Gender
* Picture (URL to photo - do not store an image)

*Movie*
* Autoincremented Id
* Movie title
* Genre (just a simple string of comma separated genres, there is no genre modelling required as a base)
* Release year
* Director (just a string name, no director modelling required as a base)
* Picture (URL to a movie poster)
* Trailer (YouTube link most likely)

*Franchise*
* Autoincremented Id
* Name
* Descriprtion

Note: The nullability and length limitations is up to you to decide what makes sense given the context. 

Seeding: 

* You are to create some dummy data using seeded data. You are to add at least 3 movies, with some characters and franchises. 

## Web API using ASP.NET Core
API requirements: 

* *Generic CRUD*

Full CRUD is expected for **Movies**, **Characters**, and **Franchises**. You can do proper deletes, just endure related data is not deleted - the foreign keys can be set to null. 

* *Updating related data*

In addition to generic "update entity" methods, there should be dedicated endpoints to: 

Updating **characters** in a **movie** and updating **movies** in a **franchise**.

* *Reporting* 

Your application should provide the following reports in addition to the basic reads for each entity: Get all the **movies** in a **franchise**, get all the **characters** in a **movie**, get all the **characters** in a **franchise**

DTOs with AutoMapper:

* Make data transfer objects (DTOs) for all the model classes clients will interact with.
* Use AutoMapper to create mappings between your domain models (entities) and these DTOs. 

Documentation with Swagger: 

* Create proper documentation using Swagger / Open API. 


## Notes on the code
As I was using .NET 6 and therefore inferred Foreign Keys, instead of defining them, I could not work out how to seed data to the Foreign Keys and to the joining table CharacterMovie, created for the many-to-many relationship. I therefore created the data in the tables directly in SQLServer, instead of through the application. 

* If anyone can help me with this, it would be greatly appreciated

Not all my DTOs seem to be working properly. The Get Character by Id is displaying more columns from the table than what I have defined in the DTO. 

* If anyone can help me with this, it would be greatly appreciated

I was not able to get the help to fully complete this assignment, but I think most of it should be correct and in alignment with what was required from the assignment. If anyone wants to help me complete this - please reach out. 


## Tools
I have used the following to make this console application:

* C#
* .NET6
* ASP.NET Core
* Microsoft Visual Studio 2022
* SQLServer

