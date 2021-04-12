namespace BlazorGQL.Model
{
    /// <summary>
    /// Viewmodel representing an order
    /// </summary>
    public class OrderModel
    {
        public int OrderNumber { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryPostCode { get; set; }
        public string DeliveryCountry { get; set; }
       
    }
}
