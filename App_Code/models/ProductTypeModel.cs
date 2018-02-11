using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for productTypesTypesModel
/// </summary>
public class ProductTypesModel
{
    public string InsertProductType(ProductTypes productType)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();
            db.ProductTypes.Add(productType);
            db.SaveChanges();

            return productType.Name + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateProduct(int id, ProductTypes productType)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();

            ProductTypes p = db.ProductTypes.Find(id);

            p.Name = productType.Name;
            

            db.SaveChanges();
            return productType.Name + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string DeleteProduct(int id)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();
           ProductTypes productType = db.ProductTypes.Find(id);
            db.ProductTypes.Remove(productType);
            db.SaveChanges();

            return productType.Name + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}