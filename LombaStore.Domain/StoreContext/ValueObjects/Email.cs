namespace LombaStore.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        public Email(string email)
        {
            Email = email;
        }

        public string Email { get; private set; }

        public override string ToString()
        {
            return Email;
        }
    }
}
