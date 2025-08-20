namespace HarashiPass.Models
{
    public class StaffApplication
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string RoleAppliedFor { get; set; } = null!;
        public int ConventionId { get; set; }
        public Convention Convention { get; set; } = null!;
    }
}
