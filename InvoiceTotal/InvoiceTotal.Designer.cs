namespace InvoiceTotal
{
    partial class InvoiceTotal
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.radPremiumCustomer = new System.Windows.Forms.RadioButton();
            this.radNormalCustomer = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.gbCustomerType = new System.Windows.Forms.GroupBox();
            this.radPC = new System.Windows.Forms.RadioButton();
            this.radNC = new System.Windows.Forms.RadioButton();
            this.chkSeniorCitizen = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.gbCustomerType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 640);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(170, 640);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(121, 208);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(108, 32);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "&Subtotal:";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Location = new System.Drawing.Point(121, 294);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(199, 32);
            this.lblDiscountPercent.TabIndex = 2;
            this.lblDiscountPercent.Text = "Discount Percent:";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.Location = new System.Drawing.Point(121, 376);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(206, 32);
            this.lblDiscountAmount.TabIndex = 4;
            this.lblDiscountAmount.Text = "Discount Amount:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(121, 465);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 32);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(390, 205);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(200, 39);
            this.txtSubtotal.TabIndex = 1;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Enabled = false;
            this.txtDiscountPercent.Location = new System.Drawing.Point(390, 291);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(200, 39);
            this.txtDiscountPercent.TabIndex = 3;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Enabled = false;
            this.txtDiscountAmount.Location = new System.Drawing.Point(390, 373);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(200, 39);
            this.txtDiscountAmount.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(390, 462);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 39);
            this.txtTotal.TabIndex = 7;
            // 
            // radPremiumCustomer
            // 
            this.radPremiumCustomer.Location = new System.Drawing.Point(0, 0);
            this.radPremiumCustomer.Name = "radPremiumCustomer";
            this.radPremiumCustomer.Size = new System.Drawing.Size(104, 24);
            this.radPremiumCustomer.TabIndex = 0;
            // 
            // radNormalCustomer
            // 
            this.radNormalCustomer.Location = new System.Drawing.Point(0, 0);
            this.radNormalCustomer.Name = "radNormalCustomer";
            this.radNormalCustomer.Size = new System.Drawing.Size(104, 24);
            this.radNormalCustomer.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(0, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(0, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 0;
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(0, 0);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 0;
            // 
            // radioButton6
            // 
            this.radioButton6.Location = new System.Drawing.Point(0, 0);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 24);
            this.radioButton6.TabIndex = 0;
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(0, 0);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 24);
            this.radioButton5.TabIndex = 0;
            // 
            // gbCustomerType
            // 
            this.gbCustomerType.Controls.Add(this.radPC);
            this.gbCustomerType.Controls.Add(this.radNC);
            this.gbCustomerType.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerType.Name = "gbCustomerType";
            this.gbCustomerType.Size = new System.Drawing.Size(326, 170);
            this.gbCustomerType.TabIndex = 10;
            this.gbCustomerType.TabStop = false;
            this.gbCustomerType.Text = "Customer Type";
            // 
            // radPC
            // 
            this.radPC.AutoSize = true;
            this.radPC.Location = new System.Drawing.Point(24, 119);
            this.radPC.Name = "radPC";
            this.radPC.Size = new System.Drawing.Size(251, 36);
            this.radPC.TabIndex = 1;
            this.radPC.Text = "Premium Customer";
            this.radPC.UseVisualStyleBackColor = true;
            // 
            // radNC
            // 
            this.radNC.AutoSize = true;
            this.radNC.Checked = true;
            this.radNC.Location = new System.Drawing.Point(24, 57);
            this.radNC.Name = "radNC";
            this.radNC.Size = new System.Drawing.Size(234, 36);
            this.radNC.TabIndex = 0;
            this.radNC.TabStop = true;
            this.radNC.Text = "Normal Customer";
            this.radNC.UseVisualStyleBackColor = true;
            // 
            // chkSeniorCitizen
            // 
            this.chkSeniorCitizen.AutoSize = true;
            this.chkSeniorCitizen.Location = new System.Drawing.Point(390, 542);
            this.chkSeniorCitizen.Name = "chkSeniorCitizen";
            this.chkSeniorCitizen.Size = new System.Drawing.Size(205, 36);
            this.chkSeniorCitizen.TabIndex = 11;
            this.chkSeniorCitizen.Text = "Senior Citizen?";
            this.chkSeniorCitizen.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(36, 588);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 32);
            this.lblResult.TabIndex = 12;
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1093, 763);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.chkSeniorCitizen);
            this.Controls.Add(this.gbCustomerType);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.lblDiscountPercent);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Name = "InvoiceTotal";
            this.Text = "InvoiceTotal";
            this.gbCustomerType.ResumeLayout(false);
            this.gbCustomerType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private Button btnCalculate;
        private Label lblSubtotal;
        private Label lblDiscountPercent;
        private Label lblDiscountAmount;
        private Label lblTotal;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox txtDiscountAmount;
        private TextBox txtTotal;
        private RadioButton radPremiumCustomer;
        private RadioButton radNormalCustomer;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox gbCustomerType;
        private RadioButton radPC;
        private RadioButton radNC;
        private CheckBox chkSeniorCitizen;
        private Label lblResult;
    }
}