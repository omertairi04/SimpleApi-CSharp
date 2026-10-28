
public class Customer
{
    public int CustomerID { get; set; }
    public required string CustomerName { get; set; }
    public required string ContactName { get; set; }
    public string Address { get; set; } = "";
    public required string City { get; set; }
    public int PostalCode { get; set; } = 0;
    public string Country { get; set; } = "";
}