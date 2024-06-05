namespace AgriEnergy.Models.Entities
{
    public class Farmer
    {
        public Guid FarmerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FarmName { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public int ProductID { get; set; }


    }
}
