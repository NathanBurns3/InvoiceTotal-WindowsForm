namespace InvoiceTotal
{
    public partial class InvoiceTotal : Form
    {
        public InvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /****************************************
             * This method calculates the total
             * for the invoice depending on a
             * discount that's based on the subtotal
            ****************************************/

            //get the subtotal amount from the Subtotal text box
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            // set the discountPercent variable based
            // on the value of the subtotal variable
            decimal discountPercent = 0m;  // "m" indicates a decimal value

            if (subtotal > 100 || subtotal <= 250)
            {
                discountPercent = .10m;
            }
            else if (subtotal > 250 && subtotal <= 500)
            {
                discountPercent = .15m;
            }
            else if (subtotal > 500)
            {
                discountPercent = .20m;
            }

            // calculate and assign the values for the
            // discountAmount and invoiceTotal variables
            var discountAmount = subtotal * discountPercent;
            var total = subtotal - discountAmount;

            // Get the status of the radio buttons and
            // Checkboxes and assign them to variables
            var isSeniorCitizen = chkSeniorCitizen.Checked;
            var isPremiumCustomer = radPC.Checked;

            // set the senior and premium discount variables
            var snrDiscount = 0m;
            var premiumDiscount = 0m;

            // set the snrDiscount variable based on the
            // value of the isSeniorCitizen variable
            if (isSeniorCitizen)
            {
                snrDiscount = total * .1m;
                total *= .9m;
            }

            // set the premiumDiscount variable based on
            // the value of the isPremiumCustomer variable
            if (isPremiumCustomer)
            {
                premiumDiscount = total * .1m;
                total *= .9m;
            }

            lblResult.Text = $"Your Senior Citizen discount is {snrDiscount.ToString("C")} and your Premium Customer discount is {premiumDiscount.ToString("C")}";

            txtDiscountPercent.Text = discountPercent.ToString("P2"); // Percent format with 2 decimal places
            txtDiscountAmount.Text = discountAmount.ToString("C"); // Currency format
            txtTotal.Text = total.ToString("C");

            // Move the focus to the Subtotal textbox
            txtSubtotal.Focus(); 
        }
    }
}