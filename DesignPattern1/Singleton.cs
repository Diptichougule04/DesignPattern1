using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPattern1
{
    internal class Singleton
    {
        //1declere private static field
        private static Singleton instance;

        private static ConnectionMultiplexer conn;
        private static 

        //2 private constructor
        private Singleton()
        {
        conn=
        }

        //3getInstance method which will be accessed from outside
        //will return instance always when it called
        //if 1st time call create instance
        //else return always  created

        public static Singleton GetInstance()
        { 
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
        //4any business logic(optional)
        public IDatabase

    }
}
