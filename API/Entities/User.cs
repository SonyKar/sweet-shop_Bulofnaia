namespace Bulofnaia.API.Entities
{
    public class User
    {
	    public User()
        {
        }

        public User(string firstName, string lastName, string position, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Username = username;
            Password = password;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}