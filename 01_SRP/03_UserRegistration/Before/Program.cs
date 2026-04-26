using System;

public class UserRegistrationService
{
    public void Register(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
        {
            throw new ArgumentException("Invalid email.");
        }

        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            throw new ArgumentException("Password must be at least 6 characters.");
        }

        // Multiple responsibilities in one class.
        Console.WriteLine($"User '{email}' saved in database.");
        Console.WriteLine($"Welcome email sent to '{email}'.");
    }
}

class Program
{
    static void Main()
    {
        UserRegistrationService service = new UserRegistrationService();
        service.Register("alice@example.com", "123456");
    }
}
