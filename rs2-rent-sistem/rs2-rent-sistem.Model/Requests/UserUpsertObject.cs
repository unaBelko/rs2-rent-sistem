namespace rs2_rent_sistem.Model.Requests
{
    public class UserUpsertObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string PlatformType { get; set; }
    }
}
