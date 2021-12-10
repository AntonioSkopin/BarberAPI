using System;

namespace BarberAPI.Models
{
    public class Client
    {
        public Guid id { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}