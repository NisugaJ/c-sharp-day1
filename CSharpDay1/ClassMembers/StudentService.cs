
namespace CSharpDay1.ClassMembers
{
    internal class StudentService
    {
        /**
         * Fields
         * 
         * <private> <type> _<varName>;
         * 
         * Internal attributes of the class. Must  be used only inside the class. Use an _ as a prefix.
         **/
        private string _studentRegistrationNumber;

        /**
         * Constants
         * 
         **/
        public const int MonthsPerYear = 12;

        /**
         * Properties
         * 
         **/
        public string NationalIdNumber { get; set;  }

        /**
         * Methods
         * 
         **/
        public void Method1()
        {
            Console.WriteLine("Method 1 executed");
        }
        private void PrivateMethod1()
        {
            Console.WriteLine("PrivateMethod1 1 executed");
        }


        /**
         * Constructor
         * 
         **/
        public StudentService()
        {
            Console.WriteLine("Constructor");
        }
    }

    
}
