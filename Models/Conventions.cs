using System.Net.Sockets;

namespace HarashiPass.Models
{
    public class Convention
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; } = null!;

        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
        public ICollection<StaffApplication> StaffApplications { get; set; } = new List<StaffApplication>();
    }
}
