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
            this.Close();
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
            // convert an string to an int
            numWidgets = int.Parse(txtNumWidgets.Text);
            //convert a string to a demimal
            taxRate = decimal.Parse(txtTaxRate.Text);

            //Processing            
            subTotal = widgetPrice + numWidgets;
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
