namespace LoginPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email;
            string password;

            while (true)
            {
                try
                {
                    Console.Write("Enter your email: ");
                    email = Console.ReadLine();
                    EmailValidator.Validate(email);
                    Console.Write("Enter your password: ");
                    password = Console.ReadLine();
                    PasswordValidator.Validate(password);
                    Console.WriteLine("Email and password are valid.");
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Validation error: {ex.Message}");
                }
            }
        }
    }
}
