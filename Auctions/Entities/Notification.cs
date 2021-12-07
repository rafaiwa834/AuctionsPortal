using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int senderId { get; set; }
        public int recipientId { get; set; }
        public string message { get; set; }
        public string title { get; set; }
        public int groupId { get; set; } //z tego moze nie bede korzystal, po tytule sprobujemy grupowac
        public DateTime postDate { get; set; }
        public bool active { get; set; }
    }
}
