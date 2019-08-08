using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    class Department
    {
        public String Name { get; set; }

        public Department()
        {

        }

        public Department(String name)
        {
            Name = name;
        }
    }
}
