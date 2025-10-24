namespace Frary_Fall25_Proj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCustomerName = new TextBox();
            label2 = new Label();
            txtNumWidgets = new TextBox();
            lstOut = new ListBox();
            btnCalculation = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            txtTaxRate = new TextBox();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            rdoDeluxe = new RadioButton();
            rdoRegular = new RadioButton();
            rdoEconomy = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 86);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(153, 78);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(166, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 130);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Widgets\r\n";
            // 
            // txtNumWidgets
            // 
            txtNumWidgets.Location = new Point(153, 126);
            txtNumWidgets.Name = "txtNumWidgets";
            txtNumWidgets.Size = new Size(141, 23);
            txtNumWidgets.TabIndex = 3;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(14, 196);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(305, 169);
            lstOut.TabIndex = 4;
            lstOut.TabStop = false;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(-1, 371);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(75, 43);
            btnCalculation.TabIndex = 5;
            btnCalculation.Text = "&Calculate Total";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += btnCalculation_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(117, 371);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 43);
            btnReset.TabIndex = 6;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(244, 371);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 43);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(153, 160);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(141, 23);
            txtTaxRate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 164);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Tax Rate\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 164);
            label4.Name = "label4";
            label4.Size = new Size(19, 17);
            label4.TabIndex = 9;
            label4.Text = "%";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDeluxe);
            groupBox1.Controls.Add(rdoRegular);
            groupBox1.Controls.Add(rdoEconomy);
            groupBox1.Location = new Point(14, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 49);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Widget Model Type";
            // 
            // rdoDeluxe
            // 
            rdoDeluxe.AutoSize = true;
            rdoDeluxe.Location = new Point(219, 22);
            rdoDeluxe.Name = "rdoDeluxe";
            rdoDeluxe.Size = new Size(61, 19);
            rdoDeluxe.TabIndex = 2;
            rdoDeluxe.Text = "Deluxe";
            rdoDeluxe.UseVisualStyleBackColor = true;
            rdoDeluxe.CheckedChanged += rdoDeluxe_CheckedChanged;
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(16, 22);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(65, 19);
            rdoRegular.TabIndex = 1;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            rdoRegular.CheckedChanged += rdoRegular_CheckedChanged;
            // 
            // rdoEconomy
            // 
            rdoEconomy.AutoSize = true;
            rdoEconomy.Location = new Point(109, 22);
            rdoEconomy.Name = "rdoEconomy";
            rdoEconomy.Size = new Size(75, 19);
            rdoEconomy.TabIndex = 0;
            rdoEconomy.Text = "Economy";
            rdoEconomy.UseVisualStyleBackColor = true;
            rdoEconomy.CheckedChanged += rdoEconomy_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(348, 441);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(txtTaxRate);
            Controls.Add(label3);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCalculation);
            Controls.Add(lstOut);
            Controls.Add(txtNumWidgets);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Frary's Widget - Transaction Form";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtNumWidgets;
        private ListBox lstOut;
        private Button btnCalculation;
        private Button btnReset;
        private Button btnQuit;
        private TextBox txtTaxRate;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rdoDeluxe;
        private RadioButton rdoRegular;
        private RadioButton rdoEconomy;
    }
}
