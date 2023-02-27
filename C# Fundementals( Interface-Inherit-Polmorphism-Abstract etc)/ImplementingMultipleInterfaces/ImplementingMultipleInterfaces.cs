//The company has a various eployees. These eployees; Workers, Managers, Robots. Lets use the what we learn. Our aim is correct planing for Interfaces
namespace ImplementingMultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface IWorker
    {
        void Work();
        void Eat();
        void GetSalary();
    }
    class Managers : IWorker
    {

    }
    class Worker : IWorker
    {
        public void Eat()

    }
    class Robots : IWorker
    {
        public void Eat()

    }
}



























////The company has a various eployees. These eployees; Workers, Managers, Robots. Lets use the what we learn.

//namespace ImplementingMultipleInterfaces
//{
//    class ImplementingMultipleInterfaces
//    {
//        static void Main(string[] args)
//        {
//            IWorker[] workers = new IWorker[3]
//            {
//                new Manager(),
//                new Worker(),
//                new Robots()
//            };

//            foreach (var worker in workers)
//            {
//                worker.Work();
//            }

//            Console.WriteLine("****\n");

//            IEat[] eats = new IEat[2]
//            {
//                new Worker(),
//                new Manager()
//            };
//            foreach (var eat in eats)
//            {
//                eat.Eat();
//            }

//        }

//    }

//    interface IWorker
//    {
//        void Work();

//    }
//    interface IEat
//    {
//        void Eat();
//    }

//    interface ISalary
//    {
//        void GetSalary();
//    }

//    class Manager : IWorker, IEat, ISalary
//    {
//        public void Eat()
//        {
//            Console.WriteLine("I am Manager and I can Eat\n");
//        }

//        public void GetSalary()
//        {
//            Console.WriteLine("I am Manager and I can Get Salary\n");

//        }

//        public void Work()
//        {
//            Console.WriteLine("I am Manager and I can Work\n");

//        }
//    }

//    class Worker : IWorker, IEat, ISalary
//    {
//        public void Eat()
//        {
//            Console.WriteLine("I am Worker and I can Eat\n");

//        }

//        public void GetSalary()
//        {
//            Console.WriteLine("I am Worker and I can Get Salary\n");
//        }

//        public void Work()
//        {
//            Console.WriteLine("I am Manager and I can Work\n");
//        }
//    }
//    class Robots : IWorker
//    {
//        public void Work()
//        {
//            Console.WriteLine("I am Robot and I can Work\n");
//        }
//    }
//}