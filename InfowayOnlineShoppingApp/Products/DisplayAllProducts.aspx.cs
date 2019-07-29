using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InfowayOnlineShoppingApp.Models;

namespace InfowayOnlineShoppingApp.Products
{
    public partial class DisplayAllProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            DataListItem selectedProduct = e.Item;
            string productId = ((HiddenField)selectedProduct.FindControl("hiddenProductId")).Value;

            if(e.CommandName=="View Details")
            {
                Response.Redirect("~/Products/ProductDetails.aspx?id="+productId);
            }
            else
            {
                List<ShoppingCartDetail> shoppingCartDetails;

                if (Session["ShoppingCart"] == null)
                {
                    shoppingCartDetails = new List<ShoppingCartDetail>() {

                        new ShoppingCartDetail()
                        {
                            ProductId=int.Parse(productId),
                            Qty=1,
                            Discount=10
                        }
                    };
                }
                else
                {
                    shoppingCartDetails = Session["ShoppingCart"] as List<ShoppingCartDetail>;
                    shoppingCartDetails.Add(new ShoppingCartDetail() {
                        ProductId = int.Parse(productId),
                        Qty = 1,
                        Discount = 10
                    });

                }
                Session["ShoppingCart"] = shoppingCartDetails;
                Response.Redirect("~/ShoppingCart/DisplayCartDetails.aspx");
            }
        }
    }
}