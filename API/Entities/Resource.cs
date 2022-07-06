using System;

namespace Bulofnaia.API.Entities
{
    public class Resource
    {
        private int _id;
        private string _name;

        private float _batchCost;
        private float _storageCost;

        private int _unit;
        private string _unitName;

        public Resource()
        {
        }
        public Resource(string name, float quantity, int unit)
        {
            _name = name;
            _unit = unit;
        }
        public Resource(int id, string name, float quantity, int unit)
        {
            _id = id;
            _name = name;
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
        
        public float BatchCost
        {
            get => _batchCost;
            set => _batchCost = value;
        }

        public float StorageCost
        {
            get => _storageCost;
            set => _storageCost = value;
        }

        public int Unit
        {
            get => _unit;
            set => _unit = value;
        }

        public string UnitName
        {
            get => _unitName;
            set => _unitName = value;
        }

        public override string ToString()
        {
            string result = "Resource: {id = " + _id + ", name = " + _name + ", unit = " +
                            _unit + "}";
            return result;
        }
    }
}