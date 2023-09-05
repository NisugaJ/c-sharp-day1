

using System.Text;

namespace CSharpDay1.Inheritance
{
    internal class Audit
    {
        public DateTime Created { get; set; }
        public string CreatedById { get; set; }
        public DateTime Updated { get; set; }
        public string UpdatedById { get; set; }

        public virtual string GetDetails()
        {
            return new StringBuilder()
                .Append($"Created at {Created} by user {CreatedById}\n")
                .Append($"Updated at {Updated} by user {UpdatedById}\n")
                .ToString();

        }
    }
}
