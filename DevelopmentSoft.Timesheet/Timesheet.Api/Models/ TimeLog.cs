using System;

namespace Timesheet.Api.Models
{
    public class TimeLog
    {
        public DateTime Date { get; set; }
        public int WorkingTime { get; set; }
        public string LastName { get; set; }
    }
}