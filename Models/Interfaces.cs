using System;

namespace shop.Models
{
  public interface IEmailSender
  {
      void SendMessage(string receiver, string title, string message);
  }

    public class EmailSender : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        User GetUser(string email);
        Order GetOrder(int id);
        void SaveChanges();
    }

    public class Database : IDatabase
    {
        public bool IsConnected => throw new NotImplementedException();

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public interface IOrderProcessor
    {
        void ProcessOrder(string email, int orderId);
    }

    public class OrderProcessor : IOrderProcessor
    {
        private readonly IDatabase _database;
        private readonly IEmailSender _emailSender;
        public OrderProcessor(IDatabase database, IEmailSender emailSender)
        {
            _database = database;
            _emailSender = emailSender;
        }
        public void ProcessOrder(string email, int orderId)
        {
           User user = _database.GetUser(email); //fetch from db
           Order order = _database.GetOrder(orderId); //Fetch from db
           user.PurchaseOrder(order);
           _database.SaveChanges();
           _emailSender.SendMessage(email,"Order purchased","You have purchased an order.");
        }
    }

    public class shop
    {
        public void CompleteOrder()
        {
            IOrderProcessor OrderProcessor = new OrderProcessor(database, emailSender);
        }
        IDatabase database = new Database();
        IEmailSender emailSender = new EmailSender();
    }
}