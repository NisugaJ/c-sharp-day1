
namespace CSharpDay1
{
    internal class Person
    {
        // test comment 

        private string lastName;
        public string? FirstName { get; set; }
        public required string LastName // 'required' attributed can assigned a value only at initialization
        {   
            get => lastName; // returns value of lastName

            init => lastName = value; // here, value is the parameter value in the constructor method
        }
        // public required string LastName { set; init; } // same as above

        public decimal BasicSalary { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} Rs.{BasicSalary}");
        }
    }

}
