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
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            // variables need to be declared with data type - string
            string customerName;
            int numWidgets;
            decimal taxRate;

            // Input
            // Read from the textbox into the variable
            customerName = txtCustomerName.Text;

            numWidgets = int.Parse(txtNumWidgets.Text);
            taxRate = decimal.Parse(txtTaxRate.Text);

            //Processing



            //Output


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
