
# People Searcher Application

Welcome to PeopleSearcher! This is a .NET WebAPI application with an Angular 8 front-end. It uses Code First Entity Framework to seed a test database.

![image](https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/PeopleSearcherCapture1.PNG)

## Prerequisites 
These are the required downloads:
 - Visual Studio
 - SQL Server or SQL Server Express
 - Node.js (https://nodejs.org/en/download/)
 
 ## Setup
 
1. Clone or download this repository.
2. Open the PeopleSearcher/Angular folder with Command Prompt and run `npm install`.
3. Next, run the command `npm run-script start`. The front-end portion of the project will be running at `http://localhost:4200/` but it is not quite ready yet.
4. Open the PeopleSearcher.sln file located at the root of the project folder with Visual Studio. 
5. **Optional** Open the Web.config file in the People Searcher project. Modify the PeopleSearcherContext connection string's Data Source to be the name of your SQL Server (Usually the name of the PC). You can leave the data source alone and the database will be created using SQL Server Express LocalDB. You can also change the name of the database here if you wish. The default is PeopleSearcherContext. 
6.  Run the project in Visual Studio.  
    This will start the Api on port 8080. There will be a link on this page to navigate to front-end project located at `http://localhost:4200/`.

## Trouble Shooting

The most common problem that you may have is with connecting to the SQL Server.
If experiencing these issues, please verify that you can connect to the server specified in the data source in the Web.config.

If you are still experiencing issues connecting, try opening `Administrative Tools` and open `Services`.  Find SQL Server in the list of services, right click, and choose `Properties`.  Go to the `Log On` tab and change `Log on as` to `Local System account`. Stop the service and restart it, then try again.
 
## Testing

### API
There is a Unit Test Project in the repository that can be run against the API.
To run the tests, right click on the PeopleSearcherTest project in Visual Studio and select `Run Tests`.

### Angular App

The Angular App uses Karma to test that the components and all of their imports are valid.
To run these tests, run `npm run-script test` using Command Prompt at the root of the Angular folder.  A Karma test window will either open automatically, or a link will be provided in the output of the Command Prompt. Click `DEBUG` at the top of the Karma browser window to run the tests. The output of the tests will display at the top of the page. 

**Note** These tests only test the creation of the components.

## Demo video:
[Demo](https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/PeopleSearcherApplication.mp4)
