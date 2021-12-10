using System;

namespace BarberAPI.Models
{
    public class Service
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
    }
}