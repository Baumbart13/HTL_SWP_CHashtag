namespace LINQtoObjects.Model
{
    public class BankAccount
    {
        public Country Country { get; init; }
        public ulong IBAN { get; init; }
        public ulong BankCode { get; init; }
        public string BankName { get; init; }
        public ulong Amount { get; private set; }
        public Customer Customer { get; }
        
        public ulong AccountId => IBAN;
        public ulong BIC => BankCode;
        public ulong CustomerId => this.Customer.CustomerId;
    }
}