namespace BlazorGQL.Model
{
    /// <summary>
    /// Viewmodel representing a product
    /// </summary>
    public class ProductModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Stock { get; set; }

    }
}
