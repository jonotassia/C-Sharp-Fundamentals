using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Object_Oriented_Programming
{
    class Book : Publication
    {
        // Classes have member variables/fields to hold data
        private string _author;

        // Constructor
        public Book(string name, decimal price, int pages, string author)
        : base(name, price, pages) {
            _author = author;
        }


        // Override parent class
        public override string Description {
            get => $"Name: {Name}, Author: {Author}, Pages: {Pagecount}";
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        // Auto-generated properties - if there is no backing field
        // the property can hold the data instead
        // It handles the getter and setter itself
        public string ISBN
        {
            get; set;
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Name: {Name}, Author: {Author}, Pages: {Pagecount}";
        }

        // You can also overload the function, but it does not require the override
        // keyword because the signatures are different
        public string ToString(char format)
        {
            if (format == 'B')
            {
                return $"Book: {Name}:{Author}";
            }
            else
            {
                return $"Name: {Name}, Author: {Author}, Pages: {Pagecount}";
            }
        }
    }
}
