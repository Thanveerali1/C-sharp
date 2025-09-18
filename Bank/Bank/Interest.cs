namespace Bank
{
    public class Interest1 : BankAccount
    {
        public Interest1(int initialBalance) : base(initialBalance)
        {
        }

        public void AddInterest(int time, int rate)
        {
            int interest = (DispBalance() * time * rate) / 100;
            depositAM(interest);
            System.Console.WriteLine("Interest added: " + interest);
        }
    }
}