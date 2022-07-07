using System;
using System.Collections;

namespace Bulofnaia.API.Entities
{
    public class Request
    {
        private int _id;
        private string _name;
        private DateTime _limitDate;

        private Hashtable _resourceToQuantity;
        private Hashtable _resourceToOptimalBatchSize;
        private Hashtable _resourceToOptimalBatchInterval;

        public Request()
        {
            _resourceToQuantity = new Hashtable();
            _resourceToOptimalBatchSize = new Hashtable();
            _resourceToOptimalBatchInterval = new Hashtable();
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
            get => _resourceToQuantity;
            set => _resourceToQuantity = value;
        }

        public Hashtable ResourceToOptimalBatchSize
        {
            get => _resourceToOptimalBatchSize;
            set => _resourceToOptimalBatchSize = value;
        }

        public Hashtable ResourceToOptimalBatchInterval
        {
            get => _resourceToOptimalBatchInterval;
            set => _resourceToOptimalBatchInterval = value;
        }

        public override string ToString()
        {
            string result = "Request: {id = " + _id + " name = " + _name + " limitDate = " + _limitDate + " resourcesUnmet = [" ;
            foreach (DictionaryEntry entry in _resourceToQuantity)
            {
                result += $"({entry.Key},{entry.Value})";
            }

            result += "]";
            result += "}";

            return result;
        }
    }
}