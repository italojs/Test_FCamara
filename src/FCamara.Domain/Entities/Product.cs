using FCamaraProject.Shared.Entities;

namespace FCamaraProject.Domain.Entities
{
    public class Product : Entity
    {
        protected Product() { }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}
