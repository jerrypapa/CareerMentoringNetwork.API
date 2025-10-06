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








---------------------------------------LESSON 2025-09-24-----------------------------




1. Mentors
2. Mentees
3. Sessions



create table Mentors (
MentorId int PRIMARY KEY,
FirstName varchar (500),--varchar translates to a string in .net/java/python etc
LastName varchar (500), -- comments
FullName varchar (500),
Major varchar (500),
YearsOfExperience int
)


create table Mentees (
MenteeId int PRIMARY KEY,
FirstName varchar (500),--string
LastName varchar (500),
FullName varchar (500),
CareerGoal varchar (5000)
)


create table Sessions 
(
  SessionId int PRIMARY KEY, 
  MentorId int,
  MenteeId int,
  SessionDate DATE,
  Topic varchar (500)
  
  FOREIGN KEY (MentorId) REFERENCES Mentors(MentorId),
  FOREIGN KEY (MenteeId) REFERENCES Mentees(MenteeId)
)

1. Direct relationships : A mentor can guide many mentees
                          A menee can be guided by many mentors (many2many)

In this case each row in our session table will be representing on mentorship interaction/session


In essence we will now have 

Mentors <-----> Sessions (One to many) : One mentor can have many sessions
Mentees <-----> Sessions (One to many) :One mentee can have many sessions





INSERTING DATA


INSERT INTO tablename VALUES();


INSERT INTO Mentors VALUES (1,'Jerry','Papa','Jerry Papa','Architecture',8)
INSERT INTO Mentors VALUES (2,'Stanley','Oduor','Stanley Oduor','Engineering',2)


INSERT INTO Mentees VALUES (1,'Mercy','Atieno','Mercy Atieno','CyberSec')
INSERT INTO Mentees VALUES (2,'Lloyd','Katila','Lloyd Katila','MobileDev')
INSERT INTO Mentees VALUES (3,'James','Ochieng','James Ochieng','Engineering')
INSERT INTO Mentees VALUES (4,'Kester','Okoth','Kester Okoth','WebDev')


INSERT INTO Sessions VALUES (1,1,1,'2025-09-24','dotnet series')
INSERT INTO Sessions VALUES (2,2,2,'2025-09-24','mobile dev series')
INSERT INTO Sessions VALUES (3,1,4,'2025-09-24','web series')
INSERT INTO Sessions VALUES (4,2,3,'2025-09-24','engineering series')



-------------------------READ DATA------------------

select * from tablename ///this returns all the data in a tablename


select * from Mentors
select * from Mentees
select * from Sessions




......................LESSON 20250927 ........................................

JOINS
VIEWS
SPs (Stored Procedure)

...................................JOINS............................................

Helps us get aggregated data across tables with relationships;

INNER JOINS  
LEFT JOIN
RIGHT JOIN
FULL OUTER JOIN
CROSS JOIN
......................................................................................

INNER JOINS  -- returns rows where there is a match in both tables

select * from Sessions s

INNER JOIN Mentors m ON s.Mentor_id = m.mentor_id
INNER JOIN Mentees t ON s.Mentee_Id = t.Mentee_Id 



REFINEMENT...


select s.SessionId,s.SessionDate,s.Topic,m.FirstName AS MENTORNAME,t.FirstName AS MENTEENAME from Sessions s

INNER JOIN Mentors m ON s.MentorId = m.MentorId
INNER JOIN Mentees t ON s.MenteeId = t.MenteeId 

......................................................................................
LEFT JOIN  -- return all rows from the left table even if there is no match in the right table

Scenario --> List all mentors and any sessions they have had

SELECT * FROM MENTORS m
LEFT JOIN Sessions s ON m.MentorId = s.MentorId



SELECT m.FullName,s.SessionDate,s.Topic FROM MENTORS m
LEFT JOIN Sessions s ON m.MentorId = s.MentorId
............................................................................................

RIGHT JOIN -- returns all rows from the right table

Scenario --> Show all mentees and any sessions they have attended. Shows all mentees even if they haven't had a session.

SELECT * FROM Sessions s RIGHT JOIN Mentees t ON s.MenteeId = t.MenteeId

..............................................................

FULL OUTER JOIN -- returns everything from both tables . Rows with no matches will always return a null

Scenario --> All mentors and all sessions whether or not they match

SELECT * FROM MENTORS m
FULL OUTER JOIN Sessions s ON  m.MentorId = s.MentorId


.............................................................
CROSS JOIN --  each row from one table is paired  with every row from the other tables

Scenario -->create all possible mentor - mentee pairs

SELECT * FROM MENTORS m CROSS JOIN MENTEES t


--Unions will allow yopu to execute 2 separate querries and merge the results

-- Use Union All when duplicates dont matter as UNions by default cleans duplicates

SELECT FullName, 'Mentor'  AS role FROM MENTORS

UNION

SELECT FullName, 'Mentee'  AS role FROM MENTEES


..........................................LESSON 20251006........................................


VIEWS
STORED PROCEDURES (sp's)


Views are like saved queries. They don't store new data but provides more of a shortcut to queries you run often;


CREATE VIEW SessionStats AS
select s.SessionId,s.SessionDate,s.Topic,m.FirstName,t.FullName from Sessions s
JOIN Mentors m on s.MentorId = m.MentorId
JOIN Mentees t on s.MenteeId = t.MenteeId;


STORED Procedures -- > Think of these as functions in your database
Store statements that you can execute with one command often with parameters

CREATE PROCEDURE GetSessionByMentor
 @mentorName VARCHAR(200)
AS
BEGIN

select s.SessionId,s.SessionDate,s.Topic,m.FirstName,t.FullName from Sessions s
JOIN Mentors m on s.MentorId = m.MentorId
JOIN Mentees t on s.MenteeId = t.MenteeId 
WHERE m.FirstName = @mentorName;

END


calling the sp:

EXEC GetSessionByMentor 'Jerry';



























