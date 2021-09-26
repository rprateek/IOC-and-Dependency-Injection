using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class TestLinq
    {
        public void GetEven()
        {
            List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //var even = from x in myNumbers
            //           where x % 2 == 0
            //           select x; // LINQ to get even numbers

            //Same LINQ query above using API Syntax
            var even = myNumbers.Where(x => x % 2 == 0);


            foreach (var item in even)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void GetUsers()
        {
            var users = new List<User>()
            {// add the user objects in the list of users using inline code. 
                new User()
                {
                    FirstName="First",
                    LastName="Simpson",
                    BirthYear=2005

                },
                new User()
                {
                    FirstName="Second",
                    LastName="Smith",
                    BirthYear=2345

                },
                new User()
                {
                    FirstName="Third",
                    LastName="Jackson",
                    BirthYear=2002

                }
            };
            // LINQ select
            var onlyFullNames = from x in users
                                where x.BirthYear >= 1990
                                select new { x.FirstName, x.LastName };

            //API LINQ select
            var onlyFirstandBirthYear = users.Where(x => x.BirthYear >= 1990)
                                             .Select(x => new { x.FirstName, x.BirthYear });
                                       

            foreach (var item in onlyFullNames)
            {
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                /// ther is no birth year in onlyFullNames because the LINQ only created new object containing first and last name
            }

            // using First in LINQ
            // This can be used to slect first record that matches the condition

            var firstOnly = users.First(); // first element of the collection
            var firstMatchesCondition = users.First(x => x.BirthYear >= 1990); // first element that matches the condition
            // The first method throws an error if no items are found.
            // You can use FirstorDefault that returns a default value which is null
            var firstorDefault = users.FirstOrDefault(x => x.BirthYear >= 1990); // first element that matches the condition or default value

            // Get exactly one item using Single or SingleorDefault

            var singleUser = users.Single(x => x.BirthYear == 1990); // exactly 1 record
            var singleorDefaultUser = users.SingleOrDefault(x => x.BirthYear == 1990);//exactly 1 or default record

            // Distinct- Return all distinct items in collection
            var findDistinctNumbers = new List<int> { 1, 2, 3, 4, 5, 5, 4, 6, 8, 9 };
            var distinct = users.Distinct();

            //Orderig - order a list of records in ascending or descinding
            var orderedUsers = users.OrderBy(x => x.FirstName)
                                    .ThenBy(x => x.LastName);// order in alphabetical order by fristname and LastName

            var orderDesc = users.OrderByDescending(x => x.FirstName)
                                  .ThenByDescending(x => x.LastName); // order by descending

            // Aggregration using LINQ
            List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            var Sum = myNumbers.Sum(); // adds all the numbers in the list
            var Min = myNumbers.Min(); // gets the minimum value in the list
            var Max = myNumbers.Max(); // gets the maximum value in the list
            var Count = myNumbers.Count(); // counts the number of elements in the list
            var Avg = myNumbers.Average(); // gets the average of elements in the list

            // Chaining methods by using LINQ API Syntax 
            // If you want all users ordered by firstname alphabetically where lastname starts with "S" and birth year is between 1990 and 2021

            var QueryResults = users.Where(x => x.LastName[0] == 'S'
                                                && x.BirthYear >= 1990
                                                && x.BirthYear <= 2021)
                                    .OrderBy(x => x.FirstName)
                                    .Select(x => x.FirstName + " " + x.LastName);
            // Retrieve it using
            foreach (var item in QueryResults)
            {
                Console.WriteLine(item.ToString());

            }

            //ANY -- Check the item in the collection

            bool IsAnyoneBornin2002 = users.Any(x => x.BirthYear == 2002); // chcek if the element contains user born in 2002
            bool hasAnyItemInCollection = users.Any(); // are there any items in collection

            bool isEveryoneBornIn2002 = users.All(x => x.BirthYear == 2002);  // does the collection contain all users with 2002 birth year

            bool hasNo7 = myNumbers.Contains(7); // checks if the number collection contains 7 

            //Intersection -- find the list of objects that are common in both lists 
            List<int> myNumbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            List<int> myNumbers2 = new List<int> { 5, 6, 7, 8, 9, 10, 15, 16,17,18,19,20 };

            var commonNumbres = myNumbers1.Intersect(myNumbers2);
            // output : 5,6,7,8,9,10

            //For getting all unique numbers from both list
            var Unique = myNumbers1.Union(myNumbers2);

            // Get elements that are in fist set but not in second set

            var except = myNumbers1.Except(myNumbers2);

            // Grouping 

            var Groups = users.GroupBy(x => x.BirthYear);

        }


    }


    class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
    }

}
