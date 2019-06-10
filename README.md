# People Searcher Application

Welcome to PeopleSearcher! This is a .NET WebAPI application with an Angular 8 front-end. It uses Code First Entity Framework to seed a test database.

![]([https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/PeopleSearcherCapture.PNG](https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/PeopleSearcherCapture.PNG))

## Prerequisites 
These are the required downloads:
 - Visual Studio
 - Visual Studio Code
 - Sql Server or Sql Server Express
 -  Node.js (https://nodejs.org/en/download/)
 
 ## Setup
 
1. Clone this repository.
2. Open the PeopleSearcher/Angular folder with Visual Studio Code and run `npm install` in the integrated terminal.
3. Next, run the command `npm run-script start`. The front-end portion of the project will be running at `http://localhost:4200/` but it is not quite ready yet.
4. Open the PeopleSearcher/PeopleSearcher.sln file with Visual Studio and open the Web.config file in the People Searcher project. Modify the PeopleSearcherContext connection string's Data Source to be the name of your Sql Server (Usually the name of the PC). You can also change the name of the database if you wish here The default is PeopleSearcherContext.
6.  Run the project in Visual Studio.  
    This will start the Api on port 8080. There will be a link on this page to navigate to front-end project located at `http://localhost:4200/`.

## Other Info

There is a Unit Test Project in the repository that can be run against the API.
To run the tests, right click on the PeopleSearcherTest project in Visual Studio and select `Run Tests`.

## Demo video:
[Demo](https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/PeopleSearcherApplication.mp4)
