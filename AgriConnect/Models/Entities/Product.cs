namespace AgriEnergy.Models.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ProductionDate { get; set; }
    }
}
