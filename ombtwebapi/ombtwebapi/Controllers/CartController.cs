using ombtwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ombtwebapi.Controllers
{
    public class CartController : ApiController
    {

        OmbtContext Oc = new OmbtContext();

        [HttpGet]
        public IEnumerable<Cart> GetCarts()
        {
            return Oc.Carts.ToList();
        }
        [HttpGet]
        public Cart GetCart(int id)
        {
            return Oc.Carts.Find(id);
        }
        [HttpPost]
        public bool AddCart(Cart c1)
        {
            bool successflag = false;
            Oc.Carts.Add(c1);
            Oc.SaveChanges();
            successflag = true;
            return successflag;
        }
        [HttpPut]
        public bool UpdateCart(Cart c1)
        {
            bool successflag = false;
            var cartindb = Oc.Carts.SingleOrDefault(x => x.CartId == c1.CartId);
            if (cartindb != null)
            {
                cartindb.Amnt = c1.Amnt;
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
        [HttpDelete]
        public bool DeleteCart(int id)
        {
            bool successflag = false;
            var cartindb = Oc.Carts.SingleOrDefault(x => x.CartId == id);
            if (cartindb != null)
            {
                Oc.Carts.Remove(cartindb);
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }

    }
}

