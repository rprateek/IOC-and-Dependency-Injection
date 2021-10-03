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
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person(string _FirstName, string _LastName, int _id)
        {
            this.firstName = _FirstName;
            this.lastName = _LastName;
            this.id = _id;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    public class Student:Person 
    {
       
        private int[] testScores;


        public Student(string _FName, string _LName, int _id, int[] scores) :base(_FName, _LName, _id)
        {

            testScores = scores;

        }
               
        public char Calculate()
        {
            char retVal=' ';

            int total = 0;
            double avg = 0;
            for (int i = 0; i < testScores.Length; i++)
            {              
                    
                total = total + testScores[i];
            }
            avg = total / testScores.Length;

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
            else if (avg<40)
            {
                retVal = 'T';
            }

            return retVal;
        }

    }


    //String title = Console.ReadLine();
    //String author = Console.ReadLine();
    //int price = Int32.Parse(Console.ReadLine());
    //Book new_novel = new MyBook(title, author, price);
    //new_novel.display();          
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

    public class MyBook:Book
    {
        
        private int _Price;
        public MyBook(string title, string author, int price):base(title,author)
        {         
            _Price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " +_Price);
           
        }
    }

}
