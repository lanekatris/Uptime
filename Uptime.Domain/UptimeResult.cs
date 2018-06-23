using System;

namespace Uptime.Domain
{
    public class UptimeResult
    {
        public decimal Seconds { get; set; }
        public decimal Minutes { get; set; }
        public decimal Hours { get; set; }
        public decimal Days { get; set; }
    }
}