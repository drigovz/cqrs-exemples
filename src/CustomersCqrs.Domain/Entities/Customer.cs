namespace CustomersCqrs.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string Phone { get; private set; }

        private Customer() 
        { }

        public Customer(string userName, string firstName, string lastName, string email, string cpf, string rg, string phone)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Cpf = cpf;
            Rg = rg;
            Phone = phone;
        }
    }
}
