
namespace CSharpDay1
{
    internal class Transaction
    {
        public decimal Amount { get; }
        public DateTime timestamp { get; }
        public string Note { get; }

        public Transaction(decimal amount, DateTime timestamp, string note)
        {
            this.Amount = amount;
            this.timestamp = timestamp;
            this.Note = note;
        }   
    }
}
