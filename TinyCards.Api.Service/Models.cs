using System.Collections.Generic;

namespace TinyCards.Api.Service
{
    public class User
    {
        public int Id { get; set; }

        public int CreationDate { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public List<object> NewCourseImports { get; set; }
        public string Picture { get; set; }
        public bool Subscribed { get; set; }
        public int SubscriberCount { get; set; }
        public int SubscriptionCount { get; set; }
        public string Username { get; set; }
    }
}