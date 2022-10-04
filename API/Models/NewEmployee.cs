namespace API.Models
{
    public class NewEmployee
    {
        public string Name { get; set; } = String.Empty;
        public int Salary { get; set; } = 0;
        public string Department { get; set; } = String.Empty;
        public string Position { get; set; } = String.Empty;
    }
}
