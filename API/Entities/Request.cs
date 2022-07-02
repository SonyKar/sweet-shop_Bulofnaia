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

        public Request()
        {
            _resourcesToQuantity = new Hashtable();
        }
        public Request(string name, DateTime limitDate)
        {
            _resourcesToQuantity = new Hashtable();
            this._name = name;
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

        public override string ToString()
        {
            return "id = " + _id + " name = " + _name + " limitDate = " + _limitDate;
        }
    }
}