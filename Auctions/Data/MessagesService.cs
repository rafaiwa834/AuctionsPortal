using BlazorApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class MessagesService
    {
        public AuctionsDbContext _dbContext { get; set; }
        public Notification newMessage = new Notification();
        public List<Notification> messages = new List<Notification>();
        public User user = new User();

        public MessagesService(AuctionsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AskAboutProduct(int senderId, int recipientId, int auctionId)
        {
            newMessage.senderId = senderId;
            newMessage.recipientId = recipientId;
            newMessage.postDate = DateTime.Now;
            newMessage.active = true;
            var auctionName = _dbContext
                            .Auctions
                            .Where(p => p.Id == auctionId)
                            .Select(p=>p.Title)
                            .FirstOrDefault();
            var senderFullName = _dbContext
                                .Users
                                .Where(p => p.Id == senderId)
                                .Select(p => new { p.FirstName, p.LastName })
                                .FirstOrDefault();


            newMessage.title = $"Użytkonik {senderFullName.FirstName} {senderFullName.LastName} wysłał zapytanie " +
                $"o przedmiot: {auctionName}";

            _dbContext.Notifications.Add(newMessage);
            _dbContext.SaveChanges();

            newMessage = new Notification();
        }

        public void GetMessages(int userId)
        {
            messages = _dbContext
                       .Notifications
                       .Where(p => (p.recipientId == userId || p.senderId == userId) && p.postDate  == (_dbContext.Notifications.Where(e=>(e.recipientId == userId || e.senderId == userId) && e.title == p.title)
                                                                                .Select(j =>j.postDate).Max()))
                       .ToList();

        }

        public void GetConversation(int id, int userId)
        {
            messages = _dbContext
                     .Notifications
                     .Where(p=>p.title == (_dbContext.Notifications.Where(e=>e.Id == id).Select(e=>e.title).FirstOrDefault()))
                     .OrderBy(p=>p.postDate)
                     .ToList();

            if(messages[0].senderId == userId )
            {
                user = _dbContext.Users.Where(p => p.Id == messages[0].recipientId).FirstOrDefault();
            }
            else
            {
                user = _dbContext.Users.Where(p => p.Id == messages[0].senderId).FirstOrDefault();
            }
        }

        public void SendMessage(int senderId, string message)
        {
            var reply = new Notification()
            { senderId = senderId,
                recipientId = user.Id,
                message = message,
                active = true,
                postDate = DateTime.Now,
                title = messages[0].title,
                groupId = 0
             };

            _dbContext.Notifications.Add(reply);
            _dbContext.SaveChanges();
        }
    }
}
