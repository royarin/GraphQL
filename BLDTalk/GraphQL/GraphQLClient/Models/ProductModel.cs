namespace BlazorGQL.Model
{
    /// <summary>
    /// Viewmodel representing a product
    /// </summary>
    public class ProductModel
    {
        private int _quantity;
        public string Name { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public string Image { get; set; }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value;
                TotalPrice = _quantity * Price;
            }
        }
        public int Stock { get; set; }

    }
}
