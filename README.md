# Project Name : SigmaTestTask 
# Project Test Name : SigmaTestTask.Tests

Project created to be maintainable  reusable, testable ,scalable

## consist of 4 layers
####	1 - API Layer or called { Presentation Layer} 	
		- Configurations
		- Helpers [ MappingProfile , Response class]
		- Controllers
		- DTOs
####	2 - Domain Layer 
		- Entities  [ SQL Server Provider ]
###	3 - Repository Layer or called 'Infrastructure'
		- packages 
		- Config
			- To apply constraints of Entity at Domain using fluent API instead of Data Annotation [Code Style ]
		- Migrations
		- Implementation to Access Data Source
###	4 - Service Layer 
		- Business logic on data before sending to repository


###  Execute  update-database automatically without make it manually [ manually => 'update-database' ]  
### AutoMapper Used
### Repository pattern
### Clean Code
### unit Test - XUnit package
# improvements  : Things that can make it later for big projects : 
	 UnitOfWork
	 GenericRepository 
	 Specification pattern
	 Middleware to handle all requests 
	 Standardize the response style 
  	 Clean Architecture or any architecture according to the project’s business :)
### If I find other ideas, I will write them  here.
### Thanks  😊  
	
