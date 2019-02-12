using fs.Shared;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAddress = new Address("1 house", "2 lane", "BS2 2BS");
            
            var justEmail = Contact.NewJustEmail(Email.NewEmail("a@b.com"));

            System.Console.WriteLine(Utils.contactInfoToString(justEmail));

            System.Console.ReadKey();
        }
    }
}
