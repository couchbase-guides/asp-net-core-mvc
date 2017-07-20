namespace aspnetcorestarter.Models
{
    // tag::class[]
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type => "Profile";
    }
    // end::class[]
}
