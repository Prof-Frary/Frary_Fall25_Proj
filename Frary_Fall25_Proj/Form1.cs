using System.Numerics;

namespace Frary_Fall25_Proj
{

    //ICA 7 
    // add variables for each item that will be saved in your file
    // add open file dialog from tool box to designer
    // add file to bin/debug/net8...
    // add form1 code
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ICA 8 - Properties
        // we will create properties for each variable we saved in the file 
        // we will not use automatic properties here

        public decimal RegularPrice
        {
            get { return regularPrice; }
            set { 
                if (value >= 0)
                {
                    regularPrice = value;
                }
            }
        }
        public decimal EconomyPrice
        {
            get { return economyPrice; }
            set {
                if (value >= 0)
                {
                    economyPrice = value;
                }
            }
        }
        public decimal DeluxePrice
        {
            get { return deluxePrice; }
            set
            {
                if (value >= 0)
                {
                    deluxePrice = value;
                }
            }
        }


        // theses are the class level variables

        const string ECONOMY_MODEL = "Economy Model";
        const string REGULAR_MODEL = "Regular Model";
        const string DELUXE_MODEL = "Deluxe Model";
        private string widgetType = REGULAR_MODEL;
        // ica 6
        string widgetTransLog = "widgetTransactionlog.txt";
        // ica 7
        string widgetConfig = "widgetConfig1.txt";        
        decimal regularPrice, economyPrice, deluxePrice;

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
            rdoRegular.Checked = true;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            // variables need to be declared with data type - string
            string customerName;
            int numWidgets;
            decimal taxRate;
            // when setting a decomal literal use M
            // to indiate it is a decimal and not a double
            decimal widgetPrice = 0.0M;
            decimal subTotal, total, amtTax;
            bool widgetsWorked, rateValid;

            //ICA 6
         
            StreamWriter sw;


            // Input
            // Read from the textbox into the variable
            customerName = txtCustomerName.Text;
         
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
            widgetsWorked = int.TryParse(txtNumWidgets.Text, out numWidgets);
            rateValid = decimal.TryParse(txtTaxRate.Text, out taxRate);
            
            if (widgetsWorked && rateValid)
            {
                // regular Processing
                taxRate = taxRate / 100.0M;
                // get widget price based on model
                switch (widgetType)
                {
                    // changed fro ICA 7
                    case REGULAR_MODEL:
                        widgetPrice = RegularPrice;
                        break;
                    case ECONOMY_MODEL:
                        widgetPrice = EconomyPrice;
                        break;
                    case DELUXE_MODEL:
                        widgetPrice = DeluxePrice;
                        break;
                    default:
                        lstOut.Items.Add("Error in switch - This should never happen");
                        break;
                }// end of switch

                //Processing            
                subTotal = widgetPrice * numWidgets;
                amtTax = subTotal * taxRate;
                total = subTotal + amtTax;
                /*
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


                //ica 6
                sw = File.AppendText(widgetTransLog);
                sw.WriteLine("*********** Tranaction starts at: " + DateTime.Now + " ********"); 
                sw.WriteLine("Customer Name: " + customerName);
                sw.WriteLine("Widget Price: " + widgetPrice.ToString("C"));
                sw.WriteLine("Number of Widgets Ordered: " + numWidgets.ToString("N0"));
                sw.WriteLine("Tax Rate: " + taxRate.ToString("P"));
                sw.WriteLine("Subtotal: " + subTotal.ToString("C"));
                sw.WriteLine("Amount of Tax: " + amtTax.ToString("C"));
                sw.WriteLine("Total: " + total.ToString("C"));

                sw.Close();

                */

                outputMsg("*********** Transaction starts at: " + DateTime.Now + " ********",LOGFILE);

                outputMsg("Customer Name: " + customerName,BOTH);
                outputMsg("Widget Price: " + widgetPrice.ToString("C"), BOTH);
                outputMsg("Number of Widgets Ordered: " + numWidgets.ToString("N0"), BOTH);
                outputMsg("Tax Rate: " + taxRate.ToString("P"), BOTH);
                outputMsg("Subtotal: " + subTotal.ToString("C"), BOTH);
                outputMsg("Amount of Tax: " + amtTax.ToString("C"), BOTH);
                outputMsg("Total: " + total.ToString("C"), BOTH);

                /* example of different ways to display date  - uncomment to see the 
                 * differences
                lstOut.Items.Add(DateTime.Now.ToString("D"));
                lstOut.Items.Add(DateTime.Now.ToString("d"));
                lstOut.Items.Add(DateTime.Now.ToString("T"));
                lstOut.Items.Add(DateTime.Now.ToString("t"));
                lstOut.Items.Add(DateTime.Now.ToString("G"));

                */
                // this makes the reset button the active control (reset is given the focus)
                btnReset.Focus();
            }
            else
            {
                // lstOut.Items.Add("Input error");
                if (!widgetsWorked)
                {
                    lstOut.Items.Add("Number of Widgets is not a whole number");
                }
                if (!rateValid)
                {
                    lstOut.Items.Add("Tax Rate is not a number");
                }

            }
        }
        const int LISTBOX = 1;
        const int LOGFILE = 2;
        const int BOTH = 3;
        private void outputMsg(string msg,int outputType)
        {
            StreamWriter sw;
            if (outputType == LISTBOX || outputType == BOTH)
            {
                lstOut.Items.Add(msg);
            }
            if (outputType == LOGFILE || outputType == BOTH)
            {
                sw = File.AppendText(widgetTransLog);
                sw.WriteLine(msg);       

                sw.Close();
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

        private void rdoEconomy_CheckedChanged(object sender, EventArgs e)
        {

            if (rdoEconomy.Checked)
            {
                widgetType = ECONOMY_MODEL;
            }
        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegular.Checked)
            {
                widgetType = REGULAR_MODEL;
            }
        }

        private void rdoDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDeluxe.Checked)
            {
                widgetType = DELUXE_MODEL;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///ICA 7
            bool fileValid = false; 
            rdoRegular.Checked = true;  // ica 6

            StreamReader sr;
            do {
                try
                {
                    sr = File.OpenText(widgetConfig);
                    fileValid = true;   
                    regularPrice = decimal.Parse(sr.ReadLine());
                    economyPrice = decimal.Parse(sr.ReadLine());
                    deluxePrice = decimal.Parse(sr.ReadLine());

                    sr.Close();
                } catch (FileNotFoundException ex)
                {
                    MessageBox.Show("Configuration file not found. Please select the correct file", "File not found");

                    // lstOut.Items.Add(ex.Message);
                    ofd.Filter = "Text Files|*.txt|All Files|*.*";
                    ofd.ShowDialog();
                    widgetConfig = ofd.FileName;
                }
            } while (!fileValid);

            }
    }
}
