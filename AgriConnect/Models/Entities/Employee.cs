namespace AgriEnergy.Models.Entities
{
    public class Employee
    {
        public Guid EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public int FarmerID { get; set; }
    }
}
