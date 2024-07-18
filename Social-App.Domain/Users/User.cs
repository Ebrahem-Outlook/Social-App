namespace Social_App.Domain.Users;

public sealed class User
{
    public User(string firstName, string lastName, string email, string password)
        : base(Guid.NewGuid())
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    private User() { }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }

    public static User Create(string firstName, string lastName, string email, string password)
    {
        User user = new(firstName, lastName, email, password);

        // Raise();

        return user;
    }

    public void Update(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;

        // Raise();
    }
}
