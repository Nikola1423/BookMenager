using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
    public string InsertProduct(products product)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();
            db.products.Add(product);
            db.SaveChanges();

            return product.Name + "was succesfully inserted";
        }
        catch(Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateProduct(int id, products product)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();

            products p = db.products.Find(id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.TypeId = product.TypeId;
            p.Description = product.Description;
            p.Image = product.Image;

            db.SaveChanges();
            return product.Name + "was succesfully inserted";
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
            products product = db.products.Find(id);
            db.products.Remove(product);
            db.SaveChanges();

            return product.Name + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public products GetProduct(int id)
    {
        try
        {
    using(BookDBEntities db = new BookDBEntities())
            {
                products product = db.products.Find(id);
                return product;
            }
        }
        catch(Exception e)
        {
            return null;
        }
    }
    public List<products> GetAllProducts()
    {
        try
        {
            using (BookDBEntities db = new BookDBEntities()) {
                List<products> products = (from x in db.products
             select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<products> GetProductsByType(int typeId)
    {
        try
        {
            using (BookDBEntities db = new BookDBEntities())
            {
                List<products> products = (from x in db.products
                                           where x.TypeId==typeId
                                           select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}