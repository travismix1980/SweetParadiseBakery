namespace SweetParadiseBakery.Models
{
    public class Bakery
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public DateTime FoundingDate { get; set; }
        public decimal BakeryValue { get; set; }
    }
}
