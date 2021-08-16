namespace Models
{
    public class Order
    {
        private int orderId;
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        private Product product;
        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        private string size;
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        private int iceQuantity;
        public int IceQuantity
        {
            get { return iceQuantity; }
            set { iceQuantity = value; }
        }

        private string placeToEat;
        public string PlaceToEat
        {
            get { return placeToEat; }
            set { placeToEat = value; }
        }

        private string cupType;
        public string CupType
        {
            get { return cupType; }
            set { cupType = value; }
        }

        private string cupLid;
        public string CupLid
        {
            get { return cupLid; }
            set { cupLid = value; }
        }
    
        public Order() {}

        public Order(int orderId, Product product, string size, int iceQuantity, string placeToEat, string cupType, string cupLid)
        {
            this.orderId = orderId;
            this.product = product;
            this.size = size;
            this.iceQuantity = iceQuantity;
            this.placeToEat = placeToEat;
            this.cupType = cupType;
            this.cupLid = cupLid;
        }
    }
}
