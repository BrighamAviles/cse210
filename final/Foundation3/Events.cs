using System;

namespace EventPlanning
{
    public abstract class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private string time;
        private Address address;

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        public string StandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date.ToString("MM/dd/yyyy")}\nTime: {time}\nAddress: {address.GetFullAddress()}";
        }

        public abstract string FullDetails();

        public string ShortDescription()
        {
            return $"{GetType().Name} - {title} on {date.ToString("MM/dd/yyyy")}";
        }

        public string Title => title;
        public string Description => description;
        public DateTime Date => date;
        public string Time => time;
        public Address Address => address;
    }
}
