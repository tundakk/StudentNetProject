# StudentNetProject
A .NET VisualStudio Solution that demonstrates a typical REST API.
Create an Architecture and the accompanying documentation and diagrams for a simple Stock/Share price backend.
Develop it using the .NET 6 framework.

Data Model: 

•	Which gives access to the following Resources:
o	Exchange
	Id, Name, IsActive
o	StockSymbol
	Id, CompanyName, Ticker, IsActive, ExchangeId
o	EODPrice
	Id, Date, ClosePrice, StockSymbolId
 
o	Resource Relationships:

	Exchanges can have multiple StockSymbols
	A StockSymbol can only belong to/have 1 Exchange
	StockSymbols can have multiple EODPrices
	An EODPrice can only belong to/have 1 StockSymbol
	EODPrices and Exchanges are not directly linked.

REST and Application requirements:

•	Which exhibits the following attributes:
o	RESTful access to the specified resources above
	Provides typical CRUD Functionality, examples:
•	Return a list of all Exchanges
•	Create a new StockSymbol
•	Update an EODPrice

	Provides typical access to related resources, examples: 

•	Return a list of all StockSymbols for a given Exchange
•	Return a list of all EODPrices for a given StockSymbol, within in a certain date range
	Note: Not limited to just the example endpoints listed above! Use your discretion when choosing what endpoints to add.
 
o	N-tier/Multi-Layer Architecture:

	Project for each layer in the solution (Demos knowledges of Separation of Concerns)
•	API/Endpoint Layer
•	Business Logic Layer
•	Domain Model Layer
•	Data Access Layer
o	For demo purposes, this can interact with a SQLite DB
o	Uses Entity Framework Internally
	With .NET Core, needs to be Code-First
	With .NET Framework, it can be either DB or Code-First
o	Data Validation
o	Postman Workspace with example calls to the Endpoints
o	No Errors - should build and run
 
 
For Demo purposes, Database tables can be filled with Dummy-data generated via https://www.mockaroo.com/

