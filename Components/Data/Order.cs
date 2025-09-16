namespace BlazorApp1.Components.Data
{

    public class Order
    {
        public double Price { get; set; }
        public string? FullName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? State { get; set; }
        public string? Zipcode { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShippingComments { get; set; }
        public List<OrderLine>? OrderLines { get; set; }
    }
    public class OrderLine
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Boolean Unsalted { get; set; }
        public double TotalPrice { get; set; }
        public string? SpecialCare { get; set; }
    }
    public class SelectListItem
    {
        public int id { get; set; }
        public string? value { get; set; }
    }
}
