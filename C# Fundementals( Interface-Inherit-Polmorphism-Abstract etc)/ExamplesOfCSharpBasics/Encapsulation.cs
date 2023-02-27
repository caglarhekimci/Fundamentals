//The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.
//To achieve this, you must:
//-declare fields / variables as private
//-public get and set methods, through properties, to access and update the value of a private field

//using System;

//namespace Encapsulation
//{
//    class Encapsulation
//    {
//        private string name { get; set; }  // field
//        public string Name    // property
//        {
//            get { return name; }
//            set { name = value; }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Encapsulation myObj = new Encapsulation();
//            myObj.Name = "Hi Tech Team!";
//            Console.WriteLine(myObj.Name);
//            Console.ReadLine();
//        }
//    }
//}

//Why Encapsulation?

//-Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
//-Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
//-Flexible: the programmer can change one part of the code without affecting other parts
//-Increased security of data



namespace EncapsulationApp
{
    class DatabaseManager
    {
        private string dbUserName = "root", dbPassword = "admin", mark = new string('-', 6), dbLoginName;
        public string checkName
        {
            get
            {
                return dbUserName;
            }
        }
        public string checkPassword
        {
            get
            {
                return dbPassword;
            }
        }
        public string setLoginName
        {
            set
            {
                dbLoginName = value;
            }
        }
        public void dbLogin()
        {
            Console.WriteLine("{0}\n< Database Connection Established >\n{1}", mark, mark);
            Console.WriteLine("-> Link provider: {0}\n-> Connection time : {1}\n{2}", dbLoginName, DateTime.Now.ToString("dd/MM/yyyy HH:mm"), mark);
        }

    }
}
namespace EncapsulationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userPassword, mark = new string('-', 6);
            DatabaseManager dbManager = new DatabaseManager();
            Console.WriteLine("{0}\n< C# Encapsulation Example >\n{1}", mark, mark);
            Console.Write("-> Enter Your Name: ");
            dbManager.setLoginName = Console.ReadLine();

            Console.Write("{0}\n-> Please enter database username: ", mark);
            userName = Console.ReadLine();

            Console.Write("-> Please enter database user password: ");
            userPassword = Console.ReadLine();

            if (dbManager.checkName == userName && dbManager.checkPassword == userPassword)
            {
                dbManager.dbLogin();
            }
            else
                Console.WriteLine("{0}\n-> Failed to login.\n{1}", mark, mark);

        }
    }
}
