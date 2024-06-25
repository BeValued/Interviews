"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var persons = [
    { id: 1, title: "Mr", forename: "Barney", surname: "McGrew", jobTitle: "Fireman", town: "Trumpton" },
    { id: 2, title: "Mr", forename: "Windy", surname: "Miller", jobTitle: "Miller", town: "Camberwick Green" },
    { id: 3, title: "Mr", forename: "Chippy", surname: "Minton", jobTitle: "Carpenter", town: "Trumpton" },
    { id: 4, title: "Mrs", forename: "Dora", surname: "Minton", jobTitle: "Housewife", town: "Trumpton" },
    { id: 5, title: "Mstr", forename: "Nibs", surname: "Minton", jobTitle: "Apprentice", town: "Trumpton" },
    { id: 6, title: "Mr", forename: "Nick", surname: "Fisher", jobTitle: "Bill sticker", town: "Trumpton" },
    { id: 7, title: "Mr", forename: "Jonathon", surname: "Bell", jobTitle: "Farmer", town: "Camberwick Green" },
    { id: 8, title: "Mr", forename: "Mickey", surname: "Murphy", jobTitle: "Baker", town: "Camberwick Green" },
    { id: 9, title: "Mr", forename: "Peter", surname: "Hazell", jobTitle: "Postman", town: "Camberwick Green" },
    { id: 10, title: "Mr", forename: "Thomas", surname: "Tripp", jobTitle: "Milkman", town: "Camberwick Green" }
];
/*
Create a new Angular project with routing
Using the sample data above create a mock service emulating 2 http requests:
    A list method that returns id and full name of all persons
    A get method taking an id parameter and returning the full details of a single person
Create a List view showing just Full Name (e.g. Mr Windy Miller)
    In alphabetical order (Surname then Firstname)
    Clicking on a user should navigate to details view
On Details view all details (except Id) with suitable labels, for the selected person

*/ 
//# sourceMappingURL=sampleData.js.map