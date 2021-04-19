using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2021MidSample
{
    public partial class Sample1Com : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb_Res.Text = Request.Form.Get("tb_Acc") + "<br />";
            lb_Res.Text = lb_Res.Text + Request.Form.Get("tb_Pass") + "<br />";
            if (Request.Form.Get("CheckBox1") == "on")
            {
                lb_Res.Text = lb_Res.Text + "看書"+ "<br />";
            }
            if (Request.Form.Get("CheckBox2") == "on")
            {
                lb_Res.Text = lb_Res.Text + "打電動" + "<br />";
            }
            if (Request.Form.Get("CheckBox3") == "on")
            {
                lb_Res.Text = lb_Res.Text + "其他" + "<br />";
            }


        }
    }
}