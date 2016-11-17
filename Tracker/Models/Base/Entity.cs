using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker.Models.Base
{
    public class Entity 
    {
        public int Id { get; set; }

        public ObjectState State { get; set; }
    }
}
