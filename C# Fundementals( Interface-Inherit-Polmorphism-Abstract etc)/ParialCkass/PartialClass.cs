//Partial Class is a unique feature of C#.
//It can break the functionality of a single class into many files. When the application is compiled,
//these files are then reassembled into a single class file. The partial keyword is used to build a partial class. 


namespace Partial.Classes
{
    public partial class Myclass
    {
        public int Add(int x, int y)
        {
            return (x + y);
        }

    }
    public partial class Myclass
    {
        public int Sub(int x, int y)
        {
            return (x - y);
        }
    }
    public class Testclass
    {
        static void Main(string[] args)
        {
            Myclass Omyclass = new Myclass();
            Console.WriteLine(Omyclass.Add(10, 20));
            Console.WriteLine(Omyclass.Sub(25, 5));

        }
    }
}