using System;

namespace DAL
{
    public interface Idal
    {
        void AddToDb();
    }
    public class DatabaseServer:Idal
    {
       
        public string cnString;

        public void AddToDb()
        {

        }
        public void test()
        {

        }

    }

    public class OracleDbase : Idal
    {
        public void AddToDb()
        {
            //throw new NotImplementedException();
        }
    }

}
