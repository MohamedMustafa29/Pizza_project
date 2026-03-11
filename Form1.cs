using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_project
{
    public partial class PizzaOrder : Form
    {
        public PizzaOrder()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGoldenrodYellow;
          


        }

     


        private void CheckedSize()
        {
            UpdateTotalPrice();
            if (rdoSmall.Checked)
            {
                lblSizeAdded.Text = rdoSmall.Text;
                return;
            }

             if(rdoMedium.Checked)
            {
                lblSizeAdded.Text = rdoMedium.Text;
                return;
            }

             if (rdoLarge.Checked)
            {
                lblSizeAdded.Text = rdoLarge.Text;
                return;
            }

        }

        private void WhereToEat_CheckedChanged()   
        {

            UpdateTotalPrice();
            if (rdoEat.Checked)
            {
                lblWhereAdded.Text = rdoEat.Text;
                return;
            }

             if (rdoTake.Checked)
            {
                lblWhereAdded.Text = rdoTake.Text;
                return;
            }

        }
        private void Crust_CheckedChanged()
        {
            UpdateTotalPrice();
            if (rdoThin.Checked)
            {
                lblCrustAdded.Text = rdoThin.Text;
                return;
            }

             if (rdoThick.Checked)
            {
                lblCrustAdded.Text = rdoThick.Text;
                return;
            }

        }


        float GetSelectedSizePrice()
        {
            if (rdoSmall.Checked)

                return Convert.ToSingle(rdoSmall.Tag);

            else if (rdoMedium.Checked)

                return Convert.ToSingle(rdoMedium.Tag);

            else
                return Convert.ToSingle(rdoLarge.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }


            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            
            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rdoThin.Checked)

                return Convert.ToSingle(rdoThin.Tag);

            else
                return Convert.ToSingle(rdoThick.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {

            lblPriceAdded.Text = CalculateTotalPrice().ToString() + "$";

        }


        private void ToppingsCheckedChanged()
        {
            UpdateTotalPrice();
            string selectedToppings = "";

            if (chkExtraChees.Checked)
                selectedToppings += chkExtraChees.Text + ", ";
            if (chkMushrooms.Checked)
                selectedToppings += chkMushrooms.Text + ", ";
            if (chkTomatoes.Checked)
                selectedToppings += chkTomatoes.Text + ", ";
            if (chkOnion.Checked)
                selectedToppings += chkOnion.Text + ", ";
            if (chkOlives.Checked)
                selectedToppings += chkOlives.Text + ", ";
            if (chkGreenPeppers.Checked)
                selectedToppings += chkGreenPeppers.Text + ", ";

            if (selectedToppings.EndsWith(", "))
            {
                selectedToppings = selectedToppings.TrimEnd(' ', ',');
            }

            lblToppingsOptionAdded.Text = selectedToppings;
        }

    

        

      
            private void ResetForm()
        {
            
            rdoEat.Enabled = true;
            rdoLarge.Enabled = true;
            rdoSmall.Enabled = true;
            rdoMedium.Enabled = true;
            rdoThick.Enabled = true;
            rdoThin.Enabled = true;
            rdoSmall.Checked = true; 


            rdoMedium.Checked = true;


            rdoThin.Checked = true;
            rdoEat.Checked = true;
            



           
            chkExtraChees.Enabled = true;
            chkExtraChees.Checked = false;
            chkMushrooms.Enabled = true;
            chkMushrooms.Checked = false;
            chkTomatoes.Enabled = true;
            chkTomatoes.Checked = false;
            chkOnion.Enabled = true;
            chkOnion.Checked = false;
            chkOlives.Enabled = true;
            chkOlives.Checked = false;
            chkGreenPeppers.Enabled = true;
            chkGreenPeppers.Checked = false;

      

        



        }




        

     

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            ToppingsCheckedChanged();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {

            ToppingsCheckedChanged();

        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            ToppingsCheckedChanged();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            ToppingsCheckedChanged();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)

        {

            ToppingsCheckedChanged();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {

            ToppingsCheckedChanged();
        }


        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSize();
        }

        private void rdoMedium_CheckedChanged(object sender, EventArgs e)
        {
            CheckedSize();
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {

            CheckedSize();
        }

        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            Crust_CheckedChanged();
        }

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            Crust_CheckedChanged();

        }

        private void rdoEat_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat_CheckedChanged();
        }

        private void rdoTake_CheckedChanged(object sender, EventArgs e)
        {
            WhereToEat_CheckedChanged() ;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are You Want To Confirm Order ? ", " Order Confirm ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                chkExtraChees.Enabled = false;
                chkGreenPeppers.Enabled = false;
                chkMushrooms.Enabled = false;
                chkTomatoes.Enabled = false;
                chkOlives.Enabled = false;
                chkOnion.Enabled = false;
                rdoThin.Enabled = false;
                rdoLarge.Enabled = false;
                rdoSmall.Enabled = false;
                rdoMedium.Enabled = false;
                rdoThick.Enabled = false;
                rdoTake.Enabled = false;
                rdoEat.Enabled = false;
            }
            else
            {
                 MessageBox.Show("Order was not confirmed.", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        private void btnResert_Click_1(object sender, EventArgs e)
        {

            ResetForm();
        }
    }
}
