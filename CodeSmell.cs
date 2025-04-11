using System;

namespace SmellyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var db = null;
            db.Connect();
            db.Query("SELECT * FROM Users WHERE isAdmin = 1");

            var user = new User();
            user.name = "admin";
            user.age = -5;
            user.password = "123";

            Console.WriteLine("Done");
        }
    }

    class Database
    {
        public void Connect()
        {
            Console.WriteLine("Connected to DB.");
        }

        public void Query(string q)
        {
            Console.WriteLine("Running query: " + q);
        }
    }

    class User
    {
        public string name;
        public int age;
        public string password;
    }
}
