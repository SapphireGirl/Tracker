using System.Data.Entity;

namespace Tracker.Models.Base
{
    // the objects passed back into the API or service will have their state defined.
    //to leverage that client-side state in the server-side code.
    // Once attached to a context, the context will need to read the state of each object.

    public interface IObjectWithState
    {
        ObjectState State { get; set; }
    }

    public class ObjectWithState : IObjectWithState
    {
        public ObjectState State { get; set; } = ObjectState.Unchanged;

        // This ConvertState method will take an 
        // ObjectState enum and return the matching EntityState enum:

        public static EntityState ConvertState(ObjectState state)
        {
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;
                case ObjectState.Modified:
                    return EntityState.Modified;
                case ObjectState.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

    }
    public enum ObjectState
    {
        Unchanged,
        Added,
        Modified,
        Deleted
    }

    // This ConvertState method will take an 
    // ObjectState enum and return the matching EntityState enum:

}
