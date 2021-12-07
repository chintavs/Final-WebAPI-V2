using Final_WebAPI_V2.Context;
using Final_WebAPI_V2.Models;
using System;
using System.Linq;

namespace Final_WebAPI_V2.InitialData
{
    public static class InitialData
    {
        public static void Seed(this APIContext dbContext)
        {
            if (!dbContext.Breakfasts.Any())
            {
                dbContext.Breakfasts.Add(new Breakfast
                {
                    PersonName = "Tara",
                    BreakfastItem = "Bacon",
                    TimesPerWeek = 5
                });
                dbContext.Breakfasts.Add(new Breakfast
                {
                    PersonName = "Chris",
                    BreakfastItem = "Eggs",
                    TimesPerWeek = 2
                });
                dbContext.Breakfasts.Add(new Breakfast
                {
                    PersonName = "Tyler",
                    BreakfastItem = "Pancake",
                    TimesPerWeek = 1
                });
                dbContext.Breakfasts.Add(new Breakfast
                {
                    PersonName = "Sarah",
                    BreakfastItem = "Cereal",
                    TimesPerWeek = 7
                });

                dbContext.SaveChanges();
            }

            if (!dbContext.Students.Any())
            {
                dbContext.Students.Add(new Student
                {
                    FirstName = "Tyler",
                    LastName = "Parker",
                    Num_Classes = 10,
                    GPA = 4.0f

                });
                dbContext.Students.Add(new Student
                {
                    FirstName = "James",
                    LastName = "Verne",
                    Num_Classes = 9,
                    GPA = 3.7f

                });
                dbContext.Students.Add(new Student
                {
                    FirstName = "Sarah",
                    LastName = "Duberry",
                    Num_Classes = 7,
                    GPA = 3.8f

                });
                dbContext.Students.Add(new Student
                {
                    FirstName = "Ben",
                    LastName = "Harrison",
                    Num_Classes = 4,
                    GPA = 2.8f

                });
                dbContext.Students.Add(new Student
                {
                    FirstName = "Chris",
                    LastName = "Baltushaitis",
                    Num_Classes = 7,
                    GPA = 3.5f

                });
                dbContext.Students.Add(new Student
                {
                    FirstName = "Rachel",
                    LastName = "Crandon",
                    Num_Classes = 9,
                    GPA = 3.8f

                });


                dbContext.SaveChanges();
            }

            if (!dbContext.Teams.Any())
            {
                dbContext.Teams.Add(new Team
                {
                    Name = "Tyler Parker",
                    Birthday = new DateTime(2000, 9, 15),
                    College_Program = "Media",
                    Year = "Senior"
                });
                dbContext.Teams.Add(new Team
                {
                    Name = "Vishvak Chintalapalli",
                    Birthday = new DateTime(2002, 5, 21),
                    College_Program = "IT",
                    Year = "Sophmore"
                });
                dbContext.Teams.Add(new Team
                {
                    Name = "Jacob Farrish",
                    Birthday = new DateTime(1996, 2, 23),
                    College_Program = "CCM",
                    Year = "Senior"

                });
                dbContext.Teams.Add(new Team
                {
                    Name = "Tara Poudyel",
                    Birthday = new DateTime(2001, 4, 20),
                    College_Program = "CECH",
                    Year = "Junior"
                });


                dbContext.SaveChanges();
            }

            if (!dbContext.Animals.Any())
            {
                dbContext.Animals.Add(new Animal
                {
                    Phylum = "Chordata",
                    Class = "Mammalia",
                    Genus = "Calyptophractus",
                    Species = "Retusus"
                });
                dbContext.Animals.Add(new Animal
                {
                    Phylum ="Chordata",
                    Class ="Mammalia",
                    Genus = "Ailurus",
                    Species = "Styani"

                });
                dbContext.Animals.Add(new Animal
                {
                    Phylum ="Chordata",
                    Class ="Mammalia",
                    Genus = "Canis",
                    Species = "Rufus"

                });
                dbContext.Animals.Add(new Animal
                {
                    Phylum = "Chordata",
                    Class = "Mammalia",
                    Genus = "Canis",
                    Species = "Lupus"

                });
                dbContext.Animals.Add(new Animal
                {
                    Phylum ="Chordata",
                    Class ="Mammalia",
                    Genus = "Vulpes",
                    Species = "Vulpes"
                });

                dbContext.SaveChanges();
            }
        }
    }
}
