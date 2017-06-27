using System;
using TestFCamara.Domain.ValueObjects;
using TestFCamara.Shared.Entities;

namespace TestFCamara.Domain.Entities
{
    public class Customer : Entity
    {
        protected Customer() { }

        public Customer(Name name, User user)
        {
            Name = name;
            User = user;

            AddNotifications(name.Notifications);
        }

        public Name Name { get; private set; }
        public User User { get; private set; }

        public void Update(Name name)
        {
            AddNotifications(name.Notifications);
            Name = name;
        }
    }
}
