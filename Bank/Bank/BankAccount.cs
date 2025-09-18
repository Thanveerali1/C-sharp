namespace Bank
{
    public class BankAccount
    {
        private int balance;

        public BankAccount(int initialBalance)
        {
            balance = initialBalance;
        }

        public void depositAM(int amt)
        {
            balance += amt;
        }

        public void withdraw(int amt)
        {
            balance -= amt;
        }

        public int DispBalance()
        {
            return balance;
        }
    }
}