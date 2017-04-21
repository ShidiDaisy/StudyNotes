using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFS3204_Prac2
{
    public partial class ZodiacFinderWebApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getDateButton_Click(object sender, EventArgs e)
        {
            ServiceReferenceZodiac.ZodiacFinderSoapClient dateClient = new ServiceReferenceZodiac.ZodiacFinderSoapClient();
            string dateResult = dateClient.ZodiacDate(nameTextBox.Text);
            dateTextBox.Text = dateResult;
        }

        protected void getNameButton_Click(object sender, EventArgs e)
        {
            ServiceReferenceZodiac.ZodiacFinderSoapClient nameClient = new ServiceReferenceZodiac.ZodiacFinderSoapClient();
            int mon = int.Parse(monTextBox.Text);
            int day = int.Parse(dayTextBox.Text);
            string nameResult = nameClient.ZodiacName(day, mon);
            nameOutputTextBox.Text = nameResult;
        }
    }
}