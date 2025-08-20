namespace HarashiPass.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string TicketType { get; set; } = null!;
        public decimal Price { get; set; }
        public int ConventionId { get; set; }
        public Convention Convention { get; set; } = null!;
    }
}
