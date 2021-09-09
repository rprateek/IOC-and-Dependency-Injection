using System;

namespace ValueTypeVsRefType
{

    public struct coordinates
    {
        // we can use sturct to have multiple value type variables in a combined form. 

        public int x ;
        public int y ;
        public int z ;

        public void AddTen() 
        {
            // we can have methods as well in struct 
            // but it is not good idea to replace object by struct
            // object can have big scope but struct can have fresh copy but can be good use when used for smaller items.
            x = x + 10;
            y = y + 10;
            z = z + 10;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {

            //Calling a struct 
            coordinates xyz = new coordinates();
            xyz.x = 1;
            xyz.y = 2;
            xyz.z = 3;

            coordinates xyz1 = xyz; // it is the value objects so will have fresh memory and the values will be copied to new memory. 

            xyz1.AddTen(); 
            Console.WriteLine("This is xyx.x: " + xyz.x + "This is xyz1.x: " + xyz1.x);
            Console.WriteLine("Look both values are different because both have separate memory allocation");

            

            // value types and reference types 
            
            int i = 10; /// primitive data types
            int j = i;// now j will have 10 means fresh memory allocated to j and assigned the value from i. 
            j = 30; // if we change the value of j it will only affect the memory of j not i. so j will be 30 and i will be 10
            // so this is called the value type variables. 

            //Vlaue types are stored in the Stack of the memory

            // Reference type points to the memory of initial object see below

            myClass obj1 = new myClass();
            obj1.name = "Pra";


            myClass obj2 = new myClass();
            obj2 = obj1; // assinging this by reference here obj2 is pointing to the memory of obj1 it doen't have its own. 
            obj2.name = "Prateek";

            Console.WriteLine("This is obj1 name:" + obj1.name);
            Console.WriteLine("This is obj2 name:" + obj2.name);

            //Output :
            //This is obj1 name:Prateek
            //This is obj2 name:Prateek

            // Here the obj2 is pointing the memory of obj1 so when we change the name at obj2 it also changed the obj1.Name. 
            // This is called reference type
            //Normally classes and objects are reference type variables and primitive int, bool etc are value types. 
            //Refence type is allocated memory in the HEAP

        }

        class myClass
        {
            public string name;
        }
    }
}
