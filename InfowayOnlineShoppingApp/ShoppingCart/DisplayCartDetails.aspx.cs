using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InfowayOnlineShoppingApp.Dal;
using InfowayOnlineShoppingApp.Models;
using System.Data;


namespace InfowayOnlineShoppingApp.ShoppingCart
{
    public partial class DisplayCartDetails : System.Web.UI.Page
    {
        ProductDal dal = new ProductDal();
        List<CustomerProductDetail> displaydetails = new List<CustomerProductDetail>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            DataRow row = null;
            foreach (ShoppingCartDetail details in Session["ShoppingCart"] as List<ShoppingCartDetail>)
            {
                row = dal.GetAllProducts(details.ProductId).Rows[0];
                displaydetails.Add(
                    new CustomerProductDetail() {
                        ProductId = int.Parse(row[0].ToString()),
                        ProductName = row[1].ToString(),
                        UnitPrice = int.Parse(row[7].ToString()),
                        Qty = details.Qty,
                        Discount=details.Discount
                    });

            }
                CustomerProductDetail.Total += int.Parse(row[7].ToString());
            purchasedProductDisplay.DataSource = displaydetails;
            purchasedProductDisplay.DataBind();
            }
            catch (Exception ex)
            {

            }
        }

        public void ShowTotal()
        {
            Response.Write(CustomerProductDetail.Total);
        }
    }
}