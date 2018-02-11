using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertProduct(Cart cart)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();
            db.Cart.Add(cart);
            db.SaveChanges();

            return cart.DatePurchased + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
    public string UpdateProduct(int id, Cart cart)
    {
        try
        {
            BookDBEntities db = new BookDBEntities();

            Cart p = db.Cart.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;


            db.SaveChanges();
            return cart.DatePurchased + "was succesfully inserted";
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
           Cart cart = db.Cart.Find(id);
            db.Cart.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}