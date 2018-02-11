using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pages_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }
    private void FillPage()
    {
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))//ako sme selektirale nesto, t.e delot za id od redot ne e null
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ProductModel productModel = new ProductModel();
            products product = productModel.GetProduct(id);

            lblPrice.Text = "Price per unit: <br/>$ " + product.Price;
            lblTitle.Text = product.Name;
            lblDiscription.Text = product.Description;
            lblItemNr.Text = id.ToString();
            imgProduct.ImageUrl = "~/books/products/"+product.Image;

            int[] amount = Enumerable.Range(1, 20).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();

        }
        
    }

    protected void imgProduct_Load(object sender, EventArgs e)
    {

    }
}