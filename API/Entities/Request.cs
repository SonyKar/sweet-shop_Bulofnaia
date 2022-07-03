using System;
using System.Collections;

namespace Bulofnaia.API.Entities
{
    public class Request
    {
        private int _id;
        private string _name;
        private DateTime _limitDate;
        private Hashtable _resourcesToQuantity;
        private Hashtable _resourcesUnmet;
        private ArrayList _resources;

        public Request()
        {
            _resourcesUnmet = new Hashtable();
            _resourcesToQuantity = new Hashtable();
            _resources = new ArrayList();
        }
        public Request(string name, DateTime limitDate) : this()
        {
            _name = name;
            _limitDate = limitDate;
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

        public DateTime LimitDate
        {
            get => _limitDate;
            set => _limitDate = value;
        }

        public String DateMySQL
        {
            get => _limitDate.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public Hashtable ResourceToQuantity
        {
            get => _resourcesToQuantity;
            set => _resourcesToQuantity = value;
        }

        public Hashtable UnmetRequirements
        {
            get => _resourcesUnmet;
            set => _resourcesUnmet = value;
        }

        public ArrayList Resources
        {
            get => _resources;
            set => _resources = value;
        }

        public override string ToString()
        {
            string result = "Request: {id = " + _id + " name = " + _name + " limitDate = " + _limitDate + " resourcesUnmet = [" ;
            foreach (DictionaryEntry entry in _resourcesUnmet)
            {
                result += $"({entry.Key},{entry.Value})";
            }

            result += "]";
            result += "}";

            return result;
        }
    }
}