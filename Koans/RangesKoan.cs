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
    /// In the world of lists we call a subsequence of elements a range.
    /// For example, this list has 3 elements: ["one", "two", "three", "four", "five"]
    /// We can say the range of elements from index 1 to 3 is: [two", "three", "four"]
    /// In this Koan we'll learn the 4 main range methods 
    ///  - `AddRange()`
    ///  - `InsertRange()`
    ///  - `RemoveRange()`
    ///  - `GetRange()`
    /// </summary>
    public class RangesKoan : Koan
    {
        private List<string> _cities;

        public override void Setup()
        {
            base.Setup();
            _cities = new List<string> { "Lausanne", "Mor​ges", "Bulle", "Nyon", "Berne" };
        }

        [Step(1)]
        /// <summary>
        /// `AddRange()` takes an array or list as an argument. Adds the values to the end of the list. Returns nothing.
        /// numbers.AddRange(new List<int>() {6, 7, 8}); //Adds the numbers {6, 7, 8} to the end of the list. 
        /// </summary>
        public void AddRange()
        {
            //Write an expression that adds "Sion" and "Fribourg" to the `_cities` list. 

            _cities.Count.ShouldBe(7);
            _cities.ShouldContain("Sion");
            _cities.ShouldContain("Fribourg");
        }

        [Step(2)]
        /// <summary>
        /// `InsertRange()` takes an int and array or list as an argument. Adds the values at the int index. Returns nothing.
        /// numbers.InsertRange(1, new List<int>() {6, 7, 8}); //Inserts the numbers {6, 7, 8} after the first value in the list. 
        /// </summary>
        public void InsertRange()
        {
            //Write an expression that inserts "Sion" and "Fribourg" after "Lausanne" in the `_cities` list.

            _cities.Count.ShouldBe(7);
            _cities[1].ShouldBe("Sion");
            _cities[2].ShouldBe("Fribourg");
        }

        [Step(3)]
        /// <summary>
        /// `RemoveRange()`takes two int values. The first int is the index at which to begin removing and the second int is the number of elements to remove. Returns nothing.
        /// numbers.RemoveRange(0, 2); //Removes the first 3 numbers from the list.
        /// </summary>
        public void RemoveRange()
        {
            //Write an expression that removes "Mor​ges", "Bulle", "Nyon" from the `_cities` list.

            _cities.Count.ShouldBe(2);
            _cities.ShouldContain("Lausanne");
            _cities.ShouldContain("Berne");
            _cities.ShouldNotContain("Mor​ges");
            _cities.ShouldNotContain("Bulle");
            _cities.ShouldNotContain("Nyon");
        }

        [Step(4)]
        /// <summary>
        /// `GetRange()` takes two int values. The first int is the index of the first desired element and the second int is the number of elements in the desired range. Returns a list of the same type.
        /// numbers.GetRange(0, 2); //Return the first 3 numbers from the list.
        /// </summary>
        public void GetRange()
        {
            //Replace FILL_ME_IN by an expression that return "Bulle", "Nyon" from the `_cities` list.
            var smallList = FILL_ME_IN;

            smallList.Count.ShouldBe(2);
            smallList.ShouldContain("Bulle");
            smallList.ShouldContain("Nyon");
            smallList.ShouldNotContain("Mor​ges");
            smallList.ShouldNotContain("Lausanne");
            smallList.ShouldNotContain("Berne");
        }
    }
}