namespace PaymentDemo.Models
{
    public class OrderInformation
    {
        public int OrderId { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }
    }
}
