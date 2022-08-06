using System;

namespace TalkingHeads.Models
{
    public class Concert
    {
        public int ConcertId { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
    }
}