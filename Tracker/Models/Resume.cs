using System.Linq;
using Tracker.Models.Base;

namespace Tracker.Models
{
    public class Resume : Entity
    {
        public int ResumeId { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual IQueryable<Job> Jobs { get; set; }
        public virtual IQueryable<Skillset> Skills { get; set; }
        public virtual IQueryable<Hobby> Hobbies { get; set; }
        //public virtual IQueryable<Recruiter> Recruiters { get; set; }
        //public virtual IQueryable<StaffingCompany> StaffingCompanies { get; set; }



    }
}
