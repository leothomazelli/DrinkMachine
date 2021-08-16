using Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DrinkMachine
{
    public partial class drinkMachineScreen : Form
    {
        private Order order;
        private IList<Product> products;

        public drinkMachineScreen()
        {
            InitializeComponent();

            products = new List<Product>
            {
                new Product(0, "Coke", Models.Enum.DrinkType.Soda),
                new Product(1, "Guarana", Models.Enum.DrinkType.Soda),
                new Product(2, "Orange Juice", Models.Enum.DrinkType.Juice),
                new Product(3, "Grape Juice", Models.Enum.DrinkType.Juice),
            };
        }

        private void btnNewOrder_Click(object sender, System.EventArgs e)
        {
            order = new Order();
            btnNewOrder.Enabled = false;
            btnReset.Enabled = true;
            ctnPlaceToEat.Enabled = true;
        }

        private void selectPlaceToEat_Click(object sender, System.EventArgs e)
        {
            Button placeToEat = sender as Button;

            order.PlaceToEat = placeToEat.Text;
            order.CupLid = order.PlaceToEat == "Eat In"
                ? "Normal lid"
                : "Travel lid";

            lblPlaceToEatSelected.Text = order.PlaceToEat ?? "None";
            lblCupLidSelected.Text = order.CupLid ?? "None";

            ctnDrinks.Enabled = true;
        }

        private void selectDrink_Click(object sender, System.EventArgs e)
        {
            Button drink = sender as Button;
            order.Product = new Product();

            order.Product = products.FirstOrDefault(product => product.Drink == drink.Text);
            order.CupType = order.Product.DrinkType == Models.Enum.DrinkType.Juice
                ? "Plastic cup"
                : "Paper cup";

            lblDrinkSelected.Text = order.Product?.Drink ?? "None";
            lblCupTypeSelected.Text = order.CupType ?? "None";

            ctnSize.Enabled = true;
            btnSize700ml.Enabled = order.Product.DrinkType == Models.Enum.DrinkType.Juice
                ? false
                : true;
        }

        private void selectSize_Click(object sender, System.EventArgs e)
        {
            Button size = sender as Button;

            order.Size = size.Text;
            lblSizeSelected.Text = order.Size ?? "None";
            ctnAdditional.Enabled = true;
        }

        private void selectIceQuantity_Click(object sender, System.EventArgs e)
        {
            Button iceQuantity = sender as Button;

            if (iceQuantity.Text == "Ice")
            {
                order.IceQuantity = order.Product.DrinkType == Models.Enum.DrinkType.Juice
                    ? 12
                    : 6;
            }
            else
            {
                order.IceQuantity = 0;
            }

            lblIceQuantitySelected.Text = order.IceQuantity.ToString();
        }

        private void btnCompleteOrder_Click(object sender, System.EventArgs e)
        {
            if (order == null)
            {
                MessageBox.Show("Order was not initialized", "Drink Machine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (order.PlaceToEat == null)
            {
                MessageBox.Show(
                    "Place to eat was not defined, please complete your selection in order to continue", 
                    "Drink Machine", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
            else if (order.Product == null)
            {
                MessageBox.Show(
                    "Drink was not selected, please complete your selection in order to continue", 
                    "Drink Machine", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
            else if (order.Size == null)
            {
                MessageBox.Show(
                    "Size was not selected, please complete your selection in order to continue", 
                    "Drink Machine", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
            else if (lblIceQuantitySelected.Text == "None")
            {
                MessageBox.Show(
                    "Additional was not selected, please complete your selection in order to continue", 
                    "Drink Machine", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                cleanOrder();
                MessageBox.Show(
                    "Your order was completed succesfully", 
                    "Drink Machine", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Exclamation
                );
            }
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            order = null;
            cleanOrder();
        }

        private void cleanOrder()
        {
            order = null;
            lblPlaceToEatSelected.Text = "None";
            lblCupLidSelected.Text = "None";
            lblDrinkSelected.Text = "None";
            lblCupTypeSelected.Text = "None";
            lblSizeSelected.Text = "None";
            lblIceQuantitySelected.Text = "None";

            ctnPlaceToEat.Enabled = false;
            ctnDrinks.Enabled = false;
            ctnSize.Enabled = false;
            ctnAdditional.Enabled = false;
            btnReset.Enabled = false;
            btnNewOrder.Enabled = true;
        }
    }
}
