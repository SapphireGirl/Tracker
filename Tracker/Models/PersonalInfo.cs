
using Tracker.Models.Base;

namespace Tracker.Models
{
    public class PersonalInfo : Entity
    {
        public string Bio { get; set; }
        public string PoliticalAffiliation { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
       

        //Concurrency Token
        public int SocialSecurityNumber { get; set; }

        public PersonalInfo()
        {
            
        }
    }

    //public enum PoliticalAffiliation
    //{
    //    Republican, Democrat, Independent
    //}
}
