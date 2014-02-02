using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KassaKvitto_Labb1.Summary;
namespace KassaKvitto_Labb1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                formPlaceHolder.Visible = true;
                
                
                try
                {
                    Receipt receipt = new Receipt(double.Parse(sumTextBox.Text));
                    subTotalLabel.Text = string.Format("Summa: {0:c} ", receipt.Subtotal);
                    discountLabel.Text = string.Format("Rabattsats:  {0:p0}", receipt.DiscountRate);
                    moneyOffLabel.Text = string.Format("Rabatt:      {0:c} ", receipt.MoneyOff);
                    totalSumLabel.Text = string.Format("Att betala:  {0:c} ", receipt.Total);
                }
                catch(Exception ex)
                {
                    var validator = new CustomValidator
                    {
                        IsValid = false,
                        ErrorMessage = ex.Message
                    };
                    Page.Validators.Add(validator);
                }
                


            }
        }
    }
}