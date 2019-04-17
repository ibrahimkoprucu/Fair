namespace Fair.Entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Age, Gender);
        }
    }
}