using System;
using System.IO;
using System.Collections.Generic;
using LinqKoans.Engine;
using Xunit;
using Shouldly;
using System.Linq;

namespace LinqKoans.Koans
{

    /// <summary>
    /// Imagine you’re building a new game in C#, with dozens of characters to manage in your database. How would you access them all? 
    /// What if you need to apply a filter? What if you needed to format each character name?
    /// You might think of storing characters in a list and running through each element with a foreach loop. 
    /// You’d have to write nested if statements, re-format each element, and store each result in a new list. The result isn’t pretty.
    /// Suppose that we want to find all the names in a list which are longer than 6 letters and return them in all uppercase letters. 
    /// You can see what it would look like in Program.cs in the code editor. And remember that this only works in a running C# file. 
    /// What if the database was stored in a separate server somewhere and it was implemented with SQL instead of C#?
    /// The solution is LINQ. It works for complex selections and transformations, and it works on local and remote data sources. 
    /// Each selection/transformation is called a query, and LINQ gives us new syntax and methods to write them.
    /// Imagine LINQ like an add-on to C# and .NET. Once you import the LINQ features, you can write new syntax, like:
    /// string[] names = { "Pierre", "Paul", "Jacques" };
    /// var filteredNames = from n in names
    ///                     where n.Contains("a")
    ///                     select n; // Returns { "Paul", "Jacques" }
    /// And you can use new methods on collections, like Where():
    /// var shortNames = names.Where(n => n.Length < 5); // Returns { "Paul" }
    /// </summary>
    public class LinqKoan : Koan
    {
        private List<string> _cities;

        public override void Setup()
        {
            base.Setup();
            _cities = new List<string> { "Lausanne", "Morges", "Bulle", "Nyon", "Berne" };
        }

        [Step(2)]
        /// <summary>
        /// In LINQ, you can write queries in two ways: in query syntax and method syntax.
        /// Query syntax looks like a multi-line sentence. If you’ve used SQL, you might see some similarities:
        /// var longLoudHeroes = from h in heroes
        ///                      where h.Length > 6
        ///                      select h.ToUpper();
        /// Method syntax looks like plain old C#. We make method calls on the collection we are querying:
        /// var longHeroes = heroes.Where(h => h.Length > 6);
        /// var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
        /// Every developer has a personal preference between syntaxes, but you should be able to read both. 
        /// /// </summary>
        public void MethodAndQuerySyntax()
        {
            //Method and Query Syntax return the same result
            var query = from c in _cities
                        where c.Contains("s")
                        select c.ToUpperInvariant();

            var method = _cities.Where(c => c.Contains("s")).Select(c => c.ToUpperInvariant());

            query.ShouldBeSameAs(method);
        }

        [Step(3)]
        /// <summary>
        /// The `where` operator is written as the method `Where()?`, which takes a lambda expression as an argument. 
        /// Remember that lambda expressions are a quick way to write a method. In this case, the method returns true if h is less than 8 characters long.
        /// `Where()` calls this lambda expression for every element in heroes. If it returns `true`, then the element is added to the resulting collection.
        /// numbers.Where(n => n > 5); // Return all numbers from the list that are greater than 5
        /// </summary>
        public void Where()
        {
            //Replace FILL_ME_IN with an expression that will return all cities with a name length that is grater than 5
            var longNameCities = FILL_ME_IN;

            longNameCities.ToList().Count.ShouldBe(2);
            longNameCities.ShouldContain("Lausanne");
            longNameCities.ShouldContain("Morges");
        }

        [Step(4)]
        /// <summary>
        /// To transform each element in a sequence — like writing them in uppercase — we can use the select operator. 
        /// In method syntax it’s written as the method `Select()`, which takes a lambda expression:
        /// var loudHeroes = heroes.Select(h => h.ToUpper()); // Returns all heroes with names transformed to UPPERCASE
        /// </summary>
        public void Select()
        {
            //Replace FILL_ME_IN with a `Select` expression that will convert all city names to lowercase with `.ToLowerInvariant()` 
            var lowerCaseCities = FILL_ME_IN;

            ((IEnumerable<string>)lowerCaseCities).All(city => city.All(c => Char.IsLower(c))).ShouldBeTrue();
        }

        [Step(5)]
        /// <summary>
        /// `Select` expression can also return completely new objects.
        /// For example you could iterate through a list of ints and return a list of strings.
        /// numbers.Select(n => new String(n.ToString())); // Returns a list of numbers converted to string.
        /// </summary>
        public void AdvancedSelect()
        {
            //Replace FILL_ME_IN with a `Select` expression that will return a list of `City` with corresponding Name and UpperCaseName.
            var cities = FILL_ME_IN;

            cities.ToList()[0].Name.ShouldBe("Lausanne");
            cities.ToList()[0].UpperCaseName.ShouldBe("LAUSANNE");
        }

        private class City
        {
            public string Name { get; set; }
            public string UpperCaseName { get; set; }
        }

        [Step(6)]
        /// <summary>
        /// `Any()` expression return true if **any** of the items in the list satisfies the condition
        /// numbers.Any(n => n > 5); // Returns true if any of the numbers in the list is greather than 5
        /// `Any()` can also be used without condition, then it returns true if list contains at least one element.
        /// numbers.Any(); // Returns true if list contains at least one element
        /// </summary>
        public void Any()
        {
            //Replace FILL_ME_IN with a `Any` expression that checks if any city contains the "ll" string
            var anyCitiesWithLl = FILL_ME_IN;

            anyCitiesWithLl.ShouldBeTrue();
        }

        [Step(7)]
        /// <summary>
        /// `All()` expression return true if **all** of the items in the list satisfies the condition
        /// numbers.Any(n => n > 5); // Returns true if all of the numbers in the list is greather than 5
        /// </summary>
        public void All()
        {
            //Replace FILL_ME_IN with a `All` expression that checks if all cities contain the "ll" string
            var allCitiesWithLl = FILL_ME_IN;

            allCitiesWithLl.ShouldBeFalse();
        }

        [Step(8)]
        /// <summary>
        /// Returns the first element of a sequence, or a default value if no element is found.
        /// numbers.FirstOrDefault(); // Returns the first element of a sequence, or 0 if no element is found.
        /// </summary>
        public void FirstOrDefault()
        {
            //Replace FILL_ME_IN with a `FirstOrDefault` expression that will return the first city from the list
            var firstOrDefault = FILL_ME_IN;

            firstOrDefault.ShouldBe("Lausanne");
        }

        [Step(9)]
        /// <summary>
        /// Returns the first element of the sequence that satisfies a condition or a default value if no such element is found.
        /// numbers.FirstOrDefault(n => n > 5); // Returns the first element of a sequence that is greater than 5, or 0 if no element is found.
        /// </summary>
        public void FirstOrDefaultWithCondition()
        {
            //Replace FILL_ME_IN with a `FirstOrDefault` expression that will return the first city from the list with a name length smaller than 6
            var firstOrDefault = FILL_ME_IN;

            firstOrDefault.ShouldBe("Bulle");
        }

        [Step(10)]
        /// <summary>
        /// When there's no element that matches the condition, `FirstOrDefault` returns the default value, a NULL in our case
        /// </summary>
        public void FirstOrDefaultDefault()
        {
            //Replace FILL_ME_IN with a `FirstOrDefault` expression that will return the first city from the list with a name length greater than 10
            var firstOrDefault = FILL_ME_IN;

            firstOrDefault.ShouldBeNull();
        }

        [Step(11)]
        /// <summary>
        /// `Max()` returns the maximum value in a sequence of values.
        /// </summary>
        public void Max()
        {
            int[] numbers = { 1, 2, 3, 5 };

            Assert.Equal(FILL_ME_IN, numbers.Max());
        }

        [Step(12)]
        /// <summary>
        /// `Min()` returns the minimum value in a sequence of values.
        /// </summary>
        public void Min()
        {
            int[] numbers = { 1, 2, 3, 5 };

            Assert.Equal(FILL_ME_IN, numbers.Min());
        }

        [Step(13)]
        /// <summary>
        /// Take returns a specified number of contiguous elements from the start of a sequence.
        /// </summary>
        public void Take()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Get just the 3 first numbers.
            var first3Numbers = numbers.Take(3);

            Assert.Equal(FILL_ME_IN, first3Numbers.Count());
        }

        [Step(14)]
        /// <summary>
        /// Sum computes the sum of a sequence of numeric values
        /// </summary>
        public void Sum()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //Get sum of the array.
            var sum = numbers.Sum();

            Assert.Equal(FILL_ME_IN, sum);
        }

        [Step(15)]
        /// <summary>
        /// OrderBy sorts the elements of a sequence in ascending order according to a key.
        /// </summary>
        public void OrderBy()
        {
            Pet[] pets = { new Pet { Name = "Barley", Age = 8 }, new Pet { Name = "Boots", Age = 12 }, new Pet { Name = "Whiskers", Age = 1 } };

            var query = pets.OrderBy(pet => pet.Age);

            Assert.Equal(FILL_ME_IN, query.FirstOrDefault().Name);
        }

        [Step(16)]
        /// <summary>
        /// OrderByDescending sorts the elements of a sequence in descending order according to a key.
        /// </summary>
        public void OrderByDescending()
        {
            Pet[] pets = { new Pet { Name = "Barley", Age = 8 }, new Pet { Name = "Boots", Age = 12 }, new Pet { Name = "Whiskers", Age = 1 } };

            var query = pets.OrderByDescending(pet => pet.Age);

            Assert.Equal(FILL_ME_IN, query.FirstOrDefault().Name);
        }

        [Step(17)]
        /// <summary>
        /// GroupBy groups the elements of a sequence according to a specified key selector function and creates a result value from each group and its key.
        /// </summary>
        public void GroupBy()
        {
            // Create a list of pets.
            List<Pet> petsList = new List<Pet>
            {
                new Pet { Name="Barley", Age=8 },
                new Pet { Name="Boots", Age=4 },
                new Pet { Name="Whiskers", Age=1 },
                new Pet { Name="Daisy", Age=4 }
            };

            // Group pets by their age
            var query = petsList.GroupBy(pet => pet.Age).ToList();

            Assert.Equal(FILL_ME_IN, query.Count);
        }

        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}