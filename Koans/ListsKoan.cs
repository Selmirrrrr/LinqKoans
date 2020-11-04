using System;
using System.IO;
using System.Collections.Generic;
using LinqKoans.Engine;
using System.Linq;
using Xunit;
using Shouldly;

namespace LinqKoans.Koans
{

    /// <summary>
    /// At this point, we assume that you’re familiar with arrays: they’re useful tools for managing large amounts of sequential data.
    /// But arrays have their drawbacks:
    ///     They have a limited length
    ///     You have to keep track of the number of elements in the array using a separate index
    ///     You can only edit one element at a time
    /// Lists resolve all of these issues! Like arrays, they are a sequential collection of values and they can hold references to any type. Unlike arrays, they have (effectively) unlimited length, they automatically track the number of actual elements in the list, and they have have handy methods to work with multiple elements at a time.
    /// In this lesson we’ll cover list basics and some common list methods.
    /// </summary>
    public class ListsKoan : Koan
    {
        private List<string> _cities;
        public override void Setup()
        {
            base.Setup();
            _cities = new List<string> { "Lausanne", "Mor​ges", "Bulle", "Nyon", "Berne" };
        }

        [Step(1)]
        /// <summary>
        /// var numbers = new List<int>();
        /// Creates a new list of ints.
        /// </summary>
        public void CreateAList()
        {
            //Replace FILL_ME_IN with a new empty list of string.
            var list = FILL_ME_IN;

            list.ShouldBeAssignableTo<List<string>>();
            list.ShouldBeEmpty();
        }

        [Step(2)]
        /// <summary>
        /// You can add elements to the list using the .Add() method
        /// numbers.Add(1);
        /// You can directly initialize the list with an object object initialization
        /// var numbers = new List<int> { 1, 2, 3 };
        /// </summary>
        public void CreateAListWithElements()
        {
            //Replace FILL_ME_IN with a new variable containing a list of cities "Lausanne", "Morges", "Bulle", "Nyon", "Berne"
            var list = FILL_ME_IN;

            list.ShouldBeAssignableTo<List<string>>();
            list.ShouldContain("Lausanne");
            list.ShouldContain("Morges");
            list.ShouldContain("Bulle");
            list.ShouldContain("Nyon");
            list.ShouldContain("Berne");
        }

        [Step(3)]
        /// <summary>
        /// You can access elements using indices and square brackets list[x]
        /// var number = numbers[1];
        /// </summary>
        public void FindElementWithIndices()
        {
            //You can access elements using indices and square brackets [x]

            //Replace FILL_ME_IN with the city Morges from the list `_cities`
            var city = FILL_ME_IN;

            city.ShouldBe("Mor​ges");
        }

        [Step(4)]
        /// <summary>
        /// You can also re-assign elements using bracket notation
        /// numbers[1] = 23;
        /// </summary>
        public void AssignElementWithIndices()
        {
            //Replace the city "Bulle" by "Renens" in the list _cities

            _cities[2].ShouldBe("Renens");
        }

        [Step(5)]
        /// <summary>
        /// We can find the number of elements in the list using the Count property:
        /// numbers.Count // return the number of elements in the given list
        /// </summary>
        public void CountElements()
        {
            //Replace FILL_ME_IN with an expression that counts cities in the `_cities` list.
            var count = FILL_ME_IN;

            count.ShouldBe(5);
        }

        [Step(6)]
        /// <summary>
        /// We can check if an element exists in a list using the Contains() method:
        /// numbers.Contains(2) // returns True
        /// numbers.Contains(-1) // returns False
        /// </summary>
        public void ContainsElements()
        {
            //Replace FILL_ME_IN by a expression that checks if "Lausanne" exists in the `_cities` list
            var exists = FILL_ME_IN;

            //Replace FILL_ME_IN by a expression that checks if "Prilly" exists in the `_cities` list
            var nope = FILL_ME_IN;

            exists.ShouldBeTrue();
            nope.ShouldBeFalse();
        }

        [Step(7)]
        /// <summary>
        /// To remove a specific item from a list we use the Remove() method. 
        /// It expects the specific item as an argument and it returns true if it was successfully removed. 
        /// numbers.Remove(1); // Removes the number 1 in the numbers lists and returns true.
        /// </summary>
        public void RemoveElements()
        {
            //Replace FILL_ME_IN by a expression that removes "Nyon" from the list.
            var result = FILL_ME_IN;

            result.ShouldBeTrue();
            _cities.ShouldNotContain("Nyon");
            _cities.ShouldContain("Lausanne");
        }

        [Step(8)]
        /// <summary>
        /// If we need to remove all of the elements from a list, we could iterate through the entire list and call Remove(). 
        /// But an easier way would be to use the Clear() method.
        /// numbers.Clear(); // removes all elements form numbers
        /// </summary>
        public void RemoveAllElements()
        {
            //Replace FILL_ME_IN by a expression that removes all cities from the `_cities` list
            //FILL_ME_IN;

            _cities.ShouldBeEmpty();
        }

        [Step(9)]
        /// <summary>
        /// We can perform an operation for every element in the list using for and foreach loops.
        /// With for loops, make sure to use Count to stay within the bounds of the list.
        /// for (int i  = 0; i < numbers.Count; i++)
        /// {
        ///     Console.WriteLine(number);       
        /// }
        /// Will write all numbers from the list into the console.
        /// </summary>
        public void IterateElementsWithFor()
        {
            //Write a for loop that will convert all city names to UPPERCASE with `.ToUpperInvariant()`


            _cities.All(city => city.All(c => Char.IsUpper(c) || c == '\u200B')).ShouldBeTrue();
        }

        [Step(10)]
        /// <summary>
        /// We can perform an operation for every element in the list using for and foreach loops.
        /// With a foreach loop, the counting is handled for you:
        /// foreach (int number in numbers)
        /// {
        /// Console.WriteLine(number);
        /// }
        /// Will write all numbers from the list into the console.
        /// Generally, we prefer foreach loops because they require less typing and thus less chance for typos.
        /// </summary>
        public void IterateElementsWithForeach()
        {
            //Write a foreach loop that will convert all city names to lowercase with `.ToLowerInvariant()` 

            _cities.All(city => city.All(c => Char.IsLower(c) || c == '\u200B')).ShouldBeTrue();
        }
    }
}