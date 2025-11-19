namespace Frary_Fall25_Proj
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRegularPrice = new TextBox();
            txtEconomyPrice = new TextBox();
            txtDeluxePrice = new TextBox();
            btnSaveReturn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 19);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 0;
            label1.Text = "Widget Price Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F);
            label2.Location = new Point(44, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 1;
            label2.Text = "Regular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F);
            label3.Location = new Point(44, 113);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 2;
            label3.Text = "Economy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F);
            label4.Location = new Point(49, 154);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 3;
            label4.Text = "Deluxe";
            // 
            // txtRegularPrice
            // 
            txtRegularPrice.Location = new Point(138, 71);
            txtRegularPrice.Name = "txtRegularPrice";
            txtRegularPrice.Size = new Size(100, 23);
            txtRegularPrice.TabIndex = 4;
            // 
            // txtEconomyPrice
            // 
            txtEconomyPrice.Location = new Point(138, 112);
            txtEconomyPrice.Name = "txtEconomyPrice";
            txtEconomyPrice.Size = new Size(100, 23);
            txtEconomyPrice.TabIndex = 5;
            // 
            // txtDeluxePrice
            // 
            txtDeluxePrice.Location = new Point(138, 154);
            txtDeluxePrice.Name = "txtDeluxePrice";
            txtDeluxePrice.Size = new Size(100, 23);
            txtDeluxePrice.TabIndex = 6;
            // 
            // btnSaveReturn
            // 
            btnSaveReturn.Location = new Point(104, 233);
            btnSaveReturn.Name = "btnSaveReturn";
            btnSaveReturn.Size = new Size(75, 49);
            btnSaveReturn.TabIndex = 7;
            btnSaveReturn.Text = "&Save && Return";
            btnSaveReturn.UseVisualStyleBackColor = true;
            btnSaveReturn.Click += btnSaveReturn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 334);
            Controls.Add(btnSaveReturn);
            Controls.Add(txtDeluxePrice);
            Controls.Add(txtEconomyPrice);
            Controls.Add(txtRegularPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form2";
            Text = "Frary's Widget Settings Form";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRegularPrice;
        private TextBox txtEconomyPrice;
        private TextBox txtDeluxePrice;
        private Button btnSaveReturn;
    }
}