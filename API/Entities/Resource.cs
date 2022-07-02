namespace Bulofnaia.API.Entities
{
    public class Resource
    {
        private int _id;
        private string _name;
        private float _quantity;
        private int _unit;

        public Resource()
        {
        }
        public Resource(string name, float quantity, int unit)
        {
            _name = name;
            _quantity = quantity;
            _unit = unit;
        }
        public Resource(int id, string name, float quantity, int unit)
        {
            _id = id;
            _name = name;
            _quantity = quantity;
            _unit = unit;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public float Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public int Unit
        {
            get => _unit;
            set => _unit = value;
        }
    }
}