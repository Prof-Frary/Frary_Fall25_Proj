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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 84);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(154, 81);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(166, 23);
            txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 128);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Widgets\r\n";
            // 
            // txtNumWidgets
            // 
            txtNumWidgets.Location = new Point(154, 124);
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
            // 
            // btnCalculation
            // 
            btnCalculation.Location = new Point(15, 283);
            btnCalculation.Name = "btnCalculation";
            btnCalculation.Size = new Size(75, 43);
            btnCalculation.TabIndex = 5;
            btnCalculation.Text = "Calculate Total";
            btnCalculation.UseVisualStyleBackColor = true;
          //  btnCalculation.Click += btnCalculation_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(133, 283);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 43);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(260, 283);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 43);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(384, 411);
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
    }
}
