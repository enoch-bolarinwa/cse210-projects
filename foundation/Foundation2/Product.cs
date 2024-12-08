public class Product
    {
        private string name;
        private string productId;
        private decimal pricePerUnit;
        private int quantity;

        public Product(string name, string productId, decimal pricePerUnit, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.pricePerUnit = pricePerUnit;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public string GetProductId()
        {
            return productId;
        }

        public decimal GetTotalCost()
        {
            return pricePerUnit * quantity;
        }
    }