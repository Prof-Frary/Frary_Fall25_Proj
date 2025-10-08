namespace Frary_Fall25_Proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult buttonSelected = MessageBox.Show(
                "Are you sure you want quit?",
                 "Quitting....",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);
            if (buttonSelected == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtNumWidgets.Clear();
            lstOut.Items.Clear();
            txtCustomerName.Focus();
            txtTaxRate.Clear();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            // variables need to be declared with data type - string
            string customerName;
            int numWidgets;
            decimal taxRate;
            // when setting a decomal literal use M
            // to indiate it is a decimal and not a double
            decimal widgetPrice = 25.0M;
            decimal subTotal, total, amtTax;
            // Input
            // Read from the textbox into the variable
            customerName = txtCustomerName.Text;
            bool widgetsWorked, rateValid;
            // convert an string to an int
            //  numWidgets = int.Parse(txtNumWidgets.Text);

            //convert a string to a demimal
            // since we want the user to enter as a percent we will need to divide by 100
            // to get it in the correct format to use mathematically 
           // taxRate = decimal.Parse(txtTaxRate.Text) / 100.0M;
            // Change Parse to TryParse 
            // 1 - Change method name from Parse to TryParse
            // 2 - Move Variable to be second Parameter and add out
            // 3 - add boolean vairable on left side of =
            widgetsWorked  = int.TryParse(txtNumWidgets.Text, out numWidgets);
            rateValid = decimal.TryParse(txtTaxRate.Text, out taxRate);

            if (widgetsWorked && rateValid)
            {
                // regular Processing
                taxRate = taxRate / 100.0M;

                //Processing            
                subTotal = widgetPrice * numWidgets;
                amtTax = subTotal * taxRate;
                total = subTotal + amtTax;

                //Output - every variable
                lstOut.Items.Add("Customer Name: " + customerName);
                lstOut.Items.Add("Widget Price: " + widgetPrice.ToString("C"));
                lstOut.Items.Add("Number of Widgets Ordered: " + numWidgets.ToString("N0"));
                lstOut.Items.Add("Tax Rate: " + taxRate.ToString("P"));
                lstOut.Items.Add("Subtotal: " + subTotal.ToString("C"));
                lstOut.Items.Add("Amount of Tax: " + amtTax.ToString("C"));
                lstOut.Items.Add("Total: " + total.ToString("C"));
                //  lstOut.Items.Add(5 / 3)
                //lstOut.Items.Add(Math.Sqrt(16));

                // this makes the reset button the active control (reset is given the focus)
                btnReset.Focus();
            } else
            {
               // lstOut.Items.Add("Input error");
                if (!widgetsWorked)
                {
                    lstOut.Items.Add("Number of Widgets is not a whole number");
                } 
                if(!rateValid) 
                {
                    lstOut.Items.Add("Tax Rate is not a number");
                }
                
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.Beige;
        }

        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = SystemColors.Window;
        }

    }
}
