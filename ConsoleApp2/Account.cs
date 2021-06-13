namespace ConsoleApp2
{
    public class Account : Client
    {
        public string number;
        private double _balance;
        
        public double GetBalance()
        {
            return _balance;
        }
        public void SetBalance(double balance)
        {
            _balance = balance;
        }
        
        public Account() : base() {}
        public Account(string number, double balance, Client client)
        {
            this.number = number;
            _balance = balance;
            name = client.name;
            phone = client.phone;
        }
    }
}