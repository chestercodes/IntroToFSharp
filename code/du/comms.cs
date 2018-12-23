public class Email 
{
    public string Value { get; }
    public Email (string value)
    {
        // plus validation
        Value = value;
    }
}

public class Phone 
{
    public string Value { get; }
    public Phone(string value)
    {
        // plus validation
        Value = value;
    }
}

public class Contact
{
    public Email Email { get; }
    public Phone Phone { get; }
    public Contact (Email email, Phone phone)
    {
        // Valid options: 
        // - Phone
        // - Email
        // - Phone and Email
        // Invalid options: 
        // - Neither
        if(email == null && phone == null)
        {
            throw new Exception("Need to specify email or phone");
        }

        Email = email;
        Phone = phone;
    }
}