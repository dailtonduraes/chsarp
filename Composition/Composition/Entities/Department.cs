using System;

namespace Composition.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {

        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
