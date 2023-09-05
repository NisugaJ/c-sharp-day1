

using System.Text;

namespace CSharpDay1
{
    internal class BankAccount
    {
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        // constructor
        public BankAccount(string owner, decimal initialDeposit)
        {
            Console.WriteLine("Constructing a new BankAccount");

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed += 1;

            this.Owner = owner;
            MakeDeposit(initialDeposit, DateTime.Now,"Initial");
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be greater than 0.");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void Withdraw(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be grater than 0.");
            }
            if(this.Balance - amount < 0)
            {
                throw new InvalidOperationException("No enough balance");
            }
            var withdraw = new Transaction(-amount, date, note);
            allTransactions.Add(withdraw);
        }

        public string GetAccountStatement()
        {
            var report = new StringBuilder();
            decimal balance = 0;

            report.AppendLine("--------------Account History----------------");
            report.AppendLine("Date\tAmount\tNote\tBalance");

            foreach (Transaction item in allTransactions)
            {
                balance += item.Amount;

                report.AppendLine($"{item.timestamp.ToShortDateString()}\t" +
                    $"{item.Amount}\t" +
                    $"{item.Note}\t" +
                    $"{balance}");
            }
            report.AppendLine();
            report.AppendLine($"Current balance is \t" +
                    $"{this.Balance}\t");
            report.AppendLine("---------------------------------------------");

            return report.ToString();
        }
    }
}
