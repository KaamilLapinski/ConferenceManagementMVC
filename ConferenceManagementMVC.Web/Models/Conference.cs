using ConferenceManagementMVC.Web.Models.Enums;
using System;
using System.Drawing.Printing;

namespace ConferenceManagementMVC.Web.Models
{
    public class Conference
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PapersLimit { get; set; }
        public DateTime data { get; set; }
        public string place { get; set; }
        public double AverageGrade { get; set; }
        public Status Status { get; set; }
        public User Chairman { get; set; }

        public Paper[] papers;

        public Conference()
        {
            papers = new Paper[PapersLimit];
        }
    }
}
