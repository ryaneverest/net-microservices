namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; }
        public ShoppingCart()
        {
            
        }
        public ShoppingCart(string userName)
        {
            UserName = userName ?? string.Empty;
        }
        public decimal TotalPrice
        {
            get { return Items.Count; }
        }
    }
}
