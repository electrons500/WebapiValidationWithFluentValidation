namespace Webapi_Validation_With_FluentValidation.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Surname { get; set; }
        public string? Forename { get; set; }
        public decimal Discount { get; set; }
        public Address Addresses { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }

    public class Address
    {   
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
    }

    public class Order
    {
        public double Total { get; set; }
    }
}
