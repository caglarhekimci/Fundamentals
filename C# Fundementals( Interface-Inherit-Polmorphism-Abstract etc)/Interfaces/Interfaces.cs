namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceIntro();
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }

        private static void InterfaceIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Ayberk",
                LastName = "Kolcu",
                Address = "Izmir"

            };
            Student student = new Student()
            {
                Id = 2,
                FirstName = "Shrek",
                LastName = "Solid",
                City = "Izmir"
            };

            manager.Add(customer);
            manager.Add(student);
            manager.Add(new Worker()
            {
                Id = 3,
                FirstName = "Shrek2",
                LastName = "Solid2",
                Department = "Computer Sciences2"
            });
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

    }
    class Student: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string City { get; set; }
    }

    class Worker: IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }
    
    class PersonManager
    {
        public void Add(IPerson person) // Instead of Customer parameter, we will use IPerson parameter.
                                        // It is another benefit that why we use Interface.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}