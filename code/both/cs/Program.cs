using fs.Shared;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAddress = new Address("1 house", "2 lane", "BS2 2BS");
            

            Contact thing = null;
            var justEmail = Contact.NewJustEmail(Email.NewEmail("a@b.com"));
            var justEmailDecon = (Contact.JustEmail)justEmail;
            justEmailDecon.Item
        }
    }
}
