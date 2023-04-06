using System.Globalization;
using System.Text;

namespace Course.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Price = Product.Price;
            Quantity = quantity;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Product.Name}, ${Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {Quantity}, SubTotal: {SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
