using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PizzaProject
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        private float SizePrice()
        {
            if (rbSmallSize.Checked)
                return Convert.ToSingle(rbSmallSize.Tag);

            if (rbMediumSize.Checked)
                return Convert.ToSingle(rbMediumSize.Tag);

            if (rbLargeSize.Checked)
                return Convert.ToSingle(rbLargeSize.Tag);

            return 0;
        }

        private float CrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            if (rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);

            return 0;
        }

        private float ToppingsPrice()
        {
            float totalprice = 0;

            foreach (Control c in gbToppings.Controls)
            {
                if (c is CheckBox chk)
                {
                    if (chk.Checked)
                        totalprice += Convert.ToSingle(chk.Tag);
                }
            }

            return totalprice;
        }

        private float CalculateTotalPrice()
        {
            return SizePrice() + CrustPrice() + ToppingsPrice();
        }

        private void UpdateTotalPrice()
        {
            lblTotalPriceOrderSummary.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmallSize.Checked)
            {
                lblSizeOrderSummary.Text = rbSmallSize.Text;
                return;
            }

            if (rbMediumSize.Checked)
            {
                lblSizeOrderSummary.Text = rbMediumSize.Text;
                return;
            }

            if (rbLargeSize.Checked)
            {
                lblSizeOrderSummary.Text = rbLargeSize.Text;
                return;
            }
        }

        private void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustTypeOrderSummary.Text = rbThinCrust.Text;
                return;
            }

            if (rbThickCrust.Checked)
            {
                lblCrustTypeOrderSummary.Text = rbThickCrust.Text;
                return;
            }
        }



        private void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheeseTopping.Checked)
            {
                sToppings += "Extra Cheese";
            }
            if (chkMashroomsTopping.Checked)
            {
                sToppings += ", Mashrooms";
            }
            if (chkTomatoesTopping.Checked)
            {
                sToppings += ", Tomatoes";
            }
            if (chkOnionTopping.Checked)
            {
                sToppings += ", Onions";
            }
            if (chkOlivesTopping.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkGreenPeppersTopping.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings == "")
            {
                lblToppingsOrderSummary.Text = "No toppings";
                return;
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Remove(0, 1).Trim();
            }
            lblToppingsOrderSummary.Text = sToppings;
        }

        private void UpdateServiceType()
        {
            if (rbEatInServiceType.Checked)
            {
                lblServiceTypeOrderSummary.Text = rbEatInServiceType.Text;
                return;
            }

            if (rbTakeOutServiceType.Checked)
            {
                lblServiceTypeOrderSummary.Text = rbTakeOutServiceType.Text;
                return;
            }
        }

        private void UnableControls()
        {
            MessageBox.Show("the selection are unable until reset form. thanks for order <3", "Pizza Ordered");

            gbPizzaSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbToppings.Enabled = false;
            gbServiceType.Enabled = false;
            btnOrderPizza.Enabled = false;

        }

        private void ResetControls()
        {
            gbPizzaSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbServiceType.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbMediumSize.Checked = true;
            rbThinCrust.Checked = true;
            rbTakeOutServiceType.Checked = true;

            foreach (CheckBox chk in gbToppings.Controls)
            {
                chk.Checked = false;
            }
        }


        private void rbSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraCheeseTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMashroomsTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoesTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnionTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlivesTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppersTopping_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatInServiceType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServiceType();
        }

        private void rbTakeOutServiceType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateServiceType();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            DialogResult selectButton = MessageBox.Show("do you want order pizza ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (selectButton == DialogResult.OK)
            {
                UnableControls();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void frmPizza_Load(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateServiceType();
        }
    }
}
