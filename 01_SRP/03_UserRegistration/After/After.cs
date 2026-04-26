using System;

public class UserValidator
{
    public void Validate(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
        {
            throw new ArgumentException("Invalid email.");
        }

        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            throw new ArgumentException("Password must be at least 6 characters.");
        }
    }
}

public class UserRepository
{
    public void Save(string email)
    {
        Console.WriteLine($"User '{email}' saved in database.");
    }
}

public class WelcomeEmailService
{
    public void Send(string email)
    {
        Console.WriteLine($"Welcome email sent to '{email}'.");
    }
}

public class UserRegistrationService
{
    private readonly UserValidator _validator = new UserValidator();
    private readonly UserRepository _repository = new UserRepository();
    private readonly WelcomeEmailService _emailService = new WelcomeEmailService();

    public void Register(string email, string password)
    {
        _validator.Validate(email, password);
        _repository.Save(email);
        _emailService.Send(email);
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
