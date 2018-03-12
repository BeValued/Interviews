using System.Collections.Generic;

namespace Interviews.Models
{
    public static class SampleData
    {
        public static IReadOnlyCollection<Person> Persons { get; private set; } = new List<Person>
        {
            new Person { Id = 1, Title = "Mr", Forename = "Barney", Surname = "McGrew", JobTitle = "Fireman", Town = "Trumpton"},
            new Person { Id = 2, Title = "Mr", Forename = "Windy", Surname = "Miller", JobTitle = "Miller", Town = "Camberwick Green"},
            new Person { Id = 3, Title = "Mr", Forename = "Chippy", Surname = "Minton", JobTitle = "Carpenter", Town = "Trumpton"},
            new Person { Id = 4, Title = "Mrs", Forename = "Dora", Surname = "Minton", JobTitle = "Housewife", Town = "Trumpton"},
            new Person { Id = 5, Title = "Mstr", Forename = "Nibs", Surname = "Minton", JobTitle = "Apprentice", Town = "Trumpton"},
            new Person { Id = 6, Title = "Mr", Forename = "Nick", Surname = "Fisher", JobTitle = "Bill sticker", Town = "Trumpton"},
            new Person { Id = 7, Title = "Mr", Forename = "Jonathon", Surname = "Bell", JobTitle = "Farmer", Town = "Camberwick Green"},
            new Person { Id = 8, Title = "Mr", Forename = "Mickey", Surname = "Murphy", JobTitle = "Baker", Town = "Camberwick Green"},
            new Person { Id = 9, Title = "Mr", Forename = "Peter", Surname = "Hazell", JobTitle = "Postman", Town = "Camberwick Green"},
            new Person { Id = 10, Title = "Mr", Forename = "Thomas", Surname = "Tripp", JobTitle = "Milkman", Town = "Camberwick Green"}
        };
    }
}