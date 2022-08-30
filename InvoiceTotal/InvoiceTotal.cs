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

            txtDiscountPercent.Text = discountPercent.ToString("P2"); // Percent format with 2 decimal places
            txtDiscountAmount.Text = discountAmount.ToString("C"); // Currency format
            txtTotal.Text = total.ToString("C");

            // Move the focus to the Subtotal textbox
            txtSubtotal.Focus(); 
        }
    }
}