using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab04_27
{
    public partial class bookstay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = theName.Text;
            int pax = Int32.Parse(adults.Text);
            string roomType = my_interest.SelectedItem.Value;
            List<ListItem> opFeat = new List<ListItem>();
            foreach(ListItem item in actual_interest.Items)
            {
                if (item.Selected)
                {
                    opFeat.Add(item);
                }
            }
            string secret = pass.Text;
            Response.Write($"Thank You , {name} for your booking...<br/>");
            Response.Write($"{name} your booking for {pax} people in " +
                $"our {roomType} room is confirmed. <br />");
            Response.Write($"{name} your secret is {pass.Text} <br/>");
            Response.Write($"{name} Thank You for choosing following facilities. <br/>");   
            foreach(ListItem temp in opFeat)
            {
                Response.Write(temp.Text + "<br/>");
            }
            Response.Write("Take Care!!");
        }
    }
}