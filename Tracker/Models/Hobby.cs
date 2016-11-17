using Tracker.Models.Base;

namespace Tracker.Models
{
    public class Hobby : Entity
    {
        public string UserName { get; set; }
        public string HobbyName { get; set; }
        public string FunFacts { get; set; }
    }
}
