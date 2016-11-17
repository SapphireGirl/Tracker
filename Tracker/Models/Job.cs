using System;
using Tracker.Models.Base;

namespace Tracker.Models
{
    public class Job : Entity
    {
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Company { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateEnded { get; set; }
        public string Supervisor { get; set; }
        public string JobDescription { get; set; }

    }
}