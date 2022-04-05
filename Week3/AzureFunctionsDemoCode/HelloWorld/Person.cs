using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PartitionKey => Id.ToString();
        public string RowKey => Name;

        public string Description { get; set; }
    }
}
