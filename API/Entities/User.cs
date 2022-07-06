namespace Bulofnaia.API.Entities
{
    public class User
    {
        private int _id;
        private string _firstName, _lastName, _position;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }
    }
}