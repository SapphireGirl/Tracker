using System;

namespace Tracker.Models.Base
{
        public class User : Entity, IObservable<User> // ,Identity
        {
           // public virtual int UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName
            {
                get { return string.Format("{0} {1}", FirstName, LastName).Trim(); }
            }
            public DateTime DateCreated { get; set; }
            public Address UserAddress { get; set; }
            public PersonalInfo Info { get; set; }
            public User()
            {
                //   DateCreated = DateTime.Now;
                UserAddress = new Address();
                Info = new PersonalInfo();
            }

            public IDisposable Subscribe(IObserver<User> observer)
            {
                throw new NotImplementedException();
            }
        }
}