﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MyShop.Core.Contracts;
using MyShop.Core.Models;
using MyShop.Services;






namespace MyShop.Services
{
    public class BasketService
    {
        //IRepository<Product> productContext;
        //IRepository<Basket> basketContext;

        //public const string BasketSessionName = "eCommerceBasket";

        ////public BasketService(IRepository<Product> ProductContext, IRepository<Basket> BasketContext)
        ////{
        ////    this.basketContext = BasketContext;
        ////    this.productContext = ProductContext;
        ////}

        ////private Basket GetBasket(HttpContextBase http, bool createIfNull)
        ////{
        ////    HttpCookie cookie = httpContext.Request.Cookies.Get(BasketSessionName);

        ////    Basket basket = new Basket();

        //    if(cookie!=null)
        //    {
        //        string basketId = cookie.Value;
        //        if(!string.IsNullOrEmpty(basketId))
        //        { basket = basketContext.Find(basketId);

        //        }
        //        else
        //        {
        //            if (createIfNull)
        //            {
        //                basket = CreateNewBasket(HttpContext);
        //            }
        //        }

        //        return basket;
                            
        //    }

            //private Basket CreateNewBasket(HttpContextBase httpContext)
            //{
            //    Basket basket = new Basket();
            //    basketContext.Insert(basket);
            //    basketContext.Commit();

            //    HttpCookie cookie = new HttpCookie(BasketSessionName);
            //    cookie.Value = basket.Id;
            //    cookie.Expires = DateTime.Now.AddDays(1);
            //    httpContext.Response.Cookies.Add(cookie);

            //    return basket;
            //}

            ////public void AddToBasket(HttpContextBase httpContext, string productId)

            //{
            //    Basket basket = GetBasket(httpContext, true);
            //    BasketItem item = basket.BasketItems.FirstOrDefault(i => i.ProductId == productId);

            //    if(item == null)
            //    {
            //        item = new BasketItem()
            //        {
            //            BasketId = basket.Id,
            //            ProductId = productId,
            //            Quantity = 1
            //        };

            //        basket.BasketItems.Add(item);
            //    }
            //    else
            //    {
            //        item.Quantity = item.Quantity + 1;
            //    }

            //    basketContext.Commit();
            //}

            //PublicKey void RemoveFromBasket
        
        
    }
}
