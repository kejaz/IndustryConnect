using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class TempService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            TempServiceReference.TempServiceSoapClient service = new TempServiceReference.TempServiceSoapClient();
            txtCel.Text =  service.ConvertFahrenheitToCelsius(Convert.ToDouble(txtFaf.Text)).ToString();
        }
    }
}