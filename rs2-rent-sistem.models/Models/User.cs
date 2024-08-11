namespace rs2_rent_sistem.Models.Models
{
    public class User
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public virtual ICollection<Role> Roles { get; } = new List<Role>();
    }
}
