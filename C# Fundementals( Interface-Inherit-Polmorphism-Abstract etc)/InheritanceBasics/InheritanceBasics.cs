namespace InheritanceBasics
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Ayberk", City="London"},
                new Student{FirstName = "Shrek", Department="Ogr"},
                new Person{FirstName = "Yoda"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
                if (person.GetType().Equals(typeof(Customer)))
                {
                    Console.WriteLine(((Customer)person).City);
                    Console.WriteLine((person as Customer).City);

                }
            }

            
            Console.ReadLine();


        }
        

    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person //,Person2 !!!! Contrary to using Interface, we can Inheritance an object only once.
    {
        public string Department { get; set; }
    }

    //class Person2
    //{

    //}
}