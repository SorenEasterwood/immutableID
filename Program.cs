namespace immutableID
{
    internal class Program
    {
        public record Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }
            public Student(int i)
            {
                Id = i;
                FirstName = string.Empty; 
                LastName = string.Empty;
            }

        }
        static void Main(string[] args)
        {
            Student jim = new Student(2);
            jim.FirstName = "Jim";
            jim.LastName = "Donner";
            Console.WriteLine(jim);

            Student jane = new Student(3, "Jane", "Wayne");
            Console.WriteLine(jane);
        }
    }
}
