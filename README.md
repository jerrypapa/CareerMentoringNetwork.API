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












