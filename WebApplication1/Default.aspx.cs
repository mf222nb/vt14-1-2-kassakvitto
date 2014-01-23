using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                var receipt = new Model.Receipt(double.Parse(MyTextBox.Text));

                RecieptPanel.Visible = true;
                SubtotalLabel.Text = string.Format("Total: {0:c}", receipt.Subtotal);
                DiscountRateLabel.Text = string.Format("Rabattsats: {0:p0}", receipt.DiscountRate);
                DiscountLabel.Text = string.Format("Rabatt: {0:c}", receipt.MoneyOff);
                TotalLabel.Text = string.Format("Att betala: {0:c}", receipt.Total);
            }
        }
    }
}