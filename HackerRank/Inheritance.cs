using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
//    string[] inputs = Console.ReadLine().Split();
//    string firstName = inputs[0];
//    string lastName = inputs[1];
//    int id = Convert.ToInt32(inputs[2]);
//    int numScores = Convert.ToInt32(Console.ReadLine());
//    inputs = Console.ReadLine().Split();
//    int[] scores = new int[numScores];
//		for(int i = 0; i<numScores; i++){
//			scores[i]= Convert.ToInt32(inputs[i]);
//		}

//Student s = new Student(firstName, lastName, id, scores);
//s.printPerson();
//Console.WriteLine("Grade: " + s.Calculate() + "\n");

    public abstract class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }        

    }


    public class Student:Person
    {
        private int idNumber { get; set; }

        private int[] TestScores;


        public Student(string _FirstName, string _LastName, int _id, int [] scores)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            idNumber = _id;
            TestScores = scores;

        }
        public virtual char Calculate()
        {
            char retVal=' ';

            int total = 0;
            double avg = 0;
            for (int i = 0; i < TestScores.Length; i++)
            {              
                    
                total = total + TestScores[i];
            }
            avg = total / TestScores.Length;

            if (90<=avg & avg<=100)
            {
                retVal = 'O';
            }
            else if (80 <= avg & avg <= 90)
            {
                retVal = 'E';
            }
            else if (70 <= avg & avg <= 80)
            {
                retVal = 'A';
            }
            else if (55 <= avg & avg <= 70)
            {
                retVal = 'P';
            }
            else if (40 <= avg & avg <= 55)
            {
                retVal = 'D';
            }
            else if (40 < avg)
            {
                retVal = 'T';
            }

            return retVal;
        }
    }
}
