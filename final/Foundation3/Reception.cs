namespace EventPlanning
{
    public class Reception : Event
    {
        private string rsvpEmail;

        public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
            : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
        }

        public string RsvpEmail => rsvpEmail;
    }
}
