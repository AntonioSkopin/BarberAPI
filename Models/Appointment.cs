using System;

namespace BarberAPI.Models
{
    public class Appointment
    {
        public Guid id { get; set; }
        public DateTime dateTime { get; set; }
        public Guid serviceId { get; set; }
        public Guid clientId { get; set; }
    }
}