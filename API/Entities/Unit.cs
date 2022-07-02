namespace Bulofnaia.API.Entities
{
    public class Unit
    {
        private string _name;
        private int _id;

        public Unit()
        {
        }

        public Unit(string name)
        {
            _name = name;
        }
        public Unit(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public override string ToString()
        {
            return "id = " + _id + " name = " + _name;
        }
    }
}