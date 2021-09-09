using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace DependencyInjection
{
    /// <summary>
    /// UI Layer 
    /// </summary>
    class Program
    {
           

        static void Main(string[] args)
        {

            //This can be declared anywhere in your global variable space such as Global.asax or App.xaml.cs or in Startup Event
            //IUnityContainer uContainer = new UnityContainer(); //This container contains all dependencies of the application 

            //uContainer.RegisterType<Idal, DatabaseServer>("DbServer"); // Here we are injecting Databaseserver class with its interface and giving it a key
            //uContainer.RegisterType<Idal, OracleDbase>("OracleDb"); // Here we are injecting OracleDbase class with its interface and giving it a key

            //uContainer.RegisterType<Customer>("CustDBServer", new InjectionConstructor(new ResolvedParameter<Idal>("DbServer")));
            //Here we are assigning a new unique key for Customer and DBServer together to become CustDBServer
            //uContainer.RegisterType<Customer>("CustOracle", new InjectionConstructor(new ResolvedParameter<Idal>("OracleDb")));
            //Here we are assigning a new unique key for Customer and OracleDb together to become CustOracle
            //Customer obj = uContainer.Resolve<Customer>("CustOracle");
            //Customer obj1 = uContainer.Resolve<Customer>("CustDBServer");
            //obj.CustomerName = "Test";
            //obj.Add();
            //obj1.CustomerName = "Test1";
            //obj1.Add();

           

            // Loading the Unity container from the config
            //This can be declared anywhere in your global variable space such as Global.asax or App.xaml.cs or in Startup Event
            IUnityContainer uContainer = new UnityContainer(); //This container contains all dependencies of the application 
            uContainer.LoadConfiguration();

            Customer obj = uContainer.Resolve<Customer>();

            

            obj.CustomerName = "Test";
             obj.Add();

          
                    

        }    


    }

   




    /// <summary>
    /// Business Logic Layer
    /// </summary>


    class Customer
    {
        public string CustomerName { get; set; }

        private Idal Daccess;
        
        public Customer (Idal obj)
        {
            Daccess = obj;
        }

        public bool validate()
        {
            return true;
        }
        public bool Add()
        {
            if (validate())
            {
                Daccess.AddToDb();
            }
            return true;
        }
    }

  

}
