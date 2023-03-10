using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2image
{
    public partial class WebImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set the default selection of the dropdown list.
                ddlItems.SelectedIndex = 0;
            }

        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the dropdown list.
            int selectedItem = int.Parse(ddlItems.SelectedValue);

            // Set the image URL based on the selected item.
            switch (selectedItem)
            {
                case 1:
                    imgItem.ImageUrl = "images/image.jfif";
                    break;
                case 2:
                    imgItem.ImageUrl = "images/image2.jfif";
                    break;
                case 3:
                    imgItem.ImageUrl = "images/image3.jfif";
                    break;
                default:
                    imgItem.ImageUrl = "";
                    break;
            }
        }

        protected void btnCost_Click(object sender, EventArgs e)
        {
            // Get the selected item from the dropdown list.
            int selectedItem = int.Parse(ddlItems.SelectedValue);

            // Set the cost of the selected item.
            switch (selectedItem)
            {
                case 1:
                    lbCost.Text = "Item 1 costs 110.";
                    break;
                case 2:
                   lbCost.Text = "Item 2 costs 520.";
                    break;
                case 3:
                    lbCost.Text = "Item 3 costs 930.";
                    break;
                default :
                    lbCost.Text = "Item 3 costs 930.";
                    break;

            }
        }
    }
}
