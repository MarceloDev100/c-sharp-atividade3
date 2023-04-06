using Course.Entities.Enums;
using System.Text;
using System.Globalization;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus status, Client client) : this()
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}")
              .AppendLine($"Status: {Status.ToString()}")
              .AppendLine($"Client: {Client}")
              .AppendLine($"Order items: ");

            foreach (OrderItem item in Items)
            {
                sb.Append(item.ToString());
            }

            sb.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}