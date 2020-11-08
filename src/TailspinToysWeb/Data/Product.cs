using System;

namespace TailspinToysWeb.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Quantity { get; private set; }

        public Product(int id, string title, string description, int quantity)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Quantity = quantity;
        }
    }
}
