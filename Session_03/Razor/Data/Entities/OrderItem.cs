using System;
namespace Server.Entities{
    public class OrderItem{
        private int id;
        private Cat cat;
        private int quantity;
        private Order order;

        public int Id { get => id; set => id = value; }
        public Cat Cat { get => cat; set => cat = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Order Order { get => order; set => order = value; }
    }
}