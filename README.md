API -- Application Programming Interface


MOBILE APP/WebApp/Ussd (Talks to the API via controller endpoints) -<----- > API <-------> Database  


WebApp ----------------> Database 


MICROSERVICES ()


CodeFirst      -----> Write your classes and use them to generate your database  
DatabaseFirst


Models
Entities
Controller -- Endpoints
PUT -for updating existing records,
GET-fetching saved data,
POST--to save a given data,
DELETE --for deletions



-------------------------........................LESSON 20250916---------

CLASS;
blueprint for creating objects in your program

aside from defining the structure it also defines the behavior of the objects inside it. The class ideally wont store data but its objects will

CLASS PROPERTIES
characteristics/properties/attributes that the class objects will have. Can also define the each data the objects will store


{get;set} // Will support both read /write 

get; == Other codes would be able to Read the stored value
set; == Other codes would be able to Write the stored value


CONSTRUCTORS

A special method that has the same name as the class and normally would run automatically when we create a new object


Parameterless constructor



........................................................

Deep dive further into get/set
Init 
Null parameter handling /exceptions





-----------------------LESSON 20250922------------------------------------------


Monday
Wednesday
Friday


---------Domain Modelling --------
domain consultant
Entity Relationships (Many2Many,12Many)
Basic SQL (CRUD);


-------------------------------------------------------

Frontend ---> API ------>Database (DB)

DB -- Relational/Non relational

1.Relational -- > SQL , Postgres , Oracle
2.Non relational (Document based -- They store data in json format) --> Mongo DB,Cassandra , Aws Dynamo, Azure Cosmos

Choice

...............................
Local setup for SQL. 
https://learn.microsoft.com/en-us/ssms/install/install


1. ssm -- sql server management studio : https://aka.ms/ssms/21/release/vs_SSMS.exe

2. Server  : https://go.microsoft.com/fwlink/p/?linkid=2215158&clcid=0x809&culture=en-gb&country=gb
 for the server dont select express, use developer 2022


--------------Db-------
Creating the database
Create Tables
Create Views
Create Stored Procedures
Table relationships 
Optimization / Indexing
-------------
Creating of records
Updating the records
Deleting
Selects
Joins

--------------------------------------Create Tables IN sql------------------------

CREATE TABLE TABLENAME (
 
Column1  datatype,
Column2  datatype,
Column3  datatype,
Column4  datatype
)

CREATE TABLE STUDENT (
Id int,
FirstName varchar(500),
LastName varchar(500),
Fullname varchar(500),
Email varchar(500),
PhoneNumber varchar(500),
Major varchar(500),
LinkedInProfile varchar(500)
)




https://www.w3schools.com/sql/














