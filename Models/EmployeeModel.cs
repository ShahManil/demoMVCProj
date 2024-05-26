namespace demoMVCProj.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

    }
    public enum Gender
    {
        Male, Female, Other
    }
}
