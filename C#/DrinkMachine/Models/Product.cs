using Models.Enum;

namespace Models
{
    public class Product
    {
        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private string drink;
        public string Drink 
        {
            get { return drink; }
            set { drink = value; } 
        }

        private DrinkType drinkType;
        public DrinkType DrinkType
        {
            get { return drinkType; }
            set { drinkType = value; } 
        }

        public Product() { }

        public Product(int productId, string drink, DrinkType drinkType)
        {
            this.productId = productId;
            this.drink = drink;
            this.drinkType = drinkType;
        }
    }
}
