using System.Text.Json.Serialization;

namespace Rika_Backoffice.Models;

public class OrderModel
{
    [JsonPropertyName("orderId")]
    public string? OrderID { get; set; }
    [JsonPropertyName("orderDate")]
    public DateTime OrderDate { get; set; }
    [JsonPropertyName("totalAmount")]
    public string? TotalAmount { get; set; }
    [JsonPropertyName("paymnetMehod")]
    public string? PaymnetMethod { get; set; }
    [JsonPropertyName("shipmentMethod")]
    public string? ShipmentMethod { get; set; }
    [JsonPropertyName("orderStatus")]
    public string? OrderStatus { get; set; }
    [JsonPropertyName("orderCustomerId")]
    public string? OrderCustomerId { get; set; }
    [JsonPropertyName("orderCustomer")]
    public OrderCustomer? OrderCustomer { get; set; }
    [JsonPropertyName("orderAddressId")]
    public string? OrderAddressId { get; set; }
    [JsonPropertyName("orderAddress")]
    public OrderAddress? OrderAddress { get; set; }
    [JsonPropertyName("orderProducts")]
    public List<OrderProduct>? OrderProducts { get; set; }
}

public class OrderCustomer
{
    [JsonPropertyName("orderCustomerId")]
    public string? OrderCustomerID { get; set; }
    [JsonPropertyName("customerName")]
    public string? CustomerName { get; set; }
    [JsonPropertyName("customerEmail")]
    public string? CustomerEmail { get; set; }
    [JsonPropertyName("customerPhone")]
    public string? CustomerPhone { get; set; }
}

public class OrderAddress
{
    [JsonPropertyName("orderAddressId")]
    public string? OrderAddressId { get; set; }
    [JsonPropertyName("address")]
    public string? Address { get; set; }
    [JsonPropertyName("city")]
    public string? City { get; set; }
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }
    [JsonPropertyName("country")]
    public string? Country { get; set; }
}

public class OrderProduct
{
    [JsonPropertyName("productId")]
    public string? ProductID { get; set; }
    [JsonPropertyName("productName")]
    public string? ProductName { get; set; }
    [JsonPropertyName("quantity")]
    public string? Quantity { get; set; }
    [JsonPropertyName("unitPrice")]
    public string? UnitPrice { get; set; }
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    [JsonPropertyName("size")]
    public string? Size { get; set; }
    [JsonPropertyName("orderId")]
    public string? OrderId { get; set; }
}
