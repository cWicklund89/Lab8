using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{

    struct DrinkEntry
    {
        public string name;
        public string cost;
        public int numDrink;
    }

    enum Soda
    {
        Cola,
        Rootbeer,
        LemonLime,
        Grape,
        Cream
    }

    public partial class VendingForm : Form
    {

        double total = 0.00;
        List<DrinkEntry> drinks = new List<DrinkEntry>
    {
        new DrinkEntry { name = "Cola", cost = "1.00", numDrink = 20},
        new DrinkEntry { name = "Root Beer", cost = "1.00", numDrink = 20},
        new DrinkEntry { name = "Lemon Lime", cost = "1.00", numDrink = 20},
        new DrinkEntry { name = "Grape Soda", cost = "1.50", numDrink = 20},
        new DrinkEntry { name = "Cream Soda", cost = "1.50", numDrink = 20}
    };

        public VendingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will cause the vending machine form to close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Updates the Vending Machine Inventory level and total sales
        /// </summary>
        /// <param name="soda">The Soda that is being remvoed from the vending machine</param>
        private void updateDrinkCount(Soda soda)
        {
            double cost = 0;
            var entry = drinks[(int)soda];
            if (entry.numDrink == 0)
            {
                MessageBox.Show(entry.name + " sold out.");
            }
            else
            {
                entry.numDrink--;
                drinks[(int)soda] = entry;
                cost = double.Parse(entry.cost);
                switch (soda)
                {
                    case Soda.Cola:
                        colaLabel.Text = entry.numDrink.ToString();
                        break;
                    case Soda.Rootbeer:
                        rootBeerLabel.Text = entry.numDrink.ToString();
                        break;
                    case Soda.LemonLime:
                        lemonLimeLabel.Text = entry.numDrink.ToString();
                        break;
                    case Soda.Grape:
                        grapeLabel.Text = entry.numDrink.ToString();
                        break;
                    case Soda.Cream:
                        creamLabel.Text = entry.numDrink.ToString();
                        break;
                }
                total += cost;
                totalSalesLabel.Text = total.ToString("C");
            }
        }

        private void cola_Click(object sender, EventArgs e)
        {
            updateDrinkCount(Soda.Cola);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            updateDrinkCount(Soda.Rootbeer);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            updateDrinkCount(Soda.LemonLime);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            updateDrinkCount(Soda.Grape);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            updateDrinkCount(Soda.Cream);
        }
    }
}
