using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Programming
{
    abstract class Publication
    {
        // Classes have member variables/fields to hold data
        private string _name;
        private int _pagecount;
        private decimal _price;

        // Constructor
        public Publication(string name, decimal price, int pages)
        {
            Name = name;
            Pagecount = pages;
            Price = price;
        }

        // Use properties to implement access to internal data
        // This is called a property with a "backing field"
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // You can use the => property as a shorthand for this
        // This is known as an expression body property
        // The setter can be omitted for read-only
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public int Pagecount
        {
            get => _pagecount;
            set => _pagecount = value;
        }

        // Virtual keyword can be used to indicate a method to be overridden
        virtual public string Description
        {
            get => $"Name: {Name}, Price: {Price}, Pages {Pagecount}";
        }
    }
}
