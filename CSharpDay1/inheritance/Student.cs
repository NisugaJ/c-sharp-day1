using System.Text;

namespace CSharpDay1.inheritance
{
    internal class Student : Audit
    {
        public required string Id { get; set; }
        public required string FullName { get; set; }
        
        public override string GetDetails()
        {

            return
                new StringBuilder()
                .Append("Student Record\n")
                .Append($"Id: {Id}\n")
                .Append($"Full Name: {FullName}\n")
                .ToString()

                + base.GetDetails();
        }
    }

}
