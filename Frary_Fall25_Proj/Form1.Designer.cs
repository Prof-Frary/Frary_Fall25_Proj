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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 52);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(154, 44);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(166, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 96);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Widgets\r\n";
            // 
            // txtNumWidgets
            // 
            txtNumWidgets.Location = new Point(154, 92);
            txtNumWidgets.Name = "txtNumWidgets";
            txtNumWidgets.Size = new Size(166, 23);
            txtNumWidgets.TabIndex = 3;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(34, 170);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(286, 94);
            lstOut.TabIndex = 4;
            lstOut.TabStop = false;
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(15, 283);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(75, 43);
            btnCalculation.TabIndex = 5;
            btnCalculation.Text = "&Calculate Total";
            btnCalculation.UseVisualStyleBackColor = true;
            btnCalculation.Click += btnCalculation_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(133, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 43);
            btnReset.TabIndex = 6;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(260, 283);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 43);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // txtTaxRate
            // 
            txtTaxRate.Location = new Point(154, 126);
            txtTaxRate.Name = "txtTaxRate";
            txtTaxRate.Size = new Size(166, 23);
            txtTaxRate.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 8;
            label3.Text = "Tax Rate\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(348, 411);
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
    }
}
