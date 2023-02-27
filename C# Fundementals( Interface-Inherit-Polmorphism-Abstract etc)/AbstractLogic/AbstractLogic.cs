//Abstract Classes and Methods
//Data abstraction is the process of hiding certain details and showing only essential information to the user.
//Abstraction can be achieved with either abstract classes or interfaces.
//The abstract keyword is used for classes and methods:
//Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
//Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).


abstract class Database
{
    //Complated method
    public void Add()
    {
        Console.WriteLine("Added by Default");
    }
    //Uncomplated methods.
    public abstract void Delete();

}

class SqlServer : Database
{
    public override void Delete()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Deleted by Sql");
    }
}

class MySqlServer : Database
{
    public override void Delete()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Deleted by MySql");
    }
}
class AbstractLogic
{
    static void Main(string[] args)
    {
        Database database = new SqlServer();
        database.Add();
        database.Delete();
        Console.WriteLine("***********************\n");

        SqlServer sqlServer = new SqlServer();
        sqlServer.Add();
        sqlServer.Delete();
        Console.WriteLine("***********************\n");

        Database database2 = new MySqlServer();
        database2.Add();
        database2.Delete();
        Console.WriteLine("***********************\n");

        MySqlServer mySqlServer = new MySqlServer();
        mySqlServer.Add();
        mySqlServer.Delete();

        Console.ReadLine();
    }
}

//Why And When To Use Abstract Classes and Methods?

//To achieve security - hide certain details and only show the important details of an object.
//Note: Abstraction can also be achieved with Interfaces.