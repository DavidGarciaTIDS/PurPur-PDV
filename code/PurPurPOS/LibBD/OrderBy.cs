namespace LibBD
{
    public class OrderBy
    {
        public OrderBy(string name, Order orderCriteria)
        {
            Name = name;
            OrderCriteria = orderCriteria;
        }

        public string Name { get; set; }
        public Order OrderCriteria { get; set; }
    }
}