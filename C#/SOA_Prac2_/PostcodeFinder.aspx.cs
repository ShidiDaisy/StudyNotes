using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INFS3204_Prac2
{
    public partial class PostcodeFinder1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            timeLabel.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
        }

    }
}