using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class GoogleMap
    {
        public int Id { get; set; }
        public int? Rating { get; set; }
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
