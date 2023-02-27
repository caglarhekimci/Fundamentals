//Static or Compile Time Polymorphism 
//Method overloading is an example of Static Polymorphism. In overloading, the method
//function has a same name but different signatures. 


//public class TestData
//{
//    public int Add(int a, int b, int c)
//    {
//        return a + b + c;
//    }
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        TestData dataClass = new TestData();
//        int add1 = dataClass.Add(23, 34);
//        int add2 = dataClass.Add(45, 34, 67);
//        int add3 = dataClass.Add(add1, add2);

//        Console.WriteLine(add1);
//        Console.WriteLine(add2);
//        Console.WriteLine(add3);
//    }
//}


//Dynamic / Runtime Polymorphism
//Dynamic / runtime polymorphism is also known as late binding. Here,
//the method name and the method signature (number of parameters and parameter type must be the same and may have a different implementation). 

public class Drawing
{
    public virtual double Area()
    {
        return 0;
    }
    public double Area2()
    {
        return -1;
    }
}

public class Circle : Drawing
{
    public double Radius { get; set; }
    public Circle()
    {
        double Radius = 5;
    }

    public override double Area()
    {
        return (3.14) * Math.Pow(Radius, 2);
    }
    public new double Area2()// what is the differences
    {
        double test2 = ((3.14) * Math.Pow(Radius, 2));
        return test2;

    }
}

public class Square : Drawing
{
    public double Length { get; set; }
    public Square()
    {
        Length = 6;
    }
    public override double Area()
    {
        return Math.Pow(Length, 2);
    }
}

public class Rectangle : Drawing
{
    public double Height { get; set; }
    public double Width { get; set; }
    public Rectangle()
    {
        Height = 5.3;
        Width = 3.4;
    }
    public override double Area()
    {
        return Height * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Drawing circle = new Circle();
        Console.WriteLine("Area :" + circle.Area());

        Drawing square = new Square();
        Console.WriteLine("Area1 :" + square.Area());
        Console.WriteLine("Area2 :" + square.Area2());

        Drawing rectangle = new Rectangle();
        Console.WriteLine("Area :" + rectangle.Area());
    }
}


//SUMMARY

//The meaning of Polymorphism is one name having multiple forms.
//The following are the two types of Polymorphism:
//Static or compile-time polymorphism (for example, method overloading and operator overloading).
//Dynamic or runtime polymorphism (for example, overriding).
//Method Overriding differs from shadowing.
//Using the "new" keyword, we can hide the base class member.
//We can prevent a derived class from overriding virtual members.
//We can access a base class virtual member from the derived class.