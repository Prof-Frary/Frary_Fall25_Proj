using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frary_Fall25_Proj
{
    public partial class Form2 : Form
    {
        Form1 transactionForm;
        public Form2(Form1 ff)
        {
            InitializeComponent();
            // ff is a local variable but the code needs a Class level variable
            // so the TransactionForm variable was created on the class level
            // and set to ff
            transactionForm = ff;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveReturn_Click(object sender, EventArgs e)
        {
            // temp variable needed since tryparse does not allow Properties in out parameter
            decimal tempPrice;
            bool regOK, econOK, dxOK;
            regOK = decimal.TryParse(txtRegularPrice.Text, out tempPrice);
            if (regOK)
            {
                transactionForm.RegularPrice = tempPrice;
                // set the regular price property
                
            }
            this.Hide();
        }
    }
}
