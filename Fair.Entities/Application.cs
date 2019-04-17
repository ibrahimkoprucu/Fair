using System.Collections.Generic;

namespace Fair.Entities
{
    public class Application
    {
        public Application()
        {
            Employees = new List<Employee>();
        }

        public string Topic { get; set; }
        public SizeOfStand SizeOfStand { get; set; }
        public List<Employee> Employees { get; set; }
    }
}