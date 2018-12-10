# Robert Wooten COMP 586 Final Project Submission 

<h3>Subject of this project</h3>
CarInfo
Website that displays car info using a C# asp.net backend and angular frontend 
Website url: https://webapplication320181208101119.azurewebsites.net/

<h3>Requirements</h3>
Below is a summary of the requirements met and their status
Please note that while the project is fully functional using localhost, http requests are currently not working on website.    

<h3>MVC</h3>
Models(UserModel, UserVehiclesModel, fegovVehiclesModel) and Controllers(CarController, BrowseController) in Backend.  
Views implemented with Angular including all routing 

<h3>ORM</h3>
Entity Framework with SQlite
3 tables, one containing vehicle information, one containing user information, and one containing cars related to the user
one to many relationship exists with one users having many vehicles

<h3>SPA</h3>
Used Angular 
Multiple get methods implemented in CarService.ts and called in car-detail and browse components
Get methods can display info of a car based on ID and display all cars from a specific make.  
Post method written to add cars to a list but not utilized   

<h3>DI</h3>
DI exhibited in Backend with injecting database context in the Car and Browse controllers.  DI exhibited in Frontend with injection of services (carService.ts, authService.ts, httpClient) into components


<h3>Auth</h3>
Utilized auth0 to login/signup and store users.  
This is functional on the website
Credentials if you need them 
Credentials 1
// test@gmail.com
// Bobbill22
Credentials 2 
// robert.wooten.833@my.csun.edu
// Hankhill21
