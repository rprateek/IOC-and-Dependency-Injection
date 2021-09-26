using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HackerRank
{
    class Program
    {
        //while ((sinput = Console.ReadLine()) != null)
        //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        static void Main(string[] args)
        {
			//string[] inputs = Console.ReadLine().Split();
			//string firstName = inputs[0];
			//string lastName = inputs[1];
			//int id = Convert.ToInt32(inputs[2]);
			//int numScores = Convert.ToInt32(Console.ReadLine());
			//inputs = Console.ReadLine().Split();
			//int[] scores = new int[numScores];
			//for (int i = 0; i < numScores; i++)
			//{
			//	scores[i] = Convert.ToInt32(inputs[i]);
			//}

			//Student s = new Student(firstName, lastName, id, scores);
			//s.printPerson();
			//Console.WriteLine("Grade: " + s.Calculate() + "\n");

			List<int> myNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			//var even = from x in myNumbers where x % 2 == 0 select x; // LINQ to get even numbers

			//Same LINQ query above using API Syntax
			var even = myNumbers.Where(x => x % 2 == 0);

            foreach (var item in even)
            {
                Console.WriteLine(item.ToString());
            }

		}       
       
    }

  

}
