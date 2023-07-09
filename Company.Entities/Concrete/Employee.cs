using Company.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Entities.Concrete
{
    public class Employee : IEntity
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WorkPosition { get; set; }
        public string Gender { get; set; }
    }
}
